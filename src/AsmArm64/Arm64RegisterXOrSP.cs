// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly struct Arm64RegisterXOrSP
{
    public int Index { get; }
}

public readonly struct Arm64RegisterXOrW
{
    public int Index { get; }
}

public readonly struct Arm64RegisterWOrWSP
{
    public int Index { get; }
}