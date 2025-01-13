// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64.Tests;

using static Arm64Factory;

[TestClass]
public class Class1Test
{
    [TestMethod]
    public void TestSimple()
    {
        var x0 = X0;
        var x1 = X1;
        var sp = SP;
        var xzr = XZR;

        Console.WriteLine($"x0={x0}");
        Console.WriteLine($"x1={x1}");
        Console.WriteLine($"sp={sp}");
        Console.WriteLine($"xzr={xzr}");
    }

    [TestMethod]
    public void TryDecodeAdd()
    {
        // add x12, x7, x1
        var rawInstruction = 0x8B0100EC;
        var instruction = Arm64Instruction.Decode(rawInstruction);
        Assert.AreEqual(Arm64Mnemonic.ADD, instruction.Mnemonic);

        // add x12, x7, x1, LSL 30
        var rawInstruction2 = 0x8B0178EC;
        var instruction2 = Arm64Instruction.Decode(rawInstruction2);
        Assert.AreEqual(Arm64Mnemonic.ADD, instruction2.Mnemonic);
        
        Console.Write(Arm64Mnemonic.ADD.ToText());

        for(int i = 0; i < instruction2.OperandCount; i++)
        {
            Console.Write(i == 0 ? " " : ", ");

            var operand = instruction2.GetOperand(i);
            switch (operand.Kind)
            {
                case Arm64OperandKind.Register:
                    var register = (Arm64RegisterOperand) operand;
                    Console.Write(register);
                    break;
                //case Arm64OperandKind.RegisterGroup:
                //    break;
                //case Arm64OperandKind.Memory:
                //    break;
                //case Arm64OperandKind.Immediate:
                //    break;
                //case Arm64OperandKind.ImmediateByteValues:
                //    break;
                //case Arm64OperandKind.FixedImmediate:
                //    break;
                //case Arm64OperandKind.Label:
                //    break;
                case Arm64OperandKind.Shift:
                    var shift = (Arm64ShiftOperand)operand;
                    Console.Write(shift);
                    break;
                //case Arm64OperandKind.Extend:
                //    break;
                //case Arm64OperandKind.Enum:
                //    break;
                //case Arm64OperandKind.PStateField:
                //    break;
                //case Arm64OperandKind.Const:
                //    break;
                default:
                    Console.Write(operand.Kind);
                    break;
            }
        }
    }
}
