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

/// <summary>
/// A list of all ARM64 instruction classes.
/// </summary>
public enum Arm64InstructionClass
{
    /// <summary>
    /// The instruction class is invalid / unknown.
    /// </summary>
    Invalid,
    /// <summary>
    /// Class Advsimd.
    /// </summary>
    Advsimd,
    /// <summary>
    /// Class Float.
    /// </summary>
    Float,
    /// <summary>
    /// Class Fpsimd.
    /// </summary>
    Fpsimd,
    /// <summary>
    /// Class General.
    /// </summary>
    General,
    /// <summary>
    /// Class Mortlach.
    /// </summary>
    Mortlach,
    /// <summary>
    /// Class Mortlach2.
    /// </summary>
    Mortlach2,
    /// <summary>
    /// Class Other.
    /// </summary>
    Other,
    /// <summary>
    /// Class Sve.
    /// </summary>
    Sve,
    /// <summary>
    /// Class Sve2.
    /// </summary>
    Sve2,
    /// <summary>
    /// Class System.
    /// </summary>
    System,
}
