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
public class Arm64InstructionFactoryTests_LD3R_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_0()
    {
        TestInst(LD3R(V0.T_8B.Group3(), _[X2]), asm => asm.LD3R(V0.T_8B.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.8B, V1.8B, V2.8B }, [X2]");
        TestInst(LD3R(V30.T_8B.Group3(), _[X2]), asm => asm.LD3R(V30.T_8B.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.8B, V31.8B, V0.8B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_1()
    {
        TestInst(LD3R(V0.T_16B.Group3(), _[X2]), asm => asm.LD3R(V0.T_16B.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.16B, V1.16B, V2.16B }, [X2]");
        TestInst(LD3R(V30.T_16B.Group3(), _[X2]), asm => asm.LD3R(V30.T_16B.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.16B, V31.16B, V0.16B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_2()
    {
        TestInst(LD3R(V0.T_4H.Group3(), _[X2]), asm => asm.LD3R(V0.T_4H.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.4H, V1.4H, V2.4H }, [X2]");
        TestInst(LD3R(V30.T_4H.Group3(), _[X2]), asm => asm.LD3R(V30.T_4H.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.4H, V31.4H, V0.4H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_3()
    {
        TestInst(LD3R(V0.T_8H.Group3(), _[X2]), asm => asm.LD3R(V0.T_8H.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.8H, V1.8H, V2.8H }, [X2]");
        TestInst(LD3R(V30.T_8H.Group3(), _[X2]), asm => asm.LD3R(V30.T_8H.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.8H, V31.8H, V0.8H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_4()
    {
        TestInst(LD3R(V0.T_2S.Group3(), _[X2]), asm => asm.LD3R(V0.T_2S.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.2S, V1.2S, V2.2S }, [X2]");
        TestInst(LD3R(V30.T_2S.Group3(), _[X2]), asm => asm.LD3R(V30.T_2S.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.2S, V31.2S, V0.2S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_5()
    {
        TestInst(LD3R(V0.T_4S.Group3(), _[X2]), asm => asm.LD3R(V0.T_4S.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.4S, V1.4S, V2.4S }, [X2]");
        TestInst(LD3R(V30.T_4S.Group3(), _[X2]), asm => asm.LD3R(V30.T_4S.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.4S, V31.4S, V0.4S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_6()
    {
        TestInst(LD3R(V0.T_1D.Group3(), _[X2]), asm => asm.LD3R(V0.T_1D.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.1D, V1.1D, V2.1D }, [X2]");
        TestInst(LD3R(V30.T_1D.Group3(), _[X2]), asm => asm.LD3R(V30.T_1D.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.1D, V31.1D, V0.1D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlso_r3_7()
    {
        TestInst(LD3R(V0.T_2D.Group3(), _[X2]), asm => asm.LD3R(V0.T_2D.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V0.2D, V1.2D, V2.2D }, [X2]");
        TestInst(LD3R(V30.T_2D.Group3(), _[X2]), asm => asm.LD3R(V30.T_2D.Group3(), _[X2]), Arm64InstructionId.LD3R_asisdlso_r3, Arm64Mnemonic.LD3R, "LD3R { V30.2D, V31.2D, V0.2D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_8()
    {
        TestInst(LD3R(V0.T_8B.Group3(), _[X2], 3), asm => asm.LD3R(V0.T_8B.Group3(), _[X2], 3), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.8B, V1.8B, V2.8B }, [X2], #3");
        TestInst(LD3R(V30.T_8B.Group3(), _[X2], 3), asm => asm.LD3R(V30.T_8B.Group3(), _[X2], 3), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.8B, V31.8B, V0.8B }, [X2], #3");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_9()
    {
        TestInst(LD3R(V0.T_16B.Group3(), _[X2], 3), asm => asm.LD3R(V0.T_16B.Group3(), _[X2], 3), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.16B, V1.16B, V2.16B }, [X2], #3");
        TestInst(LD3R(V30.T_16B.Group3(), _[X2], 3), asm => asm.LD3R(V30.T_16B.Group3(), _[X2], 3), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.16B, V31.16B, V0.16B }, [X2], #3");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_10()
    {
        TestInst(LD3R(V0.T_4H.Group3(), _[X2], 6), asm => asm.LD3R(V0.T_4H.Group3(), _[X2], 6), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.4H, V1.4H, V2.4H }, [X2], #6");
        TestInst(LD3R(V30.T_4H.Group3(), _[X2], 6), asm => asm.LD3R(V30.T_4H.Group3(), _[X2], 6), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.4H, V31.4H, V0.4H }, [X2], #6");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_11()
    {
        TestInst(LD3R(V0.T_8H.Group3(), _[X2], 6), asm => asm.LD3R(V0.T_8H.Group3(), _[X2], 6), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.8H, V1.8H, V2.8H }, [X2], #6");
        TestInst(LD3R(V30.T_8H.Group3(), _[X2], 6), asm => asm.LD3R(V30.T_8H.Group3(), _[X2], 6), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.8H, V31.8H, V0.8H }, [X2], #6");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_12()
    {
        TestInst(LD3R(V0.T_2S.Group3(), _[X2], 12), asm => asm.LD3R(V0.T_2S.Group3(), _[X2], 12), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.2S, V1.2S, V2.2S }, [X2], #12");
        TestInst(LD3R(V30.T_2S.Group3(), _[X2], 12), asm => asm.LD3R(V30.T_2S.Group3(), _[X2], 12), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.2S, V31.2S, V0.2S }, [X2], #12");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_13()
    {
        TestInst(LD3R(V0.T_4S.Group3(), _[X2], 12), asm => asm.LD3R(V0.T_4S.Group3(), _[X2], 12), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.4S, V1.4S, V2.4S }, [X2], #12");
        TestInst(LD3R(V30.T_4S.Group3(), _[X2], 12), asm => asm.LD3R(V30.T_4S.Group3(), _[X2], 12), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.4S, V31.4S, V0.4S }, [X2], #12");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_14()
    {
        TestInst(LD3R(V0.T_1D.Group3(), _[X2], 24), asm => asm.LD3R(V0.T_1D.Group3(), _[X2], 24), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.1D, V1.1D, V2.1D }, [X2], #24");
        TestInst(LD3R(V30.T_1D.Group3(), _[X2], 24), asm => asm.LD3R(V30.T_1D.Group3(), _[X2], 24), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.1D, V31.1D, V0.1D }, [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_r3_i_15()
    {
        TestInst(LD3R(V0.T_2D.Group3(), _[X2], 24), asm => asm.LD3R(V0.T_2D.Group3(), _[X2], 24), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V0.2D, V1.2D, V2.2D }, [X2], #24");
        TestInst(LD3R(V30.T_2D.Group3(), _[X2], 24), asm => asm.LD3R(V30.T_2D.Group3(), _[X2], 24), Arm64InstructionId.LD3R_asisdlsop_r3_i, Arm64Mnemonic.LD3R, "LD3R { V30.2D, V31.2D, V0.2D }, [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_16()
    {
        TestInst(LD3R(V0.T_8B.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_8B.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.8B, V1.8B, V2.8B }, [X2], X2");
        TestInst(LD3R(V30.T_8B.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_8B.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.8B, V31.8B, V0.8B }, [X2], X2");
        TestInst(LD3R(V0.T_8B.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_8B.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.8B, V1.8B, V2.8B }, [X2], X17");
        TestInst(LD3R(V30.T_8B.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_8B.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.8B, V31.8B, V0.8B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_17()
    {
        TestInst(LD3R(V0.T_16B.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_16B.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.16B, V1.16B, V2.16B }, [X2], X2");
        TestInst(LD3R(V30.T_16B.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_16B.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.16B, V31.16B, V0.16B }, [X2], X2");
        TestInst(LD3R(V0.T_16B.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_16B.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.16B, V1.16B, V2.16B }, [X2], X17");
        TestInst(LD3R(V30.T_16B.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_16B.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.16B, V31.16B, V0.16B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_18()
    {
        TestInst(LD3R(V0.T_4H.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_4H.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.4H, V1.4H, V2.4H }, [X2], X2");
        TestInst(LD3R(V30.T_4H.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_4H.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.4H, V31.4H, V0.4H }, [X2], X2");
        TestInst(LD3R(V0.T_4H.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_4H.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.4H, V1.4H, V2.4H }, [X2], X17");
        TestInst(LD3R(V30.T_4H.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_4H.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.4H, V31.4H, V0.4H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_19()
    {
        TestInst(LD3R(V0.T_8H.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_8H.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.8H, V1.8H, V2.8H }, [X2], X2");
        TestInst(LD3R(V30.T_8H.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_8H.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.8H, V31.8H, V0.8H }, [X2], X2");
        TestInst(LD3R(V0.T_8H.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_8H.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.8H, V1.8H, V2.8H }, [X2], X17");
        TestInst(LD3R(V30.T_8H.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_8H.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.8H, V31.8H, V0.8H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_20()
    {
        TestInst(LD3R(V0.T_2S.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_2S.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.2S, V1.2S, V2.2S }, [X2], X2");
        TestInst(LD3R(V30.T_2S.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_2S.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.2S, V31.2S, V0.2S }, [X2], X2");
        TestInst(LD3R(V0.T_2S.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_2S.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.2S, V1.2S, V2.2S }, [X2], X17");
        TestInst(LD3R(V30.T_2S.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_2S.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.2S, V31.2S, V0.2S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_21()
    {
        TestInst(LD3R(V0.T_4S.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_4S.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.4S, V1.4S, V2.4S }, [X2], X2");
        TestInst(LD3R(V30.T_4S.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_4S.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.4S, V31.4S, V0.4S }, [X2], X2");
        TestInst(LD3R(V0.T_4S.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_4S.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.4S, V1.4S, V2.4S }, [X2], X17");
        TestInst(LD3R(V30.T_4S.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_4S.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.4S, V31.4S, V0.4S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_22()
    {
        TestInst(LD3R(V0.T_1D.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_1D.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.1D, V1.1D, V2.1D }, [X2], X2");
        TestInst(LD3R(V30.T_1D.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_1D.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.1D, V31.1D, V0.1D }, [X2], X2");
        TestInst(LD3R(V0.T_1D.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_1D.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.1D, V1.1D, V2.1D }, [X2], X17");
        TestInst(LD3R(V30.T_1D.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_1D.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.1D, V31.1D, V0.1D }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3R_asisdlsop_rx3_r_23()
    {
        TestInst(LD3R(V0.T_2D.Group3(), _[X2], X2), asm => asm.LD3R(V0.T_2D.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.2D, V1.2D, V2.2D }, [X2], X2");
        TestInst(LD3R(V30.T_2D.Group3(), _[X2], X2), asm => asm.LD3R(V30.T_2D.Group3(), _[X2], X2), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.2D, V31.2D, V0.2D }, [X2], X2");
        TestInst(LD3R(V0.T_2D.Group3(), _[X2], X17), asm => asm.LD3R(V0.T_2D.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V0.2D, V1.2D, V2.2D }, [X2], X17");
        TestInst(LD3R(V30.T_2D.Group3(), _[X2], X17), asm => asm.LD3R(V30.T_2D.Group3(), _[X2], X17), Arm64InstructionId.LD3R_asisdlsop_rx3_r, Arm64Mnemonic.LD3R, "LD3R { V30.2D, V31.2D, V0.2D }, [X2], X17");
    }
}
