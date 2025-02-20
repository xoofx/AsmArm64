// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.CodeGen;

enum TrieTableKind : byte
{
    Hash = 0,
    SmallArray = 1,
    Terminal = 2,
    SmallArrayWithNotBitMask = 3,
}