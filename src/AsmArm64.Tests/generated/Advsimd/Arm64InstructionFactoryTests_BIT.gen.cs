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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_BIT_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BIT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BIT_asimdsame_only_0()
    {
        TestInst(BIT(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.BIT(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.8B, V1.8B, V2.8B");
        TestInst(BIT(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.BIT(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.8B, V1.8B, V2.8B");
        TestInst(BIT(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.BIT(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.8B, V31.8B, V2.8B");
        TestInst(BIT(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.BIT(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.8B, V31.8B, V2.8B");
        TestInst(BIT(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.BIT(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.8B, V1.8B, V0.8B");
        TestInst(BIT(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.BIT(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.8B, V1.8B, V0.8B");
        TestInst(BIT(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.BIT(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.8B, V31.8B, V0.8B");
        TestInst(BIT(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.BIT(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BIT"/>.
    /// </summary>
    [TestMethod]
    public void Test_BIT_asimdsame_only_1()
    {
        TestInst(BIT(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.BIT(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.16B, V1.16B, V2.16B");
        TestInst(BIT(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.BIT(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.16B, V1.16B, V2.16B");
        TestInst(BIT(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.BIT(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.16B, V31.16B, V2.16B");
        TestInst(BIT(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.BIT(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.16B, V31.16B, V2.16B");
        TestInst(BIT(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.BIT(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.16B, V1.16B, V0.16B");
        TestInst(BIT(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.BIT(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.16B, V1.16B, V0.16B");
        TestInst(BIT(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.BIT(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V0.16B, V31.16B, V0.16B");
        TestInst(BIT(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.BIT(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.BIT_asimdsame_only, Arm64Mnemonic.BIT, "BIT V30.16B, V31.16B, V0.16B");
    }
}
