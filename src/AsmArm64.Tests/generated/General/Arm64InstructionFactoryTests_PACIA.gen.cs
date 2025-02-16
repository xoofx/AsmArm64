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
public class Arm64InstructionFactoryTests_PACIA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIA"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIA_64p_dp_1src_0()
    {
        TestInst(PACIA(X0, X2), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X0, X2");
        TestInst(PACIA(X15, X2), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X15, X2");
        TestInst(PACIA(XZR, X2), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA XZR, X2");
        TestInst(PACIA(X0, X18), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X0, X18");
        TestInst(PACIA(X15, X18), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X15, X18");
        TestInst(PACIA(XZR, X18), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA XZR, X18");
        TestInst(PACIA(X0, SP), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X0, SP");
        TestInst(PACIA(X15, SP), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA X15, SP");
        TestInst(PACIA(XZR, SP), Arm64InstructionId.PACIA_64p_dp_1src, Arm64Mnemonic.PACIA, "PACIA XZR, SP");
    }
}
