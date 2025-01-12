// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
enum Arm64ImmediateEncodingKind : byte
{
    None,
    /// <summary>
    /// A regular immediate
    /// </summary>
    Regular,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]"
    /// </summary>
    SimdBitShiftType0,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = RESERVED]"
    /// </summary>
    SimdBitShiftType1,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = RESERVED,001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]"
    /// </summary>
    SimdBitShiftType2,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = RESERVED]"
    /// </summary>
    SimdBitShiftType3,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = UInt(immh:immb) - 64]"
    /// </summary>
    SimdBitShiftType4,
    /// <summary>
    /// Rotation encoded in 1 bit. [0 = 90,1 = 270]
    /// </summary>
    Rotate90Or270,
    /// <summary>
    /// Rotation encoded in 2 bits. [00 = 0,01 = 90,10 = 180,11 = 270]
    /// </summary>
    Rotate0Or90Or180Or270,
    /// <summary>
    /// A fixed value
    /// </summary>
    FixedInt,
    /// <summary>
    /// A fixed value that is a float
    /// </summary>
    FixedFloatZero,
    /// <summary>
    /// Depending on the bit set of the encoding 0 -> 8, 1 -> 16
    /// </summary>
    EnumAmount8Or16,
    /// <summary>
    /// Depending on the value set in the bits: 00 -> 8, 01 -> 16, 10 -> 32, 11 -> RESERVED.
    /// </summary>
    SimdLeftShift8Or16Or32,
    /// <summary>
    /// Special immediate #index Size: 5 in instruction id EXT_asimdext_only - [(30:1),(14:4)] - Selector: Q,imm4&lt;3>
    /// 0:0 = UInt(imm4&lt;2:0>)
    /// 0:1 = RESERVED
    /// 1:x = UInt(imm4)
    /// </summary>
    SimdExtIndex,
    /// <summary>
    /// 64-bit immediate 'aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh'
    /// </summary>
    Imm64,
    /// <summary>
    /// A system register used my MRS and MSR.
    /// </summary>
    SystemRegister,
    /// <summary>
    /// A barrier operation limit used by DMB_bo_barriers and DSB_bo_barriers instructions.
    /// </summary>
    BarrierOperationLimit,
    PrefetchOperation,
    RangePrefetchOperation,
    /// <summary>
    /// Option for ISB instruction
    /// </summary>
    IsbOption,
}