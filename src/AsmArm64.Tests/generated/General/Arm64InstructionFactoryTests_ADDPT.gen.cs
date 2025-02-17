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
public class Arm64InstructionFactoryTests_ADDPT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADDPT"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADDPT_64_addsub_pt_0()
    {
        TestInst(ADDPT(X1, X2, X2, _LSL, 0), asm => asm.ADDPT(X1, X2, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X2, X2");
        TestInst(ADDPT(X17, X2, X2, _LSL, 0), asm => asm.ADDPT(X17, X2, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X2, X2");
        TestInst(ADDPT(SP, X2, X2, _LSL, 0), asm => asm.ADDPT(SP, X2, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X2, X2");
        TestInst(ADDPT(X1, X18, X2, _LSL, 0), asm => asm.ADDPT(X1, X18, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X18, X2");
        TestInst(ADDPT(X17, X18, X2, _LSL, 0), asm => asm.ADDPT(X17, X18, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X18, X2");
        TestInst(ADDPT(SP, X18, X2, _LSL, 0), asm => asm.ADDPT(SP, X18, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X18, X2");
        TestInst(ADDPT(X1, SP, X2, _LSL, 0), asm => asm.ADDPT(X1, SP, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, SP, X2");
        TestInst(ADDPT(X17, SP, X2, _LSL, 0), asm => asm.ADDPT(X17, SP, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, SP, X2");
        TestInst(ADDPT(SP, SP, X2, _LSL, 0), asm => asm.ADDPT(SP, SP, X2, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, SP, X2");
        TestInst(ADDPT(X1, X2, X17, _LSL, 0), asm => asm.ADDPT(X1, X2, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X2, X17");
        TestInst(ADDPT(X17, X2, X17, _LSL, 0), asm => asm.ADDPT(X17, X2, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X2, X17");
        TestInst(ADDPT(SP, X2, X17, _LSL, 0), asm => asm.ADDPT(SP, X2, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X2, X17");
        TestInst(ADDPT(X1, X18, X17, _LSL, 0), asm => asm.ADDPT(X1, X18, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X18, X17");
        TestInst(ADDPT(X17, X18, X17, _LSL, 0), asm => asm.ADDPT(X17, X18, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X18, X17");
        TestInst(ADDPT(SP, X18, X17, _LSL, 0), asm => asm.ADDPT(SP, X18, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X18, X17");
        TestInst(ADDPT(X1, SP, X17, _LSL, 0), asm => asm.ADDPT(X1, SP, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, SP, X17");
        TestInst(ADDPT(X17, SP, X17, _LSL, 0), asm => asm.ADDPT(X17, SP, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, SP, X17");
        TestInst(ADDPT(SP, SP, X17, _LSL, 0), asm => asm.ADDPT(SP, SP, X17, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, SP, X17");
        TestInst(ADDPT(X1, X2, XZR, _LSL, 0), asm => asm.ADDPT(X1, X2, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X2, XZR");
        TestInst(ADDPT(X17, X2, XZR, _LSL, 0), asm => asm.ADDPT(X17, X2, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X2, XZR");
        TestInst(ADDPT(SP, X2, XZR, _LSL, 0), asm => asm.ADDPT(SP, X2, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X2, XZR");
        TestInst(ADDPT(X1, X18, XZR, _LSL, 0), asm => asm.ADDPT(X1, X18, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, X18, XZR");
        TestInst(ADDPT(X17, X18, XZR, _LSL, 0), asm => asm.ADDPT(X17, X18, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, X18, XZR");
        TestInst(ADDPT(SP, X18, XZR, _LSL, 0), asm => asm.ADDPT(SP, X18, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, X18, XZR");
        TestInst(ADDPT(X1, SP, XZR, _LSL, 0), asm => asm.ADDPT(X1, SP, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X1, SP, XZR");
        TestInst(ADDPT(X17, SP, XZR, _LSL, 0), asm => asm.ADDPT(X17, SP, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT X17, SP, XZR");
        TestInst(ADDPT(SP, SP, XZR, _LSL, 0), asm => asm.ADDPT(SP, SP, XZR, _LSL, 0), Arm64InstructionId.ADDPT_64_addsub_pt, Arm64Mnemonic.ADDPT, "ADDPT SP, SP, XZR");
    }
}
