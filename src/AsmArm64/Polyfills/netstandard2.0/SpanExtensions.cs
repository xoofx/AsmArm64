// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System;

internal static class SpanExtensions
{
    public static bool TryWrite(
        this Span<char> destination,
        string value,
        out int charsWritten)
    {
        return TryWrite(destination, null, value, out charsWritten);
    }

    public static bool TryWrite(
        this Span<char> destination,
        IFormatProvider? provider,
        string value,
        out int charsWritten)
    {
        if (provider != null)
            throw new ArgumentException();

        string text = value;
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
#endif