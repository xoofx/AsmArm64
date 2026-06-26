// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
namespace System.Collections.Generic;

internal static class DictionaryExtensions
{
    extension<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
    {
        public bool TryAdd(TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
                return false;

            dictionary.Add(key, value);
            return true;
        }
    }
}
#endif