// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace AsmArm64;

public enum Arm64ProcessStateField : byte
{
    None,
    ALLINT,
    PM,
    SVCRSM,
    SVCRZA,
    SVCRSMZA,
    UAO,
    PAN,
    SPSel,
    SSBS,
    DIT,
    TCO,
    DAIFSet,
    DAIFClr
}