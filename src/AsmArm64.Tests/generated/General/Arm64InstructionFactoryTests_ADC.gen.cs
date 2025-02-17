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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_ADC_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADC"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADC_32_addsub_carry_0()
    {
        TestInst(ADC(W0, W1, W2), asm => asm.ADC(W0, W1, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W1, W2");
        TestInst(ADC(W15, W1, W2), asm => asm.ADC(W15, W1, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W1, W2");
        TestInst(ADC(WZR, W1, W2), asm => asm.ADC(WZR, W1, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W1, W2");
        TestInst(ADC(W0, W16, W2), asm => asm.ADC(W0, W16, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W16, W2");
        TestInst(ADC(W15, W16, W2), asm => asm.ADC(W15, W16, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W16, W2");
        TestInst(ADC(WZR, W16, W2), asm => asm.ADC(WZR, W16, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W16, W2");
        TestInst(ADC(W0, WZR, W2), asm => asm.ADC(W0, WZR, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, WZR, W2");
        TestInst(ADC(W15, WZR, W2), asm => asm.ADC(W15, WZR, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, WZR, W2");
        TestInst(ADC(WZR, WZR, W2), asm => asm.ADC(WZR, WZR, W2), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, WZR, W2");
        TestInst(ADC(W0, W1, W17), asm => asm.ADC(W0, W1, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W1, W17");
        TestInst(ADC(W15, W1, W17), asm => asm.ADC(W15, W1, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W1, W17");
        TestInst(ADC(WZR, W1, W17), asm => asm.ADC(WZR, W1, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W1, W17");
        TestInst(ADC(W0, W16, W17), asm => asm.ADC(W0, W16, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W16, W17");
        TestInst(ADC(W15, W16, W17), asm => asm.ADC(W15, W16, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W16, W17");
        TestInst(ADC(WZR, W16, W17), asm => asm.ADC(WZR, W16, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W16, W17");
        TestInst(ADC(W0, WZR, W17), asm => asm.ADC(W0, WZR, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, WZR, W17");
        TestInst(ADC(W15, WZR, W17), asm => asm.ADC(W15, WZR, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, WZR, W17");
        TestInst(ADC(WZR, WZR, W17), asm => asm.ADC(WZR, WZR, W17), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, WZR, W17");
        TestInst(ADC(W0, W1, WZR), asm => asm.ADC(W0, W1, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W1, WZR");
        TestInst(ADC(W15, W1, WZR), asm => asm.ADC(W15, W1, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W1, WZR");
        TestInst(ADC(WZR, W1, WZR), asm => asm.ADC(WZR, W1, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W1, WZR");
        TestInst(ADC(W0, W16, WZR), asm => asm.ADC(W0, W16, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, W16, WZR");
        TestInst(ADC(W15, W16, WZR), asm => asm.ADC(W15, W16, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, W16, WZR");
        TestInst(ADC(WZR, W16, WZR), asm => asm.ADC(WZR, W16, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, W16, WZR");
        TestInst(ADC(W0, WZR, WZR), asm => asm.ADC(W0, WZR, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W0, WZR, WZR");
        TestInst(ADC(W15, WZR, WZR), asm => asm.ADC(W15, WZR, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC W15, WZR, WZR");
        TestInst(ADC(WZR, WZR, WZR), asm => asm.ADC(WZR, WZR, WZR), Arm64InstructionId.ADC_32_addsub_carry, Arm64Mnemonic.ADC, "ADC WZR, WZR, WZR");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADC"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADC_64_addsub_carry_1()
    {
        TestInst(ADC(X0, X1, X2), asm => asm.ADC(X0, X1, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X1, X2");
        TestInst(ADC(X15, X1, X2), asm => asm.ADC(X15, X1, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X1, X2");
        TestInst(ADC(XZR, X1, X2), asm => asm.ADC(XZR, X1, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X1, X2");
        TestInst(ADC(X0, X16, X2), asm => asm.ADC(X0, X16, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X16, X2");
        TestInst(ADC(X15, X16, X2), asm => asm.ADC(X15, X16, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X16, X2");
        TestInst(ADC(XZR, X16, X2), asm => asm.ADC(XZR, X16, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X16, X2");
        TestInst(ADC(X0, XZR, X2), asm => asm.ADC(X0, XZR, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, XZR, X2");
        TestInst(ADC(X15, XZR, X2), asm => asm.ADC(X15, XZR, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, XZR, X2");
        TestInst(ADC(XZR, XZR, X2), asm => asm.ADC(XZR, XZR, X2), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, XZR, X2");
        TestInst(ADC(X0, X1, X17), asm => asm.ADC(X0, X1, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X1, X17");
        TestInst(ADC(X15, X1, X17), asm => asm.ADC(X15, X1, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X1, X17");
        TestInst(ADC(XZR, X1, X17), asm => asm.ADC(XZR, X1, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X1, X17");
        TestInst(ADC(X0, X16, X17), asm => asm.ADC(X0, X16, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X16, X17");
        TestInst(ADC(X15, X16, X17), asm => asm.ADC(X15, X16, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X16, X17");
        TestInst(ADC(XZR, X16, X17), asm => asm.ADC(XZR, X16, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X16, X17");
        TestInst(ADC(X0, XZR, X17), asm => asm.ADC(X0, XZR, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, XZR, X17");
        TestInst(ADC(X15, XZR, X17), asm => asm.ADC(X15, XZR, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, XZR, X17");
        TestInst(ADC(XZR, XZR, X17), asm => asm.ADC(XZR, XZR, X17), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, XZR, X17");
        TestInst(ADC(X0, X1, XZR), asm => asm.ADC(X0, X1, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X1, XZR");
        TestInst(ADC(X15, X1, XZR), asm => asm.ADC(X15, X1, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X1, XZR");
        TestInst(ADC(XZR, X1, XZR), asm => asm.ADC(XZR, X1, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X1, XZR");
        TestInst(ADC(X0, X16, XZR), asm => asm.ADC(X0, X16, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, X16, XZR");
        TestInst(ADC(X15, X16, XZR), asm => asm.ADC(X15, X16, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, X16, XZR");
        TestInst(ADC(XZR, X16, XZR), asm => asm.ADC(XZR, X16, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, X16, XZR");
        TestInst(ADC(X0, XZR, XZR), asm => asm.ADC(X0, XZR, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X0, XZR, XZR");
        TestInst(ADC(X15, XZR, XZR), asm => asm.ADC(X15, XZR, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC X15, XZR, XZR");
        TestInst(ADC(XZR, XZR, XZR), asm => asm.ADC(XZR, XZR, XZR), Arm64InstructionId.ADC_64_addsub_carry, Arm64Mnemonic.ADC, "ADC XZR, XZR, XZR");
    }
}
