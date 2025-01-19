// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Numerics;
using System.Runtime.InteropServices;

namespace AsmArm64.Tests;

[TestClass]
public partial class McInstructionTests
{
    private static void VerifyAsm(byte[] code, string expectedAsm)
    {
        var rawValue = BitConverter.ToUInt32(code);
        var instruction = Arm64Instruction.Decode(rawValue);
        Assert.AreNotEqual(Arm64InstructionId.Invalid, instruction.Id, "Unable to decode instruction");

        var instructionToString = instruction.ToString();
        Assert.AreEqual(expectedAsm, instructionToString, "asm not matching");
    }
}