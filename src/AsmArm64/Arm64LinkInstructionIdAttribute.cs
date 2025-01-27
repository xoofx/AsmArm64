// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

[AttributeUsage(AttributeTargets.Method)]
public class Arm64LinkInstructionIdAttribute(Arm64InstructionId instructionId) : Attribute
{
    public Arm64InstructionId InstructionId { get; } = instructionId;
}
