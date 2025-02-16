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

using System.Runtime.CompilerServices;
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_RETABSPPCR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RETABSPPCR"/>.
    /// </summary>
    [TestMethod]
    public void Test_RETABSPPCR_64m_branch_reg_0()
    {
        TestInst(RETABSPPCR(X0), Arm64InstructionId.RETABSPPCR_64m_branch_reg, Arm64Mnemonic.RETABSPPCR, "RETABSPPCR X0");
        TestInst(RETABSPPCR(X15), Arm64InstructionId.RETABSPPCR_64m_branch_reg, Arm64Mnemonic.RETABSPPCR, "RETABSPPCR X15");
    }
}
