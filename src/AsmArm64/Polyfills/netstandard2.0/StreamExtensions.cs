// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System.IO;

internal static class StreamExtensions
{
    extension(Stream stream)
    {
        public int ReadAtLeast(
            Span<byte> buffer,
            int minimumBytes,
            bool throwOnEndOfStream = true)
        {
            if ((uint)minimumBytes > (uint)buffer.Length)
                throw new ArgumentOutOfRangeException(nameof(minimumBytes));

            int totalRead = 0;
            byte[] temp = new byte[Math.Min(4096, minimumBytes)];

            while (totalRead < minimumBytes)
            {
                int read = stream.Read(temp, 0, Math.Min(temp.Length, minimumBytes - totalRead));

                if (read == 0)
                {
                    if (throwOnEndOfStream)
                        throw new EndOfStreamException();

                    break;
                }

                temp.AsSpan(0, read).CopyTo(buffer.Slice(totalRead));
                totalRead += read;
            }

            return totalRead;
        }
    }
}
#endif