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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_ADD_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asisdsame_only_0()
    {
        TestInst(ADD(D0, D1, D2), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D0, D1, D2");
        TestInst(ADD(D31, D1, D2), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D31, D1, D2");
        TestInst(ADD(D0, D31, D2), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D0, D31, D2");
        TestInst(ADD(D31, D31, D2), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D31, D31, D2");
        TestInst(ADD(D0, D1, D31), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D0, D1, D31");
        TestInst(ADD(D31, D1, D31), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D31, D1, D31");
        TestInst(ADD(D0, D31, D31), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D0, D31, D31");
        TestInst(ADD(D31, D31, D31), Arm64InstructionId.ADD_asisdsame_only, Arm64Mnemonic.ADD, "ADD D31, D31, D31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_1()
    {
        TestInst(ADD(V0.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8B, V1.8B, V2.8B");
        TestInst(ADD(V30.T_8B, V1.T_8B, V2.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8B, V1.8B, V2.8B");
        TestInst(ADD(V0.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8B, V31.8B, V2.8B");
        TestInst(ADD(V30.T_8B, V31.T_8B, V2.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8B, V31.8B, V2.8B");
        TestInst(ADD(V0.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8B, V1.8B, V0.8B");
        TestInst(ADD(V30.T_8B, V1.T_8B, V0.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8B, V1.8B, V0.8B");
        TestInst(ADD(V0.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8B, V31.8B, V0.8B");
        TestInst(ADD(V30.T_8B, V31.T_8B, V0.T_8B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8B, V31.8B, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_2()
    {
        TestInst(ADD(V0.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.16B, V1.16B, V2.16B");
        TestInst(ADD(V30.T_16B, V1.T_16B, V2.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.16B, V1.16B, V2.16B");
        TestInst(ADD(V0.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.16B, V31.16B, V2.16B");
        TestInst(ADD(V30.T_16B, V31.T_16B, V2.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.16B, V31.16B, V2.16B");
        TestInst(ADD(V0.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.16B, V1.16B, V0.16B");
        TestInst(ADD(V30.T_16B, V1.T_16B, V0.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.16B, V1.16B, V0.16B");
        TestInst(ADD(V0.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.16B, V31.16B, V0.16B");
        TestInst(ADD(V30.T_16B, V31.T_16B, V0.T_16B), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.16B, V31.16B, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_3()
    {
        TestInst(ADD(V0.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4H, V1.4H, V2.4H");
        TestInst(ADD(V30.T_4H, V1.T_4H, V2.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4H, V1.4H, V2.4H");
        TestInst(ADD(V0.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4H, V31.4H, V2.4H");
        TestInst(ADD(V30.T_4H, V31.T_4H, V2.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4H, V31.4H, V2.4H");
        TestInst(ADD(V0.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4H, V1.4H, V0.4H");
        TestInst(ADD(V30.T_4H, V1.T_4H, V0.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4H, V1.4H, V0.4H");
        TestInst(ADD(V0.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4H, V31.4H, V0.4H");
        TestInst(ADD(V30.T_4H, V31.T_4H, V0.T_4H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4H, V31.4H, V0.4H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_4()
    {
        TestInst(ADD(V0.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8H, V1.8H, V2.8H");
        TestInst(ADD(V30.T_8H, V1.T_8H, V2.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8H, V1.8H, V2.8H");
        TestInst(ADD(V0.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8H, V31.8H, V2.8H");
        TestInst(ADD(V30.T_8H, V31.T_8H, V2.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8H, V31.8H, V2.8H");
        TestInst(ADD(V0.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8H, V1.8H, V0.8H");
        TestInst(ADD(V30.T_8H, V1.T_8H, V0.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8H, V1.8H, V0.8H");
        TestInst(ADD(V0.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.8H, V31.8H, V0.8H");
        TestInst(ADD(V30.T_8H, V31.T_8H, V0.T_8H), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.8H, V31.8H, V0.8H");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_5()
    {
        TestInst(ADD(V0.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2S, V1.2S, V2.2S");
        TestInst(ADD(V30.T_2S, V1.T_2S, V2.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2S, V1.2S, V2.2S");
        TestInst(ADD(V0.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2S, V31.2S, V2.2S");
        TestInst(ADD(V30.T_2S, V31.T_2S, V2.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2S, V31.2S, V2.2S");
        TestInst(ADD(V0.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2S, V1.2S, V0.2S");
        TestInst(ADD(V30.T_2S, V1.T_2S, V0.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2S, V1.2S, V0.2S");
        TestInst(ADD(V0.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2S, V31.2S, V0.2S");
        TestInst(ADD(V30.T_2S, V31.T_2S, V0.T_2S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2S, V31.2S, V0.2S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_6()
    {
        TestInst(ADD(V0.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4S, V1.4S, V2.4S");
        TestInst(ADD(V30.T_4S, V1.T_4S, V2.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4S, V1.4S, V2.4S");
        TestInst(ADD(V0.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4S, V31.4S, V2.4S");
        TestInst(ADD(V30.T_4S, V31.T_4S, V2.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4S, V31.4S, V2.4S");
        TestInst(ADD(V0.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4S, V1.4S, V0.4S");
        TestInst(ADD(V30.T_4S, V1.T_4S, V0.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4S, V1.4S, V0.4S");
        TestInst(ADD(V0.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.4S, V31.4S, V0.4S");
        TestInst(ADD(V30.T_4S, V31.T_4S, V0.T_4S), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.4S, V31.4S, V0.4S");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADD_asimdsame_only_7()
    {
        TestInst(ADD(V0.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2D, V1.2D, V2.2D");
        TestInst(ADD(V30.T_2D, V1.T_2D, V2.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2D, V1.2D, V2.2D");
        TestInst(ADD(V0.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2D, V31.2D, V2.2D");
        TestInst(ADD(V30.T_2D, V31.T_2D, V2.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2D, V31.2D, V2.2D");
        TestInst(ADD(V0.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2D, V1.2D, V0.2D");
        TestInst(ADD(V30.T_2D, V1.T_2D, V0.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2D, V1.2D, V0.2D");
        TestInst(ADD(V0.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V0.2D, V31.2D, V0.2D");
        TestInst(ADD(V30.T_2D, V31.T_2D, V0.T_2D), Arm64InstructionId.ADD_asimdsame_only, Arm64Mnemonic.ADD, "ADD V30.2D, V31.2D, V0.2D");
    }
}
