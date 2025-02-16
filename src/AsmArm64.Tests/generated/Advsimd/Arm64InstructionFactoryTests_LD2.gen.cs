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
public class Arm64InstructionFactoryTests_LD2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_0()
    {
        TestInst(LD2(V0.T_8B.Group2(), _[X2]), asm => asm.LD2(V0.T_8B.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.8B, V1.8B }, [X2]");
        TestInst(LD2(V30.T_8B.Group2(), _[X2]), asm => asm.LD2(V30.T_8B.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.8B, V31.8B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_1()
    {
        TestInst(LD2(V0.T_16B.Group2(), _[X2]), asm => asm.LD2(V0.T_16B.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.16B, V1.16B }, [X2]");
        TestInst(LD2(V30.T_16B.Group2(), _[X2]), asm => asm.LD2(V30.T_16B.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.16B, V31.16B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_2()
    {
        TestInst(LD2(V0.T_4H.Group2(), _[X2]), asm => asm.LD2(V0.T_4H.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.4H, V1.4H }, [X2]");
        TestInst(LD2(V30.T_4H.Group2(), _[X2]), asm => asm.LD2(V30.T_4H.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.4H, V31.4H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_3()
    {
        TestInst(LD2(V0.T_8H.Group2(), _[X2]), asm => asm.LD2(V0.T_8H.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.8H, V1.8H }, [X2]");
        TestInst(LD2(V30.T_8H.Group2(), _[X2]), asm => asm.LD2(V30.T_8H.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.8H, V31.8H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_4()
    {
        TestInst(LD2(V0.T_2S.Group2(), _[X2]), asm => asm.LD2(V0.T_2S.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.2S, V1.2S }, [X2]");
        TestInst(LD2(V30.T_2S.Group2(), _[X2]), asm => asm.LD2(V30.T_2S.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.2S, V31.2S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_5()
    {
        TestInst(LD2(V0.T_4S.Group2(), _[X2]), asm => asm.LD2(V0.T_4S.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.4S, V1.4S }, [X2]");
        TestInst(LD2(V30.T_4S.Group2(), _[X2]), asm => asm.LD2(V30.T_4S.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.4S, V31.4S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlse_r2_6()
    {
        TestInst(LD2(V0.T_2D.Group2(), _[X2]), asm => asm.LD2(V0.T_2D.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V0.2D, V1.2D }, [X2]");
        TestInst(LD2(V30.T_2D.Group2(), _[X2]), asm => asm.LD2(V30.T_2D.Group2(), _[X2]), Arm64InstructionId.LD2_asisdlse_r2, Arm64Mnemonic.LD2, "LD2 { V30.2D, V31.2D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_7()
    {
        TestInst(LD2(V0.T_8B.Group2(), _[X2], 16), asm => asm.LD2(V0.T_8B.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.8B, V1.8B }, [X2], #16");
        TestInst(LD2(V30.T_8B.Group2(), _[X2], 16), asm => asm.LD2(V30.T_8B.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.8B, V31.8B }, [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_8()
    {
        TestInst(LD2(V0.T_16B.Group2(), _[X2], 32), asm => asm.LD2(V0.T_16B.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.16B, V1.16B }, [X2], #32");
        TestInst(LD2(V30.T_16B.Group2(), _[X2], 32), asm => asm.LD2(V30.T_16B.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.16B, V31.16B }, [X2], #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_9()
    {
        TestInst(LD2(V0.T_4H.Group2(), _[X2], 16), asm => asm.LD2(V0.T_4H.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.4H, V1.4H }, [X2], #16");
        TestInst(LD2(V30.T_4H.Group2(), _[X2], 16), asm => asm.LD2(V30.T_4H.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.4H, V31.4H }, [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_10()
    {
        TestInst(LD2(V0.T_8H.Group2(), _[X2], 32), asm => asm.LD2(V0.T_8H.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.8H, V1.8H }, [X2], #32");
        TestInst(LD2(V30.T_8H.Group2(), _[X2], 32), asm => asm.LD2(V30.T_8H.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.8H, V31.8H }, [X2], #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_11()
    {
        TestInst(LD2(V0.T_2S.Group2(), _[X2], 16), asm => asm.LD2(V0.T_2S.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.2S, V1.2S }, [X2], #16");
        TestInst(LD2(V30.T_2S.Group2(), _[X2], 16), asm => asm.LD2(V30.T_2S.Group2(), _[X2], 16), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.2S, V31.2S }, [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_12()
    {
        TestInst(LD2(V0.T_4S.Group2(), _[X2], 32), asm => asm.LD2(V0.T_4S.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.4S, V1.4S }, [X2], #32");
        TestInst(LD2(V30.T_4S.Group2(), _[X2], 32), asm => asm.LD2(V30.T_4S.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.4S, V31.4S }, [X2], #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_i2_i_13()
    {
        TestInst(LD2(V0.T_2D.Group2(), _[X2], 32), asm => asm.LD2(V0.T_2D.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V0.2D, V1.2D }, [X2], #32");
        TestInst(LD2(V30.T_2D.Group2(), _[X2], 32), asm => asm.LD2(V30.T_2D.Group2(), _[X2], 32), Arm64InstructionId.LD2_asisdlsep_i2_i, Arm64Mnemonic.LD2, "LD2 { V30.2D, V31.2D }, [X2], #32");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_14()
    {
        TestInst(LD2(V0.T_8B.Group2(), _[X2], X2), asm => asm.LD2(V0.T_8B.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.8B, V1.8B }, [X2], X2");
        TestInst(LD2(V30.T_8B.Group2(), _[X2], X2), asm => asm.LD2(V30.T_8B.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.8B, V31.8B }, [X2], X2");
        TestInst(LD2(V0.T_8B.Group2(), _[X2], X17), asm => asm.LD2(V0.T_8B.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.8B, V1.8B }, [X2], X17");
        TestInst(LD2(V30.T_8B.Group2(), _[X2], X17), asm => asm.LD2(V30.T_8B.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.8B, V31.8B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_15()
    {
        TestInst(LD2(V0.T_16B.Group2(), _[X2], X2), asm => asm.LD2(V0.T_16B.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.16B, V1.16B }, [X2], X2");
        TestInst(LD2(V30.T_16B.Group2(), _[X2], X2), asm => asm.LD2(V30.T_16B.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.16B, V31.16B }, [X2], X2");
        TestInst(LD2(V0.T_16B.Group2(), _[X2], X17), asm => asm.LD2(V0.T_16B.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.16B, V1.16B }, [X2], X17");
        TestInst(LD2(V30.T_16B.Group2(), _[X2], X17), asm => asm.LD2(V30.T_16B.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.16B, V31.16B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_16()
    {
        TestInst(LD2(V0.T_4H.Group2(), _[X2], X2), asm => asm.LD2(V0.T_4H.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.4H, V1.4H }, [X2], X2");
        TestInst(LD2(V30.T_4H.Group2(), _[X2], X2), asm => asm.LD2(V30.T_4H.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.4H, V31.4H }, [X2], X2");
        TestInst(LD2(V0.T_4H.Group2(), _[X2], X17), asm => asm.LD2(V0.T_4H.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.4H, V1.4H }, [X2], X17");
        TestInst(LD2(V30.T_4H.Group2(), _[X2], X17), asm => asm.LD2(V30.T_4H.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.4H, V31.4H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_17()
    {
        TestInst(LD2(V0.T_8H.Group2(), _[X2], X2), asm => asm.LD2(V0.T_8H.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.8H, V1.8H }, [X2], X2");
        TestInst(LD2(V30.T_8H.Group2(), _[X2], X2), asm => asm.LD2(V30.T_8H.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.8H, V31.8H }, [X2], X2");
        TestInst(LD2(V0.T_8H.Group2(), _[X2], X17), asm => asm.LD2(V0.T_8H.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.8H, V1.8H }, [X2], X17");
        TestInst(LD2(V30.T_8H.Group2(), _[X2], X17), asm => asm.LD2(V30.T_8H.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.8H, V31.8H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_18()
    {
        TestInst(LD2(V0.T_2S.Group2(), _[X2], X2), asm => asm.LD2(V0.T_2S.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.2S, V1.2S }, [X2], X2");
        TestInst(LD2(V30.T_2S.Group2(), _[X2], X2), asm => asm.LD2(V30.T_2S.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.2S, V31.2S }, [X2], X2");
        TestInst(LD2(V0.T_2S.Group2(), _[X2], X17), asm => asm.LD2(V0.T_2S.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.2S, V1.2S }, [X2], X17");
        TestInst(LD2(V30.T_2S.Group2(), _[X2], X17), asm => asm.LD2(V30.T_2S.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.2S, V31.2S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_19()
    {
        TestInst(LD2(V0.T_4S.Group2(), _[X2], X2), asm => asm.LD2(V0.T_4S.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.4S, V1.4S }, [X2], X2");
        TestInst(LD2(V30.T_4S.Group2(), _[X2], X2), asm => asm.LD2(V30.T_4S.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.4S, V31.4S }, [X2], X2");
        TestInst(LD2(V0.T_4S.Group2(), _[X2], X17), asm => asm.LD2(V0.T_4S.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.4S, V1.4S }, [X2], X17");
        TestInst(LD2(V30.T_4S.Group2(), _[X2], X17), asm => asm.LD2(V30.T_4S.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.4S, V31.4S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsep_r2_r_20()
    {
        TestInst(LD2(V0.T_2D.Group2(), _[X2], X2), asm => asm.LD2(V0.T_2D.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.2D, V1.2D }, [X2], X2");
        TestInst(LD2(V30.T_2D.Group2(), _[X2], X2), asm => asm.LD2(V30.T_2D.Group2(), _[X2], X2), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.2D, V31.2D }, [X2], X2");
        TestInst(LD2(V0.T_2D.Group2(), _[X2], X17), asm => asm.LD2(V0.T_2D.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V0.2D, V1.2D }, [X2], X17");
        TestInst(LD2(V30.T_2D.Group2(), _[X2], X17), asm => asm.LD2(V30.T_2D.Group2(), _[X2], X17), Arm64InstructionId.LD2_asisdlsep_r2_r, Arm64Mnemonic.LD2, "LD2 { V30.2D, V31.2D }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlso_b2_2b_21()
    {
        TestInst(LD2(V0.B.Group2()[1], _[X2]), asm => asm.LD2(V0.B.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_b2_2b, Arm64Mnemonic.LD2, "LD2 { V0.B, V1.B }[1], [X2]");
        TestInst(LD2(V30.B.Group2()[1], _[X2]), asm => asm.LD2(V30.B.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_b2_2b, Arm64Mnemonic.LD2, "LD2 { V30.B, V31.B }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlso_h2_2h_22()
    {
        TestInst(LD2(V0.H.Group2()[1], _[X2]), asm => asm.LD2(V0.H.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_h2_2h, Arm64Mnemonic.LD2, "LD2 { V0.H, V1.H }[1], [X2]");
        TestInst(LD2(V30.H.Group2()[1], _[X2]), asm => asm.LD2(V30.H.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_h2_2h, Arm64Mnemonic.LD2, "LD2 { V30.H, V31.H }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlso_s2_2s_23()
    {
        TestInst(LD2(V0.S.Group2()[1], _[X2]), asm => asm.LD2(V0.S.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_s2_2s, Arm64Mnemonic.LD2, "LD2 { V0.S, V1.S }[1], [X2]");
        TestInst(LD2(V30.S.Group2()[1], _[X2]), asm => asm.LD2(V30.S.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_s2_2s, Arm64Mnemonic.LD2, "LD2 { V30.S, V31.S }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlso_d2_2d_24()
    {
        TestInst(LD2(V0.D.Group2()[1], _[X2]), asm => asm.LD2(V0.D.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_d2_2d, Arm64Mnemonic.LD2, "LD2 { V0.D, V1.D }[1], [X2]");
        TestInst(LD2(V30.D.Group2()[1], _[X2]), asm => asm.LD2(V30.D.Group2()[1], _[X2]), Arm64InstructionId.LD2_asisdlso_d2_2d, Arm64Mnemonic.LD2, "LD2 { V30.D, V31.D }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_b2_i2b_25()
    {
        TestInst(LD2(V0.B.Group2()[1], _[X2], 2), asm => asm.LD2(V0.B.Group2()[1], _[X2], 2), Arm64InstructionId.LD2_asisdlsop_b2_i2b, Arm64Mnemonic.LD2, "LD2 { V0.B, V1.B }[1], [X2], #2");
        TestInst(LD2(V30.B.Group2()[1], _[X2], 2), asm => asm.LD2(V30.B.Group2()[1], _[X2], 2), Arm64InstructionId.LD2_asisdlsop_b2_i2b, Arm64Mnemonic.LD2, "LD2 { V30.B, V31.B }[1], [X2], #2");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_bx2_r2b_26()
    {
        TestInst(LD2(V0.B.Group2()[1], _[X2], X2), asm => asm.LD2(V0.B.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_bx2_r2b, Arm64Mnemonic.LD2, "LD2 { V0.B, V1.B }[1], [X2], X2");
        TestInst(LD2(V30.B.Group2()[1], _[X2], X2), asm => asm.LD2(V30.B.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_bx2_r2b, Arm64Mnemonic.LD2, "LD2 { V30.B, V31.B }[1], [X2], X2");
        TestInst(LD2(V0.B.Group2()[1], _[X2], X17), asm => asm.LD2(V0.B.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_bx2_r2b, Arm64Mnemonic.LD2, "LD2 { V0.B, V1.B }[1], [X2], X17");
        TestInst(LD2(V30.B.Group2()[1], _[X2], X17), asm => asm.LD2(V30.B.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_bx2_r2b, Arm64Mnemonic.LD2, "LD2 { V30.B, V31.B }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_h2_i2h_27()
    {
        TestInst(LD2(V0.H.Group2()[1], _[X2], 4), asm => asm.LD2(V0.H.Group2()[1], _[X2], 4), Arm64InstructionId.LD2_asisdlsop_h2_i2h, Arm64Mnemonic.LD2, "LD2 { V0.H, V1.H }[1], [X2], #4");
        TestInst(LD2(V30.H.Group2()[1], _[X2], 4), asm => asm.LD2(V30.H.Group2()[1], _[X2], 4), Arm64InstructionId.LD2_asisdlsop_h2_i2h, Arm64Mnemonic.LD2, "LD2 { V30.H, V31.H }[1], [X2], #4");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_hx2_r2h_28()
    {
        TestInst(LD2(V0.H.Group2()[1], _[X2], X2), asm => asm.LD2(V0.H.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_hx2_r2h, Arm64Mnemonic.LD2, "LD2 { V0.H, V1.H }[1], [X2], X2");
        TestInst(LD2(V30.H.Group2()[1], _[X2], X2), asm => asm.LD2(V30.H.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_hx2_r2h, Arm64Mnemonic.LD2, "LD2 { V30.H, V31.H }[1], [X2], X2");
        TestInst(LD2(V0.H.Group2()[1], _[X2], X17), asm => asm.LD2(V0.H.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_hx2_r2h, Arm64Mnemonic.LD2, "LD2 { V0.H, V1.H }[1], [X2], X17");
        TestInst(LD2(V30.H.Group2()[1], _[X2], X17), asm => asm.LD2(V30.H.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_hx2_r2h, Arm64Mnemonic.LD2, "LD2 { V30.H, V31.H }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_s2_i2s_29()
    {
        TestInst(LD2(V0.S.Group2()[1], _[X2], 8), asm => asm.LD2(V0.S.Group2()[1], _[X2], 8), Arm64InstructionId.LD2_asisdlsop_s2_i2s, Arm64Mnemonic.LD2, "LD2 { V0.S, V1.S }[1], [X2], #8");
        TestInst(LD2(V30.S.Group2()[1], _[X2], 8), asm => asm.LD2(V30.S.Group2()[1], _[X2], 8), Arm64InstructionId.LD2_asisdlsop_s2_i2s, Arm64Mnemonic.LD2, "LD2 { V30.S, V31.S }[1], [X2], #8");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_sx2_r2s_30()
    {
        TestInst(LD2(V0.S.Group2()[1], _[X2], X2), asm => asm.LD2(V0.S.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_sx2_r2s, Arm64Mnemonic.LD2, "LD2 { V0.S, V1.S }[1], [X2], X2");
        TestInst(LD2(V30.S.Group2()[1], _[X2], X2), asm => asm.LD2(V30.S.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_sx2_r2s, Arm64Mnemonic.LD2, "LD2 { V30.S, V31.S }[1], [X2], X2");
        TestInst(LD2(V0.S.Group2()[1], _[X2], X17), asm => asm.LD2(V0.S.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_sx2_r2s, Arm64Mnemonic.LD2, "LD2 { V0.S, V1.S }[1], [X2], X17");
        TestInst(LD2(V30.S.Group2()[1], _[X2], X17), asm => asm.LD2(V30.S.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_sx2_r2s, Arm64Mnemonic.LD2, "LD2 { V30.S, V31.S }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_d2_i2d_31()
    {
        TestInst(LD2(V0.D.Group2()[1], _[X2], 16), asm => asm.LD2(V0.D.Group2()[1], _[X2], 16), Arm64InstructionId.LD2_asisdlsop_d2_i2d, Arm64Mnemonic.LD2, "LD2 { V0.D, V1.D }[1], [X2], #16");
        TestInst(LD2(V30.D.Group2()[1], _[X2], 16), asm => asm.LD2(V30.D.Group2()[1], _[X2], 16), Arm64InstructionId.LD2_asisdlsop_d2_i2d, Arm64Mnemonic.LD2, "LD2 { V30.D, V31.D }[1], [X2], #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2_asisdlsop_dx2_r2d_32()
    {
        TestInst(LD2(V0.D.Group2()[1], _[X2], X2), asm => asm.LD2(V0.D.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_dx2_r2d, Arm64Mnemonic.LD2, "LD2 { V0.D, V1.D }[1], [X2], X2");
        TestInst(LD2(V30.D.Group2()[1], _[X2], X2), asm => asm.LD2(V30.D.Group2()[1], _[X2], X2), Arm64InstructionId.LD2_asisdlsop_dx2_r2d, Arm64Mnemonic.LD2, "LD2 { V30.D, V31.D }[1], [X2], X2");
        TestInst(LD2(V0.D.Group2()[1], _[X2], X17), asm => asm.LD2(V0.D.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_dx2_r2d, Arm64Mnemonic.LD2, "LD2 { V0.D, V1.D }[1], [X2], X17");
        TestInst(LD2(V30.D.Group2()[1], _[X2], X17), asm => asm.LD2(V30.D.Group2()[1], _[X2], X17), Arm64InstructionId.LD2_asisdlsop_dx2_r2d, Arm64Mnemonic.LD2, "LD2 { V30.D, V31.D }[1], [X2], X17");
    }
}
