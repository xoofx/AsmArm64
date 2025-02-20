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
public class Arm64InstructionFactoryTests_SMSUBL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SMSUBL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SMSUBL_64wa_dp_3src_0()
    {
        TestInst(SMSUBL(X0, W1, W2, X3), asm => asm.SMSUBL(X0, W1, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, W2, X3");
        TestInst(SMSUBL(X15, W1, W2, X3), asm => asm.SMSUBL(X15, W1, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, W2, X3");
        TestInst(SMSUBL(XZR, W1, W2, X3), asm => asm.SMSUBL(XZR, W1, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, W2, X3");
        TestInst(SMSUBL(X0, W16, W2, X3), asm => asm.SMSUBL(X0, W16, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, W2, X3");
        TestInst(SMSUBL(X15, W16, W2, X3), asm => asm.SMSUBL(X15, W16, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, W2, X3");
        TestInst(SMSUBL(XZR, W16, W2, X3), asm => asm.SMSUBL(XZR, W16, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, W2, X3");
        TestInst(SMSUBL(X0, WZR, W2, X3), asm => asm.SMSUBL(X0, WZR, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, W2, X3");
        TestInst(SMSUBL(X15, WZR, W2, X3), asm => asm.SMSUBL(X15, WZR, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, W2, X3");
        TestInst(SMSUBL(XZR, WZR, W2, X3), asm => asm.SMSUBL(XZR, WZR, W2, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, W2, X3");
        TestInst(SMSUBL(X0, W1, W17, X3), asm => asm.SMSUBL(X0, W1, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, W17, X3");
        TestInst(SMSUBL(X15, W1, W17, X3), asm => asm.SMSUBL(X15, W1, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, W17, X3");
        TestInst(SMSUBL(XZR, W1, W17, X3), asm => asm.SMSUBL(XZR, W1, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, W17, X3");
        TestInst(SMSUBL(X0, W16, W17, X3), asm => asm.SMSUBL(X0, W16, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, W17, X3");
        TestInst(SMSUBL(X15, W16, W17, X3), asm => asm.SMSUBL(X15, W16, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, W17, X3");
        TestInst(SMSUBL(XZR, W16, W17, X3), asm => asm.SMSUBL(XZR, W16, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, W17, X3");
        TestInst(SMSUBL(X0, WZR, W17, X3), asm => asm.SMSUBL(X0, WZR, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, W17, X3");
        TestInst(SMSUBL(X15, WZR, W17, X3), asm => asm.SMSUBL(X15, WZR, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, W17, X3");
        TestInst(SMSUBL(XZR, WZR, W17, X3), asm => asm.SMSUBL(XZR, WZR, W17, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, W17, X3");
        TestInst(SMSUBL(X0, W1, WZR, X3), asm => asm.SMSUBL(X0, W1, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, WZR, X3");
        TestInst(SMSUBL(X15, W1, WZR, X3), asm => asm.SMSUBL(X15, W1, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, WZR, X3");
        TestInst(SMSUBL(XZR, W1, WZR, X3), asm => asm.SMSUBL(XZR, W1, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, WZR, X3");
        TestInst(SMSUBL(X0, W16, WZR, X3), asm => asm.SMSUBL(X0, W16, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, WZR, X3");
        TestInst(SMSUBL(X15, W16, WZR, X3), asm => asm.SMSUBL(X15, W16, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, WZR, X3");
        TestInst(SMSUBL(XZR, W16, WZR, X3), asm => asm.SMSUBL(XZR, W16, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, WZR, X3");
        TestInst(SMSUBL(X0, WZR, WZR, X3), asm => asm.SMSUBL(X0, WZR, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, WZR, X3");
        TestInst(SMSUBL(X15, WZR, WZR, X3), asm => asm.SMSUBL(X15, WZR, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, WZR, X3");
        TestInst(SMSUBL(XZR, WZR, WZR, X3), asm => asm.SMSUBL(XZR, WZR, WZR, X3), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, WZR, X3");
        TestInst(SMSUBL(X0, W1, W2, X18), asm => asm.SMSUBL(X0, W1, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, W2, X18");
        TestInst(SMSUBL(X15, W1, W2, X18), asm => asm.SMSUBL(X15, W1, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, W2, X18");
        TestInst(SMSUBL(XZR, W1, W2, X18), asm => asm.SMSUBL(XZR, W1, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, W2, X18");
        TestInst(SMSUBL(X0, W16, W2, X18), asm => asm.SMSUBL(X0, W16, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, W2, X18");
        TestInst(SMSUBL(X15, W16, W2, X18), asm => asm.SMSUBL(X15, W16, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, W2, X18");
        TestInst(SMSUBL(XZR, W16, W2, X18), asm => asm.SMSUBL(XZR, W16, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, W2, X18");
        TestInst(SMSUBL(X0, WZR, W2, X18), asm => asm.SMSUBL(X0, WZR, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, W2, X18");
        TestInst(SMSUBL(X15, WZR, W2, X18), asm => asm.SMSUBL(X15, WZR, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, W2, X18");
        TestInst(SMSUBL(XZR, WZR, W2, X18), asm => asm.SMSUBL(XZR, WZR, W2, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, W2, X18");
        TestInst(SMSUBL(X0, W1, W17, X18), asm => asm.SMSUBL(X0, W1, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, W17, X18");
        TestInst(SMSUBL(X15, W1, W17, X18), asm => asm.SMSUBL(X15, W1, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, W17, X18");
        TestInst(SMSUBL(XZR, W1, W17, X18), asm => asm.SMSUBL(XZR, W1, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, W17, X18");
        TestInst(SMSUBL(X0, W16, W17, X18), asm => asm.SMSUBL(X0, W16, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, W17, X18");
        TestInst(SMSUBL(X15, W16, W17, X18), asm => asm.SMSUBL(X15, W16, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, W17, X18");
        TestInst(SMSUBL(XZR, W16, W17, X18), asm => asm.SMSUBL(XZR, W16, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, W17, X18");
        TestInst(SMSUBL(X0, WZR, W17, X18), asm => asm.SMSUBL(X0, WZR, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, W17, X18");
        TestInst(SMSUBL(X15, WZR, W17, X18), asm => asm.SMSUBL(X15, WZR, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, W17, X18");
        TestInst(SMSUBL(XZR, WZR, W17, X18), asm => asm.SMSUBL(XZR, WZR, W17, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, W17, X18");
        TestInst(SMSUBL(X0, W1, WZR, X18), asm => asm.SMSUBL(X0, W1, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W1, WZR, X18");
        TestInst(SMSUBL(X15, W1, WZR, X18), asm => asm.SMSUBL(X15, W1, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W1, WZR, X18");
        TestInst(SMSUBL(XZR, W1, WZR, X18), asm => asm.SMSUBL(XZR, W1, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W1, WZR, X18");
        TestInst(SMSUBL(X0, W16, WZR, X18), asm => asm.SMSUBL(X0, W16, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, W16, WZR, X18");
        TestInst(SMSUBL(X15, W16, WZR, X18), asm => asm.SMSUBL(X15, W16, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, W16, WZR, X18");
        TestInst(SMSUBL(XZR, W16, WZR, X18), asm => asm.SMSUBL(XZR, W16, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, W16, WZR, X18");
        TestInst(SMSUBL(X0, WZR, WZR, X18), asm => asm.SMSUBL(X0, WZR, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X0, WZR, WZR, X18");
        TestInst(SMSUBL(X15, WZR, WZR, X18), asm => asm.SMSUBL(X15, WZR, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL X15, WZR, WZR, X18");
        TestInst(SMSUBL(XZR, WZR, WZR, X18), asm => asm.SMSUBL(XZR, WZR, WZR, X18), Arm64InstructionId.SMSUBL_64wa_dp_3src, Arm64Mnemonic.SMSUBL, "SMSUBL XZR, WZR, WZR, X18");
        TestInst(SMSUBL(X0, W1, W2, XZR), asm => asm.SMSUBL(X0, W1, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W1, W2");
        TestInst(SMSUBL(X15, W1, W2, XZR), asm => asm.SMSUBL(X15, W1, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W1, W2");
        TestInst(SMSUBL(XZR, W1, W2, XZR), asm => asm.SMSUBL(XZR, W1, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W1, W2");
        TestInst(SMSUBL(X0, W16, W2, XZR), asm => asm.SMSUBL(X0, W16, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W16, W2");
        TestInst(SMSUBL(X15, W16, W2, XZR), asm => asm.SMSUBL(X15, W16, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W16, W2");
        TestInst(SMSUBL(XZR, W16, W2, XZR), asm => asm.SMSUBL(XZR, W16, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W16, W2");
        TestInst(SMSUBL(X0, WZR, W2, XZR), asm => asm.SMSUBL(X0, WZR, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, WZR, W2");
        TestInst(SMSUBL(X15, WZR, W2, XZR), asm => asm.SMSUBL(X15, WZR, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, WZR, W2");
        TestInst(SMSUBL(XZR, WZR, W2, XZR), asm => asm.SMSUBL(XZR, WZR, W2, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, WZR, W2");
        TestInst(SMSUBL(X0, W1, W17, XZR), asm => asm.SMSUBL(X0, W1, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W1, W17");
        TestInst(SMSUBL(X15, W1, W17, XZR), asm => asm.SMSUBL(X15, W1, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W1, W17");
        TestInst(SMSUBL(XZR, W1, W17, XZR), asm => asm.SMSUBL(XZR, W1, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W1, W17");
        TestInst(SMSUBL(X0, W16, W17, XZR), asm => asm.SMSUBL(X0, W16, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W16, W17");
        TestInst(SMSUBL(X15, W16, W17, XZR), asm => asm.SMSUBL(X15, W16, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W16, W17");
        TestInst(SMSUBL(XZR, W16, W17, XZR), asm => asm.SMSUBL(XZR, W16, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W16, W17");
        TestInst(SMSUBL(X0, WZR, W17, XZR), asm => asm.SMSUBL(X0, WZR, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, WZR, W17");
        TestInst(SMSUBL(X15, WZR, W17, XZR), asm => asm.SMSUBL(X15, WZR, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, WZR, W17");
        TestInst(SMSUBL(XZR, WZR, W17, XZR), asm => asm.SMSUBL(XZR, WZR, W17, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, WZR, W17");
        TestInst(SMSUBL(X0, W1, WZR, XZR), asm => asm.SMSUBL(X0, W1, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W1, WZR");
        TestInst(SMSUBL(X15, W1, WZR, XZR), asm => asm.SMSUBL(X15, W1, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W1, WZR");
        TestInst(SMSUBL(XZR, W1, WZR, XZR), asm => asm.SMSUBL(XZR, W1, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W1, WZR");
        TestInst(SMSUBL(X0, W16, WZR, XZR), asm => asm.SMSUBL(X0, W16, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, W16, WZR");
        TestInst(SMSUBL(X15, W16, WZR, XZR), asm => asm.SMSUBL(X15, W16, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, W16, WZR");
        TestInst(SMSUBL(XZR, W16, WZR, XZR), asm => asm.SMSUBL(XZR, W16, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, W16, WZR");
        TestInst(SMSUBL(X0, WZR, WZR, XZR), asm => asm.SMSUBL(X0, WZR, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X0, WZR, WZR");
        TestInst(SMSUBL(X15, WZR, WZR, XZR), asm => asm.SMSUBL(X15, WZR, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL X15, WZR, WZR");
        TestInst(SMSUBL(XZR, WZR, WZR, XZR), asm => asm.SMSUBL(XZR, WZR, WZR, XZR), Arm64InstructionId.SMNEGL_smsubl_64wa_dp_3src, Arm64Mnemonic.SMNEGL, "SMNEGL XZR, WZR, WZR");
    }
}
