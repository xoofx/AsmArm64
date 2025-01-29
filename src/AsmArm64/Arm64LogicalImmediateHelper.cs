// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
// Original code by Dougall J with CC0 license: https://creativecommons.org/publicdomain/zero/1.0/

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Helper methods to encode / decode logical immediates for AArch64.
/// </summary>
/// <remarks>
/// Full credits to from Dougall J
/// Code from https://gist.github.com/dougallj/97d8621d4542ba31e004acc8075fac14
/// https://dougallj.wordpress.com/2021/10/30/bit-twiddling-optimising-aarch64-logical-immediate-encoding-and-decoding/
/// CC0 license: https://creativecommons.org/publicdomain/zero/1.0/
/// </remarks>
internal static class Arm64LogicalImmediateHelper
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int EncodeLogicalImmediate64(ulong val)
    {
        // Consider an ARM64 logical immediate as a pattern of "o" ones preceded
        // by "z" more-significant zeroes, repeated to fill a 64-bit integer.
        // o > 0, z > 0, and the size (o + z) is a power of two in [2,64]. This
        // part of the pattern is encoded in the fields "imms" and "N".
        //
        // "immr" encodes a further right rotate of the repeated pattern, allowing
        // a wide range of useful bitwise constants to be represented.
        //
        // (The spec describes the "immr" rotate as rotating the "o + z" bit
        // pattern before repeating it to fill 64-bits, but, as it's a repeating
        // pattern, rotating afterwards is equivalent.)

        // This encoding is not allowed to represent all-zero or all-one values.
        if (val == 0 || ~val == 0)
            ThrowInvalidLogicalImmediateValue();

        // To detect an immediate that may be encoded in this scheme, we first
        // remove the right-rotate, by rotating such that the least significant
        // bit is a one and the most significant bit is a zero.
        //
        // We do this by clearing any trailing one bits, then counting the
        // trailing zeroes. This finds an "edge", where zero goes to one.
        // We then rotate the original value right by that amount, moving
        // the first one to the least significant bit.

        int rotation = BitOperations.TrailingZeroCount(val & (val + 1)); // Clear trailing ones
        ulong normalized = BitOperations.RotateRight(val, rotation & 63);

        // Now we have normalized the value, and determined the rotation, we can
        // determine "z" by counting the leading zeroes, and "o" by counting the
        // trailing ones. (These will both be positive, as we already rejected 0
        // and ~0, and rotated the value to start with a zero and end with a one.)

        int zeroes = BitOperations.LeadingZeroCount(normalized);
        int ones = BitOperations.TrailingZeroCount(~normalized);
        int size = zeroes + ones;

        // Detect the repeating pattern (by comparing every repetition to the
        // one next to it, using rotate).

        if (BitOperations.RotateRight(val, size & 63) != val)
            ThrowInvalidLogicalImmediateValue();

        // We do not need to further validate size to ensure it is a power of two
        // between 2 and 64. The only "minimal" patterns that can repeat to fill a
        // 64-bit value must have a length that is a factor of 64 (i.e. it is a
        // power of two in the range [1,64]). And our pattern cannot be of length
        // one (as we already rejected 0 and ~0).
        //
        // By "minimal" patterns I refer to patterns which do not themselves
        // contain repetitions. For example, '010101' is a non-minimal pattern of
        // a non-power-of-two length that can pass the above rotational test. It
        // consists of the minimal pattern '01'. All our patterns are minimal, as
        // they contain only one contiguous run of ones separated by at least one
        // zero.

            // Finally, we encode the values. "rotation" is the amount we rotated
            // right by to "undo" the right-rotate encoded in immr, so must be
            // negated.

            // size 2:  N=0 immr=00000r imms=11110s
            // size 4:  N=0 immr=0000rr imms=1110ss
            // size 8:  N=0 immr=000rrr imms=110sss
            // size 16: N=0 immr=00rrrr imms=10ssss
            // size 32: N=0 immr=0rrrrr imms=0sssss
            // size 64: N=1 immr=rrrrrr imms=ssssss
        int immr = -rotation & (size - 1);
        int imms = -(size << 1) | (ones - 1);
        int N = (size >> 6);

        return (N << 12) | (immr << 6) | (imms & 0x3f);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int EncodeLogicalImmediate32(uint val) => EncodeLogicalImmediate64(((ulong)val << 32) | val);


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValidLogicalImmediate64(uint val)
    {
        uint N = (val >> 12) & 1;
        uint imms = val & 0x3f;
        uint pattern = (N << 6) | (~imms & 0x3f);
        return (pattern & (pattern - 1)) != 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValidLogicalImmediate32(uint value)
    {
        uint N = (value >> 12) & 1;
        return N == 0 && IsValidLogicalImmediate64(value);
    }

    public static ulong DecodeLogicalImmediate64(uint value)
    {
        uint N = (value >> 12) & 1;
        int immr = (int)((value >> 6) & 0x3f);
        uint imms = value & 0x3f;

        uint pattern = (N << 6) | (~imms & 0x3f);

        if ((pattern & (pattern - 1)) == 0) ThrowInvalidLogicalImmediateValue();

        int leading_zeroes = BitOperations.LeadingZeroCount(pattern);
        uint imms_mask = 0x7fffffffU >> leading_zeroes;
        ref var mask_lookup_ref = ref MemoryMarshal.GetReference(mask_lookup);
        int index = leading_zeroes - 25;
        Debug.Assert(index < 6);
        ulong mask = Unsafe.Add(ref mask_lookup_ref, index);
        uint S = (imms + 1) & imms_mask;
        return BitOperations.RotateRight(mask ^ (mask << (int)S), immr);
    }

    public static uint DecodeLogicalImmediate32(uint val)
    {
        uint N = (val >> 12) & 1;
        if (N != 0) return DECODE_FAILED;
        return (uint)DecodeLogicalImmediate64(val);
    }

    private const int DECODE_FAILED = 0;

    private static ReadOnlySpan<ulong> mask_lookup =>
    [
        0xffffffffffffffffUL, // size = 64
        0x00000000ffffffffUL, // size = 32
        0x0000ffff0000ffffUL, // size = 16
        0x00ff00ff00ff00ffUL, // size = 8
        0x0f0f0f0f0f0f0f0fUL, // size = 4
        0x3333333333333333UL // size = 2
    ];

    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidLogicalImmediateValue() => throw new ArgumentException("Invalid logical immediate value", "value");

    ///// <summary>
    ///// Decode AArch64 bitfield and logical immediate masks which use a similar encoding structure
    ///// </summary>
    ///// <param name="value"></param>
    ///// <param name="immediate"></param>
    //public static (int wmask, int tmask) DecodeBitMask32(int value, bool immediate)
    //{
    //    int immN = (value >> 12) & 1;
    //    int immr = (value >> 6) & 0b111111;
    //    int imms = value & 0b111111;

    //    // const int M = 32

    //    // Compute log2 of element size
    //    // 2^len must be in range [2, M]
    //    // constant integer len = HighestSetBit(immN:NOT(imms));
    //    int len = 31 - BitOperations.LeadingZeroCount((uint)((immN << 6) | (imms) ^ 0b111_111));
    //    // if len < 1 then UNDEFINED;
    //    if (len < 1)
    //    {
    //        throw new InvalidOperationException();
    //    }

    //    // assert M >= (1 << len);
    //    Debug.Assert(32 >= (1 << len));

    //    // Determine s, r and s - r parameters
    //    int levels = (1 << len) - 1;
    //    // // For logical immediates an all-ones value of s is reserved
    //    // // since it would generate a useless all-ones result (many times)
    //    // if immediate && (imms AND levels) == levels then
    //    if (immediate && (imms & levels) == levels)
    //    {
    //        throw new InvalidOperationException();
    //    }
    //    // constant integer s = UInt(imms AND levels);
    //    int s = imms & levels;
    //    // constant integer r = UInt(immr AND levels);
    //    int r = immr & levels;
    //    // constant integer diff = s - r; // 6-bit subtract with borrow
    //    int diff = s - r; // 6-bit subtract with borrow
    //    // constant integer esize = 1 << len;
    //    int esize = 1 << len;
    //    // constant integer d = UInt(diff<len-1:0>);
    //    int d = diff & ((1 << (len - 1)) - 1);
    //    // welem = ZeroExtend(Ones(s + 1), esize);
    //    int welem = (1 << (s + 1)) - 1;
    //    // telem = ZeroExtend(Ones(d + 1), esize);
    //    int telem = (1 << (d + 1)) - 1;
    //    // wmask = Replicate(ROR(welem, r), M DIV esize);
    //    int wmask = Replicate(BitOperations.RotateRight((uint)welem, r), esize);
    //    // tmask = Replicate(telem, M DIV esize);
    //    int tmask = Replicate((uint)telem, 32 / esize);
    //    // return (wmask, tmask);
    //    return (wmask, tmask);
    //}
}