// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming
namespace AsmArm64;

/// <summary>
/// Represents the state fields for an ARM64 process.
/// </summary>
public enum Arm64ProcessStateField : byte
{
    /// <summary>
    /// All interrupts.
    /// </summary>
    ALLINT = 0,

    /// <summary>
    /// Performance Monitor.
    /// </summary>
    PM = 1,

    /// <summary>
    /// SVCR, Streaming Vector Control Register, Enables SME ZA storage. Enables Streaming SVE mode.
    /// </summary>
    SVCRSM = 2,

    /// <summary>
    /// SVCR, Streaming Vector Control Register, Enables SME ZA storage. If FEAT_SME2 is implemented, also enables SME2 ZT0 storage.
    /// </summary>
    SVCRZA = 3,

    /// <summary>
    /// SVCR, Streaming Vector Control Register.
    /// </summary>
    SVCRSMZA = 4,

    /// <summary>
    /// User Access Override.
    /// </summary>
    UAO = 5,

    /// <summary>
    /// Privileged Access Never.
    /// </summary>
    PAN = 6,

    /// <summary>
    /// Stack Pointer Select.
    /// </summary>
    SPSel = 7,

    /// <summary>
    /// Speculative Store Bypass Safe.
    /// </summary>
    SSBS = 8,

    /// <summary>
    /// Data Independent Timing.
    /// </summary>
    DIT = 9,

    /// <summary>
    /// Tag Check Override.
    /// </summary>
    TCO = 10,

    /// <summary>
    /// Disable Interrupts and Faults Set.
    /// </summary>
    DAIFSet = 11,

    /// <summary>
    /// Disable Interrupts and Faults Clear.
    /// </summary>
    DAIFClr = 12,

    /// <summary>
    /// Undefined state.
    /// </summary>
    Undefined = 0xFF,
}

partial class Arm64Factory
{
    /// <summary>
    /// See <see cref="Arm64ProcessStateField.ALLINT"/>
    /// </summary>
    public static Arm64ProcessStateField ALLINT => Arm64ProcessStateField.ALLINT;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.PM"/>
    /// </summary>
    public static Arm64ProcessStateField PM => Arm64ProcessStateField.PM;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.SVCRSM"/>
    /// </summary>
    public static Arm64ProcessStateField SVCRSM => Arm64ProcessStateField.SVCRSM;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.SVCRZA"/>
    /// </summary>
    public static Arm64ProcessStateField SVCRZA => Arm64ProcessStateField.SVCRZA;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.SVCRSMZA"/>
    /// </summary>
    public static Arm64ProcessStateField SVCRSMZA => Arm64ProcessStateField.SVCRSMZA;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.UAO"/>
    /// </summary>
    public static Arm64ProcessStateField UAO => Arm64ProcessStateField.UAO;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.PAN"/>
    /// </summary>
    public static Arm64ProcessStateField PAN => Arm64ProcessStateField.PAN;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.SPSel"/>
    /// </summary>
    public static Arm64ProcessStateField SPSel => Arm64ProcessStateField.SPSel;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.SSBS"/>
    /// </summary>
    public static Arm64ProcessStateField SSBS => Arm64ProcessStateField.SSBS;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.DIT"/>
    /// </summary>
    public static Arm64ProcessStateField DIT => Arm64ProcessStateField.DIT;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.TCO"/>
    /// </summary>
    public static Arm64ProcessStateField TCO => Arm64ProcessStateField.TCO;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.DAIFSet"/>
    /// </summary>
    public static Arm64ProcessStateField DAIFSet => Arm64ProcessStateField.DAIFSet;

    /// <summary>
    /// See <see cref="Arm64ProcessStateField.DAIFClr"/>
    /// </summary>
    public static Arm64ProcessStateField DAIFClr => Arm64ProcessStateField.DAIFClr;
}
