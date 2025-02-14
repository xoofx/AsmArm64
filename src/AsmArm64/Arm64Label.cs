// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly record struct Arm64Label(ulong Address, string? Name)
{
    public bool IsBound => Address != 0 && Address != ulong.MaxValue;

    public bool IsEmpty => Address == 0 && Name is null;

    public override string ToString()
    {
        return Name ?? $"0x{Address:X16}";
    }
}