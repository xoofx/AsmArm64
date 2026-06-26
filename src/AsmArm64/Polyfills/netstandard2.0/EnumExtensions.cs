// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
using System.Diagnostics.CodeAnalysis;

namespace System;

internal static class EnumExtensions
{
    extension(Enum)
    {
        public static bool TryFormat<TEnum>(TEnum value, Span<char> destination, out int charsWritten, [StringSyntax(StringSyntaxAttribute.EnumFormat)] ReadOnlySpan<char> format = default)
            where TEnum : struct, Enum
        {
            value.TryFormat(destination, out charsWritten, format);
            return charsWritten > 0;
        }

        public static bool IsDefined<TEnum>(TEnum value)
            where TEnum : struct, Enum
        {
            return Enum.IsDefined(typeof(TEnum), value);
        }
    }

    extension<T>(T value)
        where T : struct, IFormattable
    {
        public bool TryFormat(
            Span<char> destination,
            out int charsWritten,
            ReadOnlySpan<char> format = default,
            IFormatProvider? provider = null)
        {
            string text =
                value.ToString(
                format.IsEmpty ? null : format.ToString(),
                provider);

            if (text.Length > destination.Length)
            {
                charsWritten = 0;
                return false;
            }

            text.AsSpan().CopyTo(destination);
            charsWritten = text.Length;
            return true;
        }
    }
}
#endif