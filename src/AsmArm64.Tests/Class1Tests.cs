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
    public void DecodeArm64Simple()
    {
        // add x12, x7, x1
        var rawInstruction = 0x8B0100EC;
        var instruction = Arm64Instruction.Decode(rawInstruction);
        Assert.AreEqual(Arm64Mnemonic.ADD, instruction.Mnemonic);

        // add x12, x7, x1, LSL 30
        Print(0x8B0178ECU);

        // 80 00 80 92 -> mov x0, #-5
        Print(0x92800080U);

        // 41 00 80 D2 -> mov x1, #2
        Print(0xD2800041U);

        // 22 40 C0 3C -> LDR Q2, [x1, #4]
        Print(0x3CC04022U);

        // 22 C8 64 F8 -> ldr x2, [x1, w4, sxtw]
        Print(0xF864C822U);

        // 20 78 62 F8 -> ldr x0, [x1, x2, lsl #3]
        Print(0xF8627820U);

        // e0 6b 61 f8 -> ldr x0, [sp, x1]
        Print(0xF8616BE0U);

        // E0 5B 61 F8 -> ldr x0, [sp, w1, uxtw #3]
        Print(0xF8615BE0U);

        // 20 0C 02 8B -> add x0, x1, x2, lsl #3
        Print(0x8B020C20U);

        // 41 70 23 8B -> add x1, x2, x3, uxtx #4
        Print(0x8B237041U);

        // 20 EC 22 8B    add x0, x1, x2, sxtx #3
        Print(0x8B22EC20U);

        // 20 B0 A2 0D    st4 {v0.s, v1.s, v2.s, v3.s}[1], [x1], x2
        Print(0x0DA2B020);

        // 02 00 00 94 -> bl #8
        Print(0x94000002U);

        // 00 00 00 94 -> bl #0
        Print(0x94000000U);

        // e5 59 0f d5 -> sys #7, c5, c9, #7, {x5}
        Print(0xD50F59E5U);

        // [0x21,0x70,0xdf,0x4c]
        Print(0x4CDF7021U);
    }

    static Arm64Instruction Print(uint rawValue)
    {
        var instruction = Arm64Instruction.Decode(rawValue);
        Console.WriteLine($"{string.Join(" ", BitConverter.GetBytes(rawValue).Select(x => x.ToString("X2")))} -> {instruction}");
        return instruction;
    }
}
