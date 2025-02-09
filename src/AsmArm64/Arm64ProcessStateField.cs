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

partial class Arm64Factory
{
    public static Arm64ProcessStateField ALLINT => Arm64ProcessStateField.ALLINT;
    public static Arm64ProcessStateField PM => Arm64ProcessStateField.PM;
    public static Arm64ProcessStateField SVCRSM => Arm64ProcessStateField.SVCRSM;
    public static Arm64ProcessStateField SVCRZA => Arm64ProcessStateField.SVCRZA;
    public static Arm64ProcessStateField SVCRSMZA => Arm64ProcessStateField.SVCRSMZA;
    public static Arm64ProcessStateField UAO => Arm64ProcessStateField.UAO;
    public static Arm64ProcessStateField PAN => Arm64ProcessStateField.PAN;
    public static Arm64ProcessStateField SPSel => Arm64ProcessStateField.SPSel;
    public static Arm64ProcessStateField SSBS => Arm64ProcessStateField.SSBS;
    public static Arm64ProcessStateField DIT => Arm64ProcessStateField.DIT;
    public static Arm64ProcessStateField TCO => Arm64ProcessStateField.TCO;
    public static Arm64ProcessStateField DAIFSet => Arm64ProcessStateField.DAIFSet;
    public static Arm64ProcessStateField DAIFClr => Arm64ProcessStateField.DAIFClr;
}