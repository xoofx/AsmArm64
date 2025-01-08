// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming
namespace AsmArm64;

using static Arm64Factory;

public partial class Arm64Assembler
{
    public uint ADD(Arm64RegisterX xd, Arm64RegisterX xn, Arm64RegisterX xm, Arm64ShiftType shift = Arm64ShiftType.LSL, int amount = 0)
    {
        return 0xFF00_0000 | ((uint)shift << 22) | ((uint)amount << 10) | ((uint)xn.Index << 5) | ((uint)xm.Index << 16) | ((uint)xd.Index << 0);
    }

    public uint LDR(Arm64RegisterX xd, ReadOnlySpan<Arm64RegisterX> xs)
    {
        return 0x1F00_0000 | ((uint)xs[0].Index << 5) | ((uint)xd.Index << 0);
    }

    public uint Test()
    {
        return ADD(X0, X1, X2);
    }
    public uint Test2()
    {
        return LDR(X0, [X1]);
    }
}