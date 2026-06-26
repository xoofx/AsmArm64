// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System.Runtime.CompilerServices;

internal static class UnsafeExtensions
{
    extension(Unsafe)
    {
        // Exceptions:
        //   T:System.NotSupportedException:
        //     The size of TFrom and TTo are not the same.
        public static TTo BitCast<TFrom, TTo>(TFrom source)
            where TFrom : struct
            where TTo : struct
        {
            if (Unsafe.SizeOf<TFrom>() != Unsafe.SizeOf<TTo>())
                throw new NotSupportedException("Source and destination types must have the same size.");

            return Unsafe.As<TFrom, TTo>(ref source);
        }
    }
}
#endif