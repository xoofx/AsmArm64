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
    /// No condition specified.
    /// </summary>
    None,

    /// <summary>
    /// Equal (Z == 1).
    /// </summary>
    EQ = 1,

    /// <summary>
    /// Not equal (Z == 0).
    /// </summary>
    NE = 2,

    /// <summary>
    /// Carry set/unsigned higher or same (C == 1).
    /// </summary>
    CS = 3,

    /// <summary>
    /// Carry clear/unsigned lower (C == 0).
    /// </summary>
    CC = 4,

    /// <summary>
    /// Minus/negative (N == 1).
    /// </summary>
    MI = 5,

    /// <summary>
    /// Plus/positive or zero (N == 0).
    /// </summary>
    PL = 6,

    /// <summary>
    /// Overflow (V == 1).
    /// </summary>
    VS = 7,

    /// <summary>
    /// No overflow (V == 0).
    /// </summary>
    VC = 8,

    /// <summary>
    /// Unsigned higher (C == 1 and Z == 0).
    /// </summary>
    HI = 9,

    /// <summary>
    /// Unsigned lower or same (C == 0 or Z == 1).
    /// </summary>
    LS = 10,

    /// <summary>
    /// Signed greater than or equal (N == V).
    /// </summary>
    GE = 11,

    /// <summary>
    /// Signed less than (N != V).
    /// </summary>
    LT = 12,

    /// <summary>
    /// Signed greater than (Z == 0 and N == V).
    /// </summary>
    GT = 13,

    /// <summary>
    /// Signed less than or equal (Z == 1 or N != V).
    /// </summary>
    LE = 14,

    /// <summary>
    /// Always (unconditional execution).
    /// </summary>
    AL = 15,

    /// <summary>
    /// Never (this condition is deprecated or not used).
    /// </summary>
    NV = 16,
}


partial class Arm64Extensions
{
    public static Arm64ConditionalKind Invert(this Arm64ConditionalKind kind)
    {
        return kind switch
        {
            Arm64ConditionalKind.EQ => Arm64ConditionalKind.NE,
            Arm64ConditionalKind.NE => Arm64ConditionalKind.EQ,
            Arm64ConditionalKind.CS => Arm64ConditionalKind.CC,
            Arm64ConditionalKind.CC => Arm64ConditionalKind.CS,
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
            _ => kind,
        };
    }
}
