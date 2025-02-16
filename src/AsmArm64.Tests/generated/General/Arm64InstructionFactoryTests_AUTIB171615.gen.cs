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
public class Arm64InstructionFactoryTests_AUTIB171615_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.AUTIB171615"/>.
    /// </summary>
    [TestMethod]
    public void Test_AUTIB171615_64lr_dp_1src_0()
    {
        TestInst(AUTIB171615(), asm => asm.AUTIB171615(), Arm64InstructionId.AUTIB171615_64lr_dp_1src, Arm64Mnemonic.AUTIB171615, "AUTIB171615");
    }
}
