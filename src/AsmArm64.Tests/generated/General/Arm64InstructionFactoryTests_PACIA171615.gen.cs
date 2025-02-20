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
public class Arm64InstructionFactoryTests_PACIA171615_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACIA171615"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACIA171615_64lr_dp_1src_0()
    {
        TestInst(PACIA171615(), asm => asm.PACIA171615(), Arm64InstructionId.PACIA171615_64lr_dp_1src, Arm64Mnemonic.PACIA171615, "PACIA171615");
    }
}
