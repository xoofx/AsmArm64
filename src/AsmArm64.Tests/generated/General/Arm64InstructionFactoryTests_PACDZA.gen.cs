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
public class Arm64InstructionFactoryTests_PACDZA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.PACDZA"/>.
    /// </summary>
    [TestMethod]
    public void Test_PACDZA_64z_dp_1src_0()
    {
        TestInst(PACDZA(X0), asm => asm.PACDZA(X0), Arm64InstructionId.PACDZA_64z_dp_1src, Arm64Mnemonic.PACDZA, "PACDZA X0");
        TestInst(PACDZA(X15), asm => asm.PACDZA(X15), Arm64InstructionId.PACDZA_64z_dp_1src, Arm64Mnemonic.PACDZA, "PACDZA X15");
        TestInst(PACDZA(XZR), asm => asm.PACDZA(XZR), Arm64InstructionId.PACDZA_64z_dp_1src, Arm64Mnemonic.PACDZA, "PACDZA XZR");
    }
}
