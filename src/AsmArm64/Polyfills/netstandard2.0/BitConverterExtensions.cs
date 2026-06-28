// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
using System.Runtime.CompilerServices;

namespace System;

internal static class BitConverterExtensions
{
    extension(BitConverter)
    {
        public static float Int32BitsToSingle(int value) => Unsafe.BitCast<int, float>(value);

        public static int SingleToInt32Bits(float value) => Unsafe.BitCast<float, int>(value);

        public static uint ToUInt32(ReadOnlySpan<byte> value)
        {
            return ToUInt32(value.ToArray());
        }

        public static int ToInt32(ReadOnlySpan<byte> value)
        {
            return ToInt32(value.ToArray());
        }

        public static uint ToUInt32(byte[] value)
        {
            return BitConverter.ToUInt32(value, 0);
        }

        public static int ToInt32(byte[] value)
        {
            return BitConverter.ToInt32(value, 0);
        }
    }
}
#endif