// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System.Collections.Generic;

internal static class StringExtensions
{
    extension(string value)
    {
        public bool TryCopyTo(Span<char> destination)
        {
            if (destination.Length < value.Length)
                return false;

            value.AsSpan().CopyTo(destination);
            return true;
        }
    }
}
#endif