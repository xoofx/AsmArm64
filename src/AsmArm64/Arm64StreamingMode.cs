// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Streaming SVE mode and SME architectural state.
/// </summary>
public enum Arm64StreamingMode : byte
{
    /// <summary>
    /// Reserved.
    /// </summary>
    Reserved = 0b00,
    
    /// <summary>
    /// Maps to <see cref="Arm64ProcessStateField.SVCRSM"/>
    /// </summary>
    SM = 0b01,

    /// <summary>
    /// Maps to <see cref="Arm64ProcessStateField.SVCRZA"/>
    /// </summary>
    ZA = 0b10,

    /// <summary>
    /// The mode is absent.
    /// </summary>
    Absent = 0b11,
}

partial class Arm64Factory
{
    public static Arm64StreamingMode SM => Arm64StreamingMode.SM;

    public static Arm64StreamingMode ZA => Arm64StreamingMode.ZA;
}