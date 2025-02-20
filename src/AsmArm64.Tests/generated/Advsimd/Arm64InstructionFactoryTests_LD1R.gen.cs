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
public class Arm64InstructionFactoryTests_LD1R_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_0()
    {
        TestInst(LD1R(V0.T_8B.Group1(), _[X2]), asm => asm.LD1R(V0.T_8B.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.8B }, [X2]");
        TestInst(LD1R(V30.T_8B.Group1(), _[X2]), asm => asm.LD1R(V30.T_8B.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.8B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_1()
    {
        TestInst(LD1R(V0.T_16B.Group1(), _[X2]), asm => asm.LD1R(V0.T_16B.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.16B }, [X2]");
        TestInst(LD1R(V30.T_16B.Group1(), _[X2]), asm => asm.LD1R(V30.T_16B.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.16B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_2()
    {
        TestInst(LD1R(V0.T_4H.Group1(), _[X2]), asm => asm.LD1R(V0.T_4H.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.4H }, [X2]");
        TestInst(LD1R(V30.T_4H.Group1(), _[X2]), asm => asm.LD1R(V30.T_4H.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.4H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_3()
    {
        TestInst(LD1R(V0.T_8H.Group1(), _[X2]), asm => asm.LD1R(V0.T_8H.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.8H }, [X2]");
        TestInst(LD1R(V30.T_8H.Group1(), _[X2]), asm => asm.LD1R(V30.T_8H.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.8H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_4()
    {
        TestInst(LD1R(V0.T_2S.Group1(), _[X2]), asm => asm.LD1R(V0.T_2S.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.2S }, [X2]");
        TestInst(LD1R(V30.T_2S.Group1(), _[X2]), asm => asm.LD1R(V30.T_2S.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.2S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_5()
    {
        TestInst(LD1R(V0.T_4S.Group1(), _[X2]), asm => asm.LD1R(V0.T_4S.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.4S }, [X2]");
        TestInst(LD1R(V30.T_4S.Group1(), _[X2]), asm => asm.LD1R(V30.T_4S.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.4S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_6()
    {
        TestInst(LD1R(V0.T_1D.Group1(), _[X2]), asm => asm.LD1R(V0.T_1D.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.1D }, [X2]");
        TestInst(LD1R(V30.T_1D.Group1(), _[X2]), asm => asm.LD1R(V30.T_1D.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.1D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlso_r1_7()
    {
        TestInst(LD1R(V0.T_2D.Group1(), _[X2]), asm => asm.LD1R(V0.T_2D.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V0.2D }, [X2]");
        TestInst(LD1R(V30.T_2D.Group1(), _[X2]), asm => asm.LD1R(V30.T_2D.Group1(), _[X2]), Arm64InstructionId.LD1R_asisdlso_r1, Arm64Mnemonic.LD1R, "LD1R { V30.2D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_8()
    {
        TestInst(LD1R(V0.T_8B.Group1(), _[X2], 1), asm => asm.LD1R(V0.T_8B.Group1(), _[X2], 1), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.8B }, [X2], #1");
        TestInst(LD1R(V30.T_8B.Group1(), _[X2], 1), asm => asm.LD1R(V30.T_8B.Group1(), _[X2], 1), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.8B }, [X2], #1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_9()
    {
        TestInst(LD1R(V0.T_16B.Group1(), _[X2], 1), asm => asm.LD1R(V0.T_16B.Group1(), _[X2], 1), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.16B }, [X2], #1");
        TestInst(LD1R(V30.T_16B.Group1(), _[X2], 1), asm => asm.LD1R(V30.T_16B.Group1(), _[X2], 1), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.16B }, [X2], #1");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_10()
    {
        TestInst(LD1R(V0.T_4H.Group1(), _[X2], 2), asm => asm.LD1R(V0.T_4H.Group1(), _[X2], 2), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.4H }, [X2], #2");
        TestInst(LD1R(V30.T_4H.Group1(), _[X2], 2), asm => asm.LD1R(V30.T_4H.Group1(), _[X2], 2), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.4H }, [X2], #2");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_11()
    {
        TestInst(LD1R(V0.T_8H.Group1(), _[X2], 2), asm => asm.LD1R(V0.T_8H.Group1(), _[X2], 2), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.8H }, [X2], #2");
        TestInst(LD1R(V30.T_8H.Group1(), _[X2], 2), asm => asm.LD1R(V30.T_8H.Group1(), _[X2], 2), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.8H }, [X2], #2");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_12()
    {
        TestInst(LD1R(V0.T_2S.Group1(), _[X2], 4), asm => asm.LD1R(V0.T_2S.Group1(), _[X2], 4), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.2S }, [X2], #4");
        TestInst(LD1R(V30.T_2S.Group1(), _[X2], 4), asm => asm.LD1R(V30.T_2S.Group1(), _[X2], 4), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.2S }, [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_13()
    {
        TestInst(LD1R(V0.T_4S.Group1(), _[X2], 4), asm => asm.LD1R(V0.T_4S.Group1(), _[X2], 4), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.4S }, [X2], #4");
        TestInst(LD1R(V30.T_4S.Group1(), _[X2], 4), asm => asm.LD1R(V30.T_4S.Group1(), _[X2], 4), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.4S }, [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_14()
    {
        TestInst(LD1R(V0.T_1D.Group1(), _[X2], 8), asm => asm.LD1R(V0.T_1D.Group1(), _[X2], 8), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.1D }, [X2], #8");
        TestInst(LD1R(V30.T_1D.Group1(), _[X2], 8), asm => asm.LD1R(V30.T_1D.Group1(), _[X2], 8), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.1D }, [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_r1_i_15()
    {
        TestInst(LD1R(V0.T_2D.Group1(), _[X2], 8), asm => asm.LD1R(V0.T_2D.Group1(), _[X2], 8), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V0.2D }, [X2], #8");
        TestInst(LD1R(V30.T_2D.Group1(), _[X2], 8), asm => asm.LD1R(V30.T_2D.Group1(), _[X2], 8), Arm64InstructionId.LD1R_asisdlsop_r1_i, Arm64Mnemonic.LD1R, "LD1R { V30.2D }, [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_16()
    {
        TestInst(LD1R(V0.T_8B.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_8B.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.8B }, [X2], X2");
        TestInst(LD1R(V30.T_8B.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_8B.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.8B }, [X2], X2");
        TestInst(LD1R(V0.T_8B.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_8B.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.8B }, [X2], X17");
        TestInst(LD1R(V30.T_8B.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_8B.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.8B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_17()
    {
        TestInst(LD1R(V0.T_16B.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_16B.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.16B }, [X2], X2");
        TestInst(LD1R(V30.T_16B.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_16B.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.16B }, [X2], X2");
        TestInst(LD1R(V0.T_16B.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_16B.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.16B }, [X2], X17");
        TestInst(LD1R(V30.T_16B.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_16B.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.16B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_18()
    {
        TestInst(LD1R(V0.T_4H.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_4H.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.4H }, [X2], X2");
        TestInst(LD1R(V30.T_4H.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_4H.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.4H }, [X2], X2");
        TestInst(LD1R(V0.T_4H.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_4H.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.4H }, [X2], X17");
        TestInst(LD1R(V30.T_4H.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_4H.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.4H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_19()
    {
        TestInst(LD1R(V0.T_8H.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_8H.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.8H }, [X2], X2");
        TestInst(LD1R(V30.T_8H.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_8H.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.8H }, [X2], X2");
        TestInst(LD1R(V0.T_8H.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_8H.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.8H }, [X2], X17");
        TestInst(LD1R(V30.T_8H.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_8H.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.8H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_20()
    {
        TestInst(LD1R(V0.T_2S.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_2S.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.2S }, [X2], X2");
        TestInst(LD1R(V30.T_2S.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_2S.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.2S }, [X2], X2");
        TestInst(LD1R(V0.T_2S.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_2S.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.2S }, [X2], X17");
        TestInst(LD1R(V30.T_2S.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_2S.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.2S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_21()
    {
        TestInst(LD1R(V0.T_4S.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_4S.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.4S }, [X2], X2");
        TestInst(LD1R(V30.T_4S.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_4S.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.4S }, [X2], X2");
        TestInst(LD1R(V0.T_4S.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_4S.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.4S }, [X2], X17");
        TestInst(LD1R(V30.T_4S.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_4S.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.4S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_22()
    {
        TestInst(LD1R(V0.T_1D.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_1D.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.1D }, [X2], X2");
        TestInst(LD1R(V30.T_1D.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_1D.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.1D }, [X2], X2");
        TestInst(LD1R(V0.T_1D.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_1D.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.1D }, [X2], X17");
        TestInst(LD1R(V30.T_1D.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_1D.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.1D }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD1R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD1R_asisdlsop_rx1_r_23()
    {
        TestInst(LD1R(V0.T_2D.Group1(), _[X2], X2), asm => asm.LD1R(V0.T_2D.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.2D }, [X2], X2");
        TestInst(LD1R(V30.T_2D.Group1(), _[X2], X2), asm => asm.LD1R(V30.T_2D.Group1(), _[X2], X2), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.2D }, [X2], X2");
        TestInst(LD1R(V0.T_2D.Group1(), _[X2], X17), asm => asm.LD1R(V0.T_2D.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V0.2D }, [X2], X17");
        TestInst(LD1R(V30.T_2D.Group1(), _[X2], X17), asm => asm.LD1R(V30.T_2D.Group1(), _[X2], X17), Arm64InstructionId.LD1R_asisdlsop_rx1_r, Arm64Mnemonic.LD1R, "LD1R { V30.2D }, [X2], X17");
    }
}
