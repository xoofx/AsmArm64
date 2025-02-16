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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_SSHL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asisdsame_only_0()
    {
        TestInst(SSHL(D0, D1, D2), asm => asm.SSHL(D0, D1, D2), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D0, D1, D2");
        TestInst(SSHL(D31, D1, D2), asm => asm.SSHL(D31, D1, D2), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D31, D1, D2");
        TestInst(SSHL(D0, D31, D2), asm => asm.SSHL(D0, D31, D2), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D0, D31, D2");
        TestInst(SSHL(D31, D31, D2), asm => asm.SSHL(D31, D31, D2), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D31, D31, D2");
        TestInst(SSHL(D0, D1, D31), asm => asm.SSHL(D0, D1, D31), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D0, D1, D31");
        TestInst(SSHL(D31, D1, D31), asm => asm.SSHL(D31, D1, D31), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D31, D1, D31");
        TestInst(SSHL(D0, D31, D31), asm => asm.SSHL(D0, D31, D31), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D0, D31, D31");
        TestInst(SSHL(D31, D31, D31), asm => asm.SSHL(D31, D31, D31), Arm64InstructionId.SSHL_asisdsame_only, Arm64Mnemonic.SSHL, "SSHL D31, D31, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_1()
    {
        TestInst(SSHL(V0.T_8B, V1.T_8B, V2.T_8B), asm => asm.SSHL(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8B, V1.8B, V2.8B");
        TestInst(SSHL(V30.T_8B, V1.T_8B, V2.T_8B), asm => asm.SSHL(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8B, V1.8B, V2.8B");
        TestInst(SSHL(V0.T_8B, V31.T_8B, V2.T_8B), asm => asm.SSHL(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8B, V31.8B, V2.8B");
        TestInst(SSHL(V30.T_8B, V31.T_8B, V2.T_8B), asm => asm.SSHL(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8B, V31.8B, V2.8B");
        TestInst(SSHL(V0.T_8B, V1.T_8B, V0.T_8B), asm => asm.SSHL(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8B, V1.8B, V0.8B");
        TestInst(SSHL(V30.T_8B, V1.T_8B, V0.T_8B), asm => asm.SSHL(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8B, V1.8B, V0.8B");
        TestInst(SSHL(V0.T_8B, V31.T_8B, V0.T_8B), asm => asm.SSHL(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8B, V31.8B, V0.8B");
        TestInst(SSHL(V30.T_8B, V31.T_8B, V0.T_8B), asm => asm.SSHL(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_2()
    {
        TestInst(SSHL(V0.T_16B, V1.T_16B, V2.T_16B), asm => asm.SSHL(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.16B, V1.16B, V2.16B");
        TestInst(SSHL(V30.T_16B, V1.T_16B, V2.T_16B), asm => asm.SSHL(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.16B, V1.16B, V2.16B");
        TestInst(SSHL(V0.T_16B, V31.T_16B, V2.T_16B), asm => asm.SSHL(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.16B, V31.16B, V2.16B");
        TestInst(SSHL(V30.T_16B, V31.T_16B, V2.T_16B), asm => asm.SSHL(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.16B, V31.16B, V2.16B");
        TestInst(SSHL(V0.T_16B, V1.T_16B, V0.T_16B), asm => asm.SSHL(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.16B, V1.16B, V0.16B");
        TestInst(SSHL(V30.T_16B, V1.T_16B, V0.T_16B), asm => asm.SSHL(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.16B, V1.16B, V0.16B");
        TestInst(SSHL(V0.T_16B, V31.T_16B, V0.T_16B), asm => asm.SSHL(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.16B, V31.16B, V0.16B");
        TestInst(SSHL(V30.T_16B, V31.T_16B, V0.T_16B), asm => asm.SSHL(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.16B, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_3()
    {
        TestInst(SSHL(V0.T_4H, V1.T_4H, V2.T_4H), asm => asm.SSHL(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4H, V1.4H, V2.4H");
        TestInst(SSHL(V30.T_4H, V1.T_4H, V2.T_4H), asm => asm.SSHL(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4H, V1.4H, V2.4H");
        TestInst(SSHL(V0.T_4H, V31.T_4H, V2.T_4H), asm => asm.SSHL(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4H, V31.4H, V2.4H");
        TestInst(SSHL(V30.T_4H, V31.T_4H, V2.T_4H), asm => asm.SSHL(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4H, V31.4H, V2.4H");
        TestInst(SSHL(V0.T_4H, V1.T_4H, V0.T_4H), asm => asm.SSHL(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4H, V1.4H, V0.4H");
        TestInst(SSHL(V30.T_4H, V1.T_4H, V0.T_4H), asm => asm.SSHL(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4H, V1.4H, V0.4H");
        TestInst(SSHL(V0.T_4H, V31.T_4H, V0.T_4H), asm => asm.SSHL(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4H, V31.4H, V0.4H");
        TestInst(SSHL(V30.T_4H, V31.T_4H, V0.T_4H), asm => asm.SSHL(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_4()
    {
        TestInst(SSHL(V0.T_8H, V1.T_8H, V2.T_8H), asm => asm.SSHL(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8H, V1.8H, V2.8H");
        TestInst(SSHL(V30.T_8H, V1.T_8H, V2.T_8H), asm => asm.SSHL(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8H, V1.8H, V2.8H");
        TestInst(SSHL(V0.T_8H, V31.T_8H, V2.T_8H), asm => asm.SSHL(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8H, V31.8H, V2.8H");
        TestInst(SSHL(V30.T_8H, V31.T_8H, V2.T_8H), asm => asm.SSHL(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8H, V31.8H, V2.8H");
        TestInst(SSHL(V0.T_8H, V1.T_8H, V0.T_8H), asm => asm.SSHL(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8H, V1.8H, V0.8H");
        TestInst(SSHL(V30.T_8H, V1.T_8H, V0.T_8H), asm => asm.SSHL(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8H, V1.8H, V0.8H");
        TestInst(SSHL(V0.T_8H, V31.T_8H, V0.T_8H), asm => asm.SSHL(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.8H, V31.8H, V0.8H");
        TestInst(SSHL(V30.T_8H, V31.T_8H, V0.T_8H), asm => asm.SSHL(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_5()
    {
        TestInst(SSHL(V0.T_2S, V1.T_2S, V2.T_2S), asm => asm.SSHL(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2S, V1.2S, V2.2S");
        TestInst(SSHL(V30.T_2S, V1.T_2S, V2.T_2S), asm => asm.SSHL(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2S, V1.2S, V2.2S");
        TestInst(SSHL(V0.T_2S, V31.T_2S, V2.T_2S), asm => asm.SSHL(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2S, V31.2S, V2.2S");
        TestInst(SSHL(V30.T_2S, V31.T_2S, V2.T_2S), asm => asm.SSHL(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2S, V31.2S, V2.2S");
        TestInst(SSHL(V0.T_2S, V1.T_2S, V0.T_2S), asm => asm.SSHL(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2S, V1.2S, V0.2S");
        TestInst(SSHL(V30.T_2S, V1.T_2S, V0.T_2S), asm => asm.SSHL(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2S, V1.2S, V0.2S");
        TestInst(SSHL(V0.T_2S, V31.T_2S, V0.T_2S), asm => asm.SSHL(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2S, V31.2S, V0.2S");
        TestInst(SSHL(V30.T_2S, V31.T_2S, V0.T_2S), asm => asm.SSHL(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_6()
    {
        TestInst(SSHL(V0.T_4S, V1.T_4S, V2.T_4S), asm => asm.SSHL(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4S, V1.4S, V2.4S");
        TestInst(SSHL(V30.T_4S, V1.T_4S, V2.T_4S), asm => asm.SSHL(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4S, V1.4S, V2.4S");
        TestInst(SSHL(V0.T_4S, V31.T_4S, V2.T_4S), asm => asm.SSHL(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4S, V31.4S, V2.4S");
        TestInst(SSHL(V30.T_4S, V31.T_4S, V2.T_4S), asm => asm.SSHL(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4S, V31.4S, V2.4S");
        TestInst(SSHL(V0.T_4S, V1.T_4S, V0.T_4S), asm => asm.SSHL(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4S, V1.4S, V0.4S");
        TestInst(SSHL(V30.T_4S, V1.T_4S, V0.T_4S), asm => asm.SSHL(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4S, V1.4S, V0.4S");
        TestInst(SSHL(V0.T_4S, V31.T_4S, V0.T_4S), asm => asm.SSHL(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.4S, V31.4S, V0.4S");
        TestInst(SSHL(V30.T_4S, V31.T_4S, V0.T_4S), asm => asm.SSHL(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.SSHL"/>.
    /// </summary>
    [TestMethod]
    public void Test_SSHL_asimdsame_only_7()
    {
        TestInst(SSHL(V0.T_2D, V1.T_2D, V2.T_2D), asm => asm.SSHL(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2D, V1.2D, V2.2D");
        TestInst(SSHL(V30.T_2D, V1.T_2D, V2.T_2D), asm => asm.SSHL(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2D, V1.2D, V2.2D");
        TestInst(SSHL(V0.T_2D, V31.T_2D, V2.T_2D), asm => asm.SSHL(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2D, V31.2D, V2.2D");
        TestInst(SSHL(V30.T_2D, V31.T_2D, V2.T_2D), asm => asm.SSHL(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2D, V31.2D, V2.2D");
        TestInst(SSHL(V0.T_2D, V1.T_2D, V0.T_2D), asm => asm.SSHL(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2D, V1.2D, V0.2D");
        TestInst(SSHL(V30.T_2D, V1.T_2D, V0.T_2D), asm => asm.SSHL(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2D, V1.2D, V0.2D");
        TestInst(SSHL(V0.T_2D, V31.T_2D, V0.T_2D), asm => asm.SSHL(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V0.2D, V31.2D, V0.2D");
        TestInst(SSHL(V30.T_2D, V31.T_2D, V0.T_2D), asm => asm.SSHL(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.SSHL_asimdsame_only, Arm64Mnemonic.SSHL, "SSHL V30.2D, V31.2D, V0.2D");
    }
}
