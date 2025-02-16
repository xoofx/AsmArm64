// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

[TestClass]
public class TestAssembler
{
    [TestMethod]
    public void TestSimple()
    {
        var accessor = new Arm64InstructionBufferByList();
        var asm = new Arm64Assembler(accessor);
        var label = asm.CreateLabelId("Hello");
        asm.B(Arm64ConditionalKind.AL, label);
        asm.BindLabel(label);
        asm.Assemble();

        var instructions = accessor.Instructions;
        Assert.AreEqual(1, instructions.Count);

        var instruction = Arm64Instruction.Decode(instructions[0]);
        Assert.AreEqual(Arm64InstructionId.B_only_condbranch, instruction.Id);
        var operand1 = instruction.GetOperand(0);
        Assert.AreEqual(Arm64OperandKind.Enum, operand1.Kind);
        
        var operand2 = instruction.GetOperand(1);
        Assert.AreEqual(Arm64OperandKind.Label, operand2.Kind);

        var labelOperand2 = (Arm64LabelOperand)operand2;
        Assert.AreEqual(4, labelOperand2.Offset);
    }
}