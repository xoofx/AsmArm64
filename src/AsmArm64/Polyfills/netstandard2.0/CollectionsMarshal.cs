// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System.Runtime.InteropServices;

internal static class CollectionsMarshal
{
    extension<T>(List<T> list)
    {
        public void SetCount(int count)
        {
            if (count < list.Count)
            {
                list.RemoveRange(count, list.Count - count);
                return;
            }

            if (count > list.Count)
            {
                list.Capacity = Math.Max(list.Capacity, count);

                while (list.Count < count)
                {
                    list.Add(default!);
                }
            }
        }
    }
}
#endif