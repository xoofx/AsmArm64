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

using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_B_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.B"/>.
    /// </summary>
    [TestMethod]
    public void Test_B_only_branch_imm_0()
    {
        TestInst(B(32), null, Arm64InstructionId.B_only_branch_imm, Arm64Mnemonic.B, "B #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.B"/>.
    /// </summary>
    [TestMethod]
    public void Test_B_only_condbranch_1()
    {
        TestInst(B(NE, 32), null, Arm64InstructionId.B_only_condbranch, Arm64Mnemonic.B, "B.NE #32");
        TestInst(B(HS, 32), null, Arm64InstructionId.B_only_condbranch, Arm64Mnemonic.B, "B.HS #32");
    }
}
