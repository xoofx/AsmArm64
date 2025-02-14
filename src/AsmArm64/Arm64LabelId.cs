// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly record struct Arm64LabelId
{
    internal Arm64LabelId(int index)
    {
        Index = index;
    }
    
    public int Index { get; }
}