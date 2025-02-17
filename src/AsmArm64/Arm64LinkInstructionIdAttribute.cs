// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Attribute to link a method to an ARM64 instruction id.
/// </summary>
/// <param name="instructionId"></param>
[AttributeUsage(AttributeTargets.Method)]
public class Arm64LinkInstructionIdAttribute(Arm64InstructionId instructionId) : Attribute
{
    /// <summary>
    /// Gets the instruction id.
    /// </summary>
    public Arm64InstructionId InstructionId { get; } = instructionId;
}
