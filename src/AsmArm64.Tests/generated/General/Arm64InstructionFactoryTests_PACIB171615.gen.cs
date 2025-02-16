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
public class Arm64InstructionFactoryTests_PACIB171615_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIB171615"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIB171615_64lr_dp_1src_0()
    {
        TestInst(PACIB171615(), asm => asm.PACIB171615(), Arm64InstructionId.PACIB171615_64lr_dp_1src, Arm64Mnemonic.PACIB171615, "PACIB171615");
    }
}
