// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents the ARM64 condition codes used for conditional instructions.
/// </summary>
public enum Arm64ConditionalKind : byte
{
    /// <summary>
    /// Equal (Z == 1).
    /// </summary>
    EQ = 0,

    /// <summary>
    /// Not equal (Z == 0).
    /// </summary>
    NE = 1,

    /// <summary>
    /// Carry set/unsigned higher or same (C == 1).
    /// </summary>
    HS = 2, // CS or HS?

    /// <summary>
    /// Carry clear/unsigned lower (C == 0).
    /// </summary>
    LO = 3, // CC or LO?

    /// <summary>
    /// Minus/negative (N == 1).
    /// </summary>
    MI = 4,

    /// <summary>
    /// Plus/positive or zero (N == 0).
    /// </summary>
    PL = 5,

    /// <summary>
    /// Overflow (V == 1).
    /// </summary>
    VS = 6,

    /// <summary>
    /// No overflow (V == 0).
    /// </summary>
    VC = 7,

    /// <summary>
    /// Unsigned higher (C == 1 and Z == 0).
    /// </summary>
    HI = 8,

    /// <summary>
    /// Unsigned lower or same (C == 0 or Z == 1).
    /// </summary>
    LS = 9,

    /// <summary>
    /// Signed greater than or equal (N == V).
    /// </summary>
    GE = 10,

    /// <summary>
    /// Signed less than (N != V).
    /// </summary>
    LT = 11,

    /// <summary>
    /// Signed greater than (Z == 0 and N == V).
    /// </summary>
    GT = 12,

    /// <summary>
    /// Signed less than or equal (Z == 1 or N != V).
    /// </summary>
    LE = 13,

    /// <summary>
    /// Always (unconditional execution).
    /// </summary>
    AL = 14,

    /// <summary>
    /// Never (this condition is deprecated or not used).
    /// </summary>
    NV = 15,

    /// <summary>
    /// Undefined
    /// </summary>
    Undefined = 0xFF,
}

partial class Arm64Factory
{
    public static Arm64ConditionalKind EQ => Arm64ConditionalKind.EQ;
    public static Arm64ConditionalKind NE => Arm64ConditionalKind.NE;
    public static Arm64ConditionalKind HS => Arm64ConditionalKind.HS;
    public static Arm64ConditionalKind LO => Arm64ConditionalKind.LO;
    public static Arm64ConditionalKind MI => Arm64ConditionalKind.MI;
    public static Arm64ConditionalKind PL => Arm64ConditionalKind.PL;
    public static Arm64ConditionalKind VS => Arm64ConditionalKind.VS;
    public static Arm64ConditionalKind VC => Arm64ConditionalKind.VC;
    public static Arm64ConditionalKind HI => Arm64ConditionalKind.HI;
    public static Arm64ConditionalKind LS => Arm64ConditionalKind.LS;
    public static Arm64ConditionalKind GE => Arm64ConditionalKind.GE;
    public static Arm64ConditionalKind LT => Arm64ConditionalKind.LT;
    public static Arm64ConditionalKind GT => Arm64ConditionalKind.GT;
    public static Arm64ConditionalKind LE => Arm64ConditionalKind.LE;
    public static Arm64ConditionalKind AL => Arm64ConditionalKind.AL;
}

partial class Arm64Extensions
{
    public static Arm64ConditionalKind Invert(this Arm64ConditionalKind kind)
    {
        return kind switch
        {
            Arm64ConditionalKind.EQ => Arm64ConditionalKind.NE,
            Arm64ConditionalKind.NE => Arm64ConditionalKind.EQ,
            Arm64ConditionalKind.HS => Arm64ConditionalKind.LO,
            Arm64ConditionalKind.LO => Arm64ConditionalKind.HS,
            Arm64ConditionalKind.MI => Arm64ConditionalKind.PL,
            Arm64ConditionalKind.PL => Arm64ConditionalKind.MI,
            Arm64ConditionalKind.VS => Arm64ConditionalKind.VC,
            Arm64ConditionalKind.VC => Arm64ConditionalKind.VS,
            Arm64ConditionalKind.HI => Arm64ConditionalKind.LS,
            Arm64ConditionalKind.LS => Arm64ConditionalKind.HI,
            Arm64ConditionalKind.GE => Arm64ConditionalKind.LT,
            Arm64ConditionalKind.LT => Arm64ConditionalKind.GE,
            Arm64ConditionalKind.GT => Arm64ConditionalKind.LE,
            Arm64ConditionalKind.LE => Arm64ConditionalKind.GT,
            Arm64ConditionalKind.AL => Arm64ConditionalKind.NV,
            Arm64ConditionalKind.NV => Arm64ConditionalKind.AL,
            _ => Arm64ConditionalKind.Undefined,
        };
    }
}
