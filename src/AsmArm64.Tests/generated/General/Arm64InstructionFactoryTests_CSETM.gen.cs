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
public class Arm64InstructionFactoryTests_CSETM_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CSETM"/>.
    /// </summary>
    [TestMethod]
    public void Test_CSETM_csinv_32_condsel_0()
    {
        TestInst(CSETM(W0, NE), asm => asm.CSETM(W0, NE), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM W0, NE");
        TestInst(CSETM(W15, NE), asm => asm.CSETM(W15, NE), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM W15, NE");
        TestInst(CSETM(WZR, NE), asm => asm.CSETM(WZR, NE), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM WZR, NE");
        TestInst(CSETM(W0, HS), asm => asm.CSETM(W0, HS), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM W0, HS");
        TestInst(CSETM(W15, HS), asm => asm.CSETM(W15, HS), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM W15, HS");
        TestInst(CSETM(WZR, HS), asm => asm.CSETM(WZR, HS), Arm64InstructionId.CSETM_csinv_32_condsel, Arm64Mnemonic.CSETM, "CSETM WZR, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CSETM"/>.
    /// </summary>
    [TestMethod]
    public void Test_CSETM_csinv_64_condsel_1()
    {
        TestInst(CSETM(X0, NE), asm => asm.CSETM(X0, NE), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM X0, NE");
        TestInst(CSETM(X15, NE), asm => asm.CSETM(X15, NE), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM X15, NE");
        TestInst(CSETM(XZR, NE), asm => asm.CSETM(XZR, NE), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM XZR, NE");
        TestInst(CSETM(X0, HS), asm => asm.CSETM(X0, HS), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM X0, HS");
        TestInst(CSETM(X15, HS), asm => asm.CSETM(X15, HS), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM X15, HS");
        TestInst(CSETM(XZR, HS), asm => asm.CSETM(XZR, HS), Arm64InstructionId.CSETM_csinv_64_condsel, Arm64Mnemonic.CSETM, "CSETM XZR, HS");
    }
}
