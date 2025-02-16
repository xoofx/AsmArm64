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
public class Arm64InstructionFactoryTests_AUTIZB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AUTIZB"/>.
    /// </summary>
    [TestMethod]
    public void Test_AUTIZB_64z_dp_1src_0()
    {
        TestInst(AUTIZB(X0), asm => asm.AUTIZB(X0), Arm64InstructionId.AUTIZB_64z_dp_1src, Arm64Mnemonic.AUTIZB, "AUTIZB X0");
        TestInst(AUTIZB(X15), asm => asm.AUTIZB(X15), Arm64InstructionId.AUTIZB_64z_dp_1src, Arm64Mnemonic.AUTIZB, "AUTIZB X15");
        TestInst(AUTIZB(XZR), asm => asm.AUTIZB(XZR), Arm64InstructionId.AUTIZB_64z_dp_1src, Arm64Mnemonic.AUTIZB, "AUTIZB XZR");
    }
}
