// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace AsmArm64;

public enum Arm64ProcessStateField : byte
{
    ALLINT = 0,
    PM = 1,
    SVCRSM = 2,
    SVCRZA = 3,
    SVCRSMZA = 4,
    UAO = 5,
    PAN = 6,
    SPSel = 7,
    SSBS = 8,
    DIT = 9,
    TCO = 10,
    DAIFSet= 11,
    DAIFClr = 12,
    Undefined = 0xFF,
}