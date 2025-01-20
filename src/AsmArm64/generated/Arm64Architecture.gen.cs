// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.
// ------------------------------------------------------------------------------
// This code was generated by AsmArm64.CodeGen.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// ------------------------------------------------------------------------------
// ReSharper disable All
// ------------------------------------------------------------------------------

namespace AsmArm64;

partial class Arm64Architecture
{
    /// <summary>
    /// Architecture ARMv8_0_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_0_A = new(Arm64ArchitectureId.ARMv8_0_A, 8, 0, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_0_R.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_0_R = new(Arm64ArchitectureId.ARMv8_0_R, 8, 0, Arm64ArchitectureProfile.R);
    /// <summary>
    /// Architecture ARMv8_1_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_1_A = new(Arm64ArchitectureId.ARMv8_1_A, 8, 1, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_2_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_2_A = new(Arm64ArchitectureId.ARMv8_2_A, 8, 2, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_3_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_3_A = new(Arm64ArchitectureId.ARMv8_3_A, 8, 3, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_4_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_4_A = new(Arm64ArchitectureId.ARMv8_4_A, 8, 4, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_5_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_5_A = new(Arm64ArchitectureId.ARMv8_5_A, 8, 5, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_6_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_6_A = new(Arm64ArchitectureId.ARMv8_6_A, 8, 6, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_7_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_7_A = new(Arm64ArchitectureId.ARMv8_7_A, 8, 7, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_8_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_8_A = new(Arm64ArchitectureId.ARMv8_8_A, 8, 8, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv8_9_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv8_9_A = new(Arm64ArchitectureId.ARMv8_9_A, 8, 9, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv9_0_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv9_0_A = new(Arm64ArchitectureId.ARMv9_0_A, 9, 0, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv9_2_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv9_2_A = new(Arm64ArchitectureId.ARMv9_2_A, 9, 2, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv9_4_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv9_4_A = new(Arm64ArchitectureId.ARMv9_4_A, 9, 4, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv9_5_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv9_5_A = new(Arm64ArchitectureId.ARMv9_5_A, 9, 5, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Architecture ARMv9_6_A.
    /// </summary>
    public static readonly Arm64Architecture ARMv9_6_A = new(Arm64ArchitectureId.ARMv9_6_A, 9, 6, Arm64ArchitectureProfile.A);
    /// <summary>
    /// Converts an architecture id to an architecture.
    /// </summary>
    /// <param name="id">The id of the architecture.</param>
    /// <returns>The architecture.</returns>
    public static Arm64Architecture FromId(Arm64ArchitectureId id)
    {
        return id switch
        {
            Arm64ArchitectureId.ARMv8_0_A => ARMv8_0_A,
            Arm64ArchitectureId.ARMv8_0_R => ARMv8_0_R,
            Arm64ArchitectureId.ARMv8_1_A => ARMv8_1_A,
            Arm64ArchitectureId.ARMv8_2_A => ARMv8_2_A,
            Arm64ArchitectureId.ARMv8_3_A => ARMv8_3_A,
            Arm64ArchitectureId.ARMv8_4_A => ARMv8_4_A,
            Arm64ArchitectureId.ARMv8_5_A => ARMv8_5_A,
            Arm64ArchitectureId.ARMv8_6_A => ARMv8_6_A,
            Arm64ArchitectureId.ARMv8_7_A => ARMv8_7_A,
            Arm64ArchitectureId.ARMv8_8_A => ARMv8_8_A,
            Arm64ArchitectureId.ARMv8_9_A => ARMv8_9_A,
            Arm64ArchitectureId.ARMv9_0_A => ARMv9_0_A,
            Arm64ArchitectureId.ARMv9_2_A => ARMv9_2_A,
            Arm64ArchitectureId.ARMv9_4_A => ARMv9_4_A,
            Arm64ArchitectureId.ARMv9_5_A => ARMv9_5_A,
            Arm64ArchitectureId.ARMv9_6_A => ARMv9_6_A,
            _ => new(id, 0, 0, Arm64ArchitectureProfile.Invalid),
        };
    }
}
