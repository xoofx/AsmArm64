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
public class Arm64InstructionFactoryTests_LD2R_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_0()
    {
        TestInst(LD2R(V0.T_8B.Group2(), _[X2]), asm => asm.LD2R(V0.T_8B.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.8B, V1.8B }, [X2]");
        TestInst(LD2R(V30.T_8B.Group2(), _[X2]), asm => asm.LD2R(V30.T_8B.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.8B, V31.8B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_1()
    {
        TestInst(LD2R(V0.T_16B.Group2(), _[X2]), asm => asm.LD2R(V0.T_16B.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.16B, V1.16B }, [X2]");
        TestInst(LD2R(V30.T_16B.Group2(), _[X2]), asm => asm.LD2R(V30.T_16B.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.16B, V31.16B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_2()
    {
        TestInst(LD2R(V0.T_4H.Group2(), _[X2]), asm => asm.LD2R(V0.T_4H.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.4H, V1.4H }, [X2]");
        TestInst(LD2R(V30.T_4H.Group2(), _[X2]), asm => asm.LD2R(V30.T_4H.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.4H, V31.4H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_3()
    {
        TestInst(LD2R(V0.T_8H.Group2(), _[X2]), asm => asm.LD2R(V0.T_8H.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.8H, V1.8H }, [X2]");
        TestInst(LD2R(V30.T_8H.Group2(), _[X2]), asm => asm.LD2R(V30.T_8H.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.8H, V31.8H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_4()
    {
        TestInst(LD2R(V0.T_2S.Group2(), _[X2]), asm => asm.LD2R(V0.T_2S.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.2S, V1.2S }, [X2]");
        TestInst(LD2R(V30.T_2S.Group2(), _[X2]), asm => asm.LD2R(V30.T_2S.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.2S, V31.2S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_5()
    {
        TestInst(LD2R(V0.T_4S.Group2(), _[X2]), asm => asm.LD2R(V0.T_4S.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.4S, V1.4S }, [X2]");
        TestInst(LD2R(V30.T_4S.Group2(), _[X2]), asm => asm.LD2R(V30.T_4S.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.4S, V31.4S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_6()
    {
        TestInst(LD2R(V0.T_1D.Group2(), _[X2]), asm => asm.LD2R(V0.T_1D.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.1D, V1.1D }, [X2]");
        TestInst(LD2R(V30.T_1D.Group2(), _[X2]), asm => asm.LD2R(V30.T_1D.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.1D, V31.1D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_7()
    {
        TestInst(LD2R(V0.T_2D.Group2(), _[X2]), asm => asm.LD2R(V0.T_2D.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V0.2D, V1.2D }, [X2]");
        TestInst(LD2R(V30.T_2D.Group2(), _[X2]), asm => asm.LD2R(V30.T_2D.Group2(), _[X2]), Arm64InstructionId.LD2R_asisdlso_r2, Arm64Mnemonic.LD2R, "LD2R { V30.2D, V31.2D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_8()
    {
        TestInst(LD2R(V0.T_8B.Group2(), _[X2], 2), asm => asm.LD2R(V0.T_8B.Group2(), _[X2], 2), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.8B, V1.8B }, [X2], #2");
        TestInst(LD2R(V30.T_8B.Group2(), _[X2], 2), asm => asm.LD2R(V30.T_8B.Group2(), _[X2], 2), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.8B, V31.8B }, [X2], #2");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_9()
    {
        TestInst(LD2R(V0.T_16B.Group2(), _[X2], 2), asm => asm.LD2R(V0.T_16B.Group2(), _[X2], 2), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.16B, V1.16B }, [X2], #2");
        TestInst(LD2R(V30.T_16B.Group2(), _[X2], 2), asm => asm.LD2R(V30.T_16B.Group2(), _[X2], 2), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.16B, V31.16B }, [X2], #2");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_10()
    {
        TestInst(LD2R(V0.T_4H.Group2(), _[X2], 4), asm => asm.LD2R(V0.T_4H.Group2(), _[X2], 4), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.4H, V1.4H }, [X2], #4");
        TestInst(LD2R(V30.T_4H.Group2(), _[X2], 4), asm => asm.LD2R(V30.T_4H.Group2(), _[X2], 4), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.4H, V31.4H }, [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_11()
    {
        TestInst(LD2R(V0.T_8H.Group2(), _[X2], 4), asm => asm.LD2R(V0.T_8H.Group2(), _[X2], 4), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.8H, V1.8H }, [X2], #4");
        TestInst(LD2R(V30.T_8H.Group2(), _[X2], 4), asm => asm.LD2R(V30.T_8H.Group2(), _[X2], 4), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.8H, V31.8H }, [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_12()
    {
        TestInst(LD2R(V0.T_2S.Group2(), _[X2], 8), asm => asm.LD2R(V0.T_2S.Group2(), _[X2], 8), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.2S, V1.2S }, [X2], #8");
        TestInst(LD2R(V30.T_2S.Group2(), _[X2], 8), asm => asm.LD2R(V30.T_2S.Group2(), _[X2], 8), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.2S, V31.2S }, [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_13()
    {
        TestInst(LD2R(V0.T_4S.Group2(), _[X2], 8), asm => asm.LD2R(V0.T_4S.Group2(), _[X2], 8), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.4S, V1.4S }, [X2], #8");
        TestInst(LD2R(V30.T_4S.Group2(), _[X2], 8), asm => asm.LD2R(V30.T_4S.Group2(), _[X2], 8), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.4S, V31.4S }, [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_14()
    {
        TestInst(LD2R(V0.T_1D.Group2(), _[X2], 16), asm => asm.LD2R(V0.T_1D.Group2(), _[X2], 16), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.1D, V1.1D }, [X2], #16");
        TestInst(LD2R(V30.T_1D.Group2(), _[X2], 16), asm => asm.LD2R(V30.T_1D.Group2(), _[X2], 16), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.1D, V31.1D }, [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_15()
    {
        TestInst(LD2R(V0.T_2D.Group2(), _[X2], 16), asm => asm.LD2R(V0.T_2D.Group2(), _[X2], 16), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V0.2D, V1.2D }, [X2], #16");
        TestInst(LD2R(V30.T_2D.Group2(), _[X2], 16), asm => asm.LD2R(V30.T_2D.Group2(), _[X2], 16), Arm64InstructionId.LD2R_asisdlsop_r2_i, Arm64Mnemonic.LD2R, "LD2R { V30.2D, V31.2D }, [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_16()
    {
        TestInst(LD2R(V0.T_8B.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_8B.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.8B, V1.8B }, [X2], X2");
        TestInst(LD2R(V30.T_8B.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_8B.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.8B, V31.8B }, [X2], X2");
        TestInst(LD2R(V0.T_8B.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_8B.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.8B, V1.8B }, [X2], X17");
        TestInst(LD2R(V30.T_8B.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_8B.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.8B, V31.8B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_17()
    {
        TestInst(LD2R(V0.T_16B.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_16B.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.16B, V1.16B }, [X2], X2");
        TestInst(LD2R(V30.T_16B.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_16B.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.16B, V31.16B }, [X2], X2");
        TestInst(LD2R(V0.T_16B.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_16B.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.16B, V1.16B }, [X2], X17");
        TestInst(LD2R(V30.T_16B.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_16B.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.16B, V31.16B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_18()
    {
        TestInst(LD2R(V0.T_4H.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_4H.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.4H, V1.4H }, [X2], X2");
        TestInst(LD2R(V30.T_4H.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_4H.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.4H, V31.4H }, [X2], X2");
        TestInst(LD2R(V0.T_4H.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_4H.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.4H, V1.4H }, [X2], X17");
        TestInst(LD2R(V30.T_4H.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_4H.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.4H, V31.4H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_19()
    {
        TestInst(LD2R(V0.T_8H.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_8H.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.8H, V1.8H }, [X2], X2");
        TestInst(LD2R(V30.T_8H.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_8H.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.8H, V31.8H }, [X2], X2");
        TestInst(LD2R(V0.T_8H.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_8H.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.8H, V1.8H }, [X2], X17");
        TestInst(LD2R(V30.T_8H.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_8H.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.8H, V31.8H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_20()
    {
        TestInst(LD2R(V0.T_2S.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_2S.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.2S, V1.2S }, [X2], X2");
        TestInst(LD2R(V30.T_2S.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_2S.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.2S, V31.2S }, [X2], X2");
        TestInst(LD2R(V0.T_2S.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_2S.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.2S, V1.2S }, [X2], X17");
        TestInst(LD2R(V30.T_2S.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_2S.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.2S, V31.2S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_21()
    {
        TestInst(LD2R(V0.T_4S.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_4S.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.4S, V1.4S }, [X2], X2");
        TestInst(LD2R(V30.T_4S.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_4S.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.4S, V31.4S }, [X2], X2");
        TestInst(LD2R(V0.T_4S.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_4S.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.4S, V1.4S }, [X2], X17");
        TestInst(LD2R(V30.T_4S.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_4S.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.4S, V31.4S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_22()
    {
        TestInst(LD2R(V0.T_1D.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_1D.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.1D, V1.1D }, [X2], X2");
        TestInst(LD2R(V30.T_1D.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_1D.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.1D, V31.1D }, [X2], X2");
        TestInst(LD2R(V0.T_1D.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_1D.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.1D, V1.1D }, [X2], X17");
        TestInst(LD2R(V30.T_1D.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_1D.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.1D, V31.1D }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_23()
    {
        TestInst(LD2R(V0.T_2D.Group2(), _[X2], X2), asm => asm.LD2R(V0.T_2D.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.2D, V1.2D }, [X2], X2");
        TestInst(LD2R(V30.T_2D.Group2(), _[X2], X2), asm => asm.LD2R(V30.T_2D.Group2(), _[X2], X2), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.2D, V31.2D }, [X2], X2");
        TestInst(LD2R(V0.T_2D.Group2(), _[X2], X17), asm => asm.LD2R(V0.T_2D.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V0.2D, V1.2D }, [X2], X17");
        TestInst(LD2R(V30.T_2D.Group2(), _[X2], X17), asm => asm.LD2R(V30.T_2D.Group2(), _[X2], X17), Arm64InstructionId.LD2R_asisdlsop_rx2_r, Arm64Mnemonic.LD2R, "LD2R { V30.2D, V31.2D }, [X2], X17");
    }
}
