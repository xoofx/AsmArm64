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
public class Arm64InstructionFactoryTests_LD3_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_0()
    {
        TestInst(LD3(V0.T_8B.Group3(), _[X2]), asm => asm.LD3(V0.T_8B.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.8B, V1.8B, V2.8B }, [X2]");
        TestInst(LD3(V30.T_8B.Group3(), _[X2]), asm => asm.LD3(V30.T_8B.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.8B, V31.8B, V0.8B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_1()
    {
        TestInst(LD3(V0.T_16B.Group3(), _[X2]), asm => asm.LD3(V0.T_16B.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.16B, V1.16B, V2.16B }, [X2]");
        TestInst(LD3(V30.T_16B.Group3(), _[X2]), asm => asm.LD3(V30.T_16B.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.16B, V31.16B, V0.16B }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_2()
    {
        TestInst(LD3(V0.T_4H.Group3(), _[X2]), asm => asm.LD3(V0.T_4H.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.4H, V1.4H, V2.4H }, [X2]");
        TestInst(LD3(V30.T_4H.Group3(), _[X2]), asm => asm.LD3(V30.T_4H.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.4H, V31.4H, V0.4H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_3()
    {
        TestInst(LD3(V0.T_8H.Group3(), _[X2]), asm => asm.LD3(V0.T_8H.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.8H, V1.8H, V2.8H }, [X2]");
        TestInst(LD3(V30.T_8H.Group3(), _[X2]), asm => asm.LD3(V30.T_8H.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.8H, V31.8H, V0.8H }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_4()
    {
        TestInst(LD3(V0.T_2S.Group3(), _[X2]), asm => asm.LD3(V0.T_2S.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.2S, V1.2S, V2.2S }, [X2]");
        TestInst(LD3(V30.T_2S.Group3(), _[X2]), asm => asm.LD3(V30.T_2S.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.2S, V31.2S, V0.2S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_5()
    {
        TestInst(LD3(V0.T_4S.Group3(), _[X2]), asm => asm.LD3(V0.T_4S.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.4S, V1.4S, V2.4S }, [X2]");
        TestInst(LD3(V30.T_4S.Group3(), _[X2]), asm => asm.LD3(V30.T_4S.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.4S, V31.4S, V0.4S }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlse_r3_6()
    {
        TestInst(LD3(V0.T_2D.Group3(), _[X2]), asm => asm.LD3(V0.T_2D.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V0.2D, V1.2D, V2.2D }, [X2]");
        TestInst(LD3(V30.T_2D.Group3(), _[X2]), asm => asm.LD3(V30.T_2D.Group3(), _[X2]), Arm64InstructionId.LD3_asisdlse_r3, Arm64Mnemonic.LD3, "LD3 { V30.2D, V31.2D, V0.2D }, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_7()
    {
        TestInst(LD3(V0.T_8B.Group3(), _[X2], 24), asm => asm.LD3(V0.T_8B.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.8B, V1.8B, V2.8B }, [X2], #24");
        TestInst(LD3(V30.T_8B.Group3(), _[X2], 24), asm => asm.LD3(V30.T_8B.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.8B, V31.8B, V0.8B }, [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_8()
    {
        TestInst(LD3(V0.T_16B.Group3(), _[X2], 48), asm => asm.LD3(V0.T_16B.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.16B, V1.16B, V2.16B }, [X2], #48");
        TestInst(LD3(V30.T_16B.Group3(), _[X2], 48), asm => asm.LD3(V30.T_16B.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.16B, V31.16B, V0.16B }, [X2], #48");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_9()
    {
        TestInst(LD3(V0.T_4H.Group3(), _[X2], 24), asm => asm.LD3(V0.T_4H.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.4H, V1.4H, V2.4H }, [X2], #24");
        TestInst(LD3(V30.T_4H.Group3(), _[X2], 24), asm => asm.LD3(V30.T_4H.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.4H, V31.4H, V0.4H }, [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_10()
    {
        TestInst(LD3(V0.T_8H.Group3(), _[X2], 48), asm => asm.LD3(V0.T_8H.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.8H, V1.8H, V2.8H }, [X2], #48");
        TestInst(LD3(V30.T_8H.Group3(), _[X2], 48), asm => asm.LD3(V30.T_8H.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.8H, V31.8H, V0.8H }, [X2], #48");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_11()
    {
        TestInst(LD3(V0.T_2S.Group3(), _[X2], 24), asm => asm.LD3(V0.T_2S.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.2S, V1.2S, V2.2S }, [X2], #24");
        TestInst(LD3(V30.T_2S.Group3(), _[X2], 24), asm => asm.LD3(V30.T_2S.Group3(), _[X2], 24), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.2S, V31.2S, V0.2S }, [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_12()
    {
        TestInst(LD3(V0.T_4S.Group3(), _[X2], 48), asm => asm.LD3(V0.T_4S.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.4S, V1.4S, V2.4S }, [X2], #48");
        TestInst(LD3(V30.T_4S.Group3(), _[X2], 48), asm => asm.LD3(V30.T_4S.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.4S, V31.4S, V0.4S }, [X2], #48");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_i3_i_13()
    {
        TestInst(LD3(V0.T_2D.Group3(), _[X2], 48), asm => asm.LD3(V0.T_2D.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V0.2D, V1.2D, V2.2D }, [X2], #48");
        TestInst(LD3(V30.T_2D.Group3(), _[X2], 48), asm => asm.LD3(V30.T_2D.Group3(), _[X2], 48), Arm64InstructionId.LD3_asisdlsep_i3_i, Arm64Mnemonic.LD3, "LD3 { V30.2D, V31.2D, V0.2D }, [X2], #48");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_14()
    {
        TestInst(LD3(V0.T_8B.Group3(), _[X2], X2), asm => asm.LD3(V0.T_8B.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.8B, V1.8B, V2.8B }, [X2], X2");
        TestInst(LD3(V30.T_8B.Group3(), _[X2], X2), asm => asm.LD3(V30.T_8B.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.8B, V31.8B, V0.8B }, [X2], X2");
        TestInst(LD3(V0.T_8B.Group3(), _[X2], X17), asm => asm.LD3(V0.T_8B.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.8B, V1.8B, V2.8B }, [X2], X17");
        TestInst(LD3(V30.T_8B.Group3(), _[X2], X17), asm => asm.LD3(V30.T_8B.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.8B, V31.8B, V0.8B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_15()
    {
        TestInst(LD3(V0.T_16B.Group3(), _[X2], X2), asm => asm.LD3(V0.T_16B.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.16B, V1.16B, V2.16B }, [X2], X2");
        TestInst(LD3(V30.T_16B.Group3(), _[X2], X2), asm => asm.LD3(V30.T_16B.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.16B, V31.16B, V0.16B }, [X2], X2");
        TestInst(LD3(V0.T_16B.Group3(), _[X2], X17), asm => asm.LD3(V0.T_16B.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.16B, V1.16B, V2.16B }, [X2], X17");
        TestInst(LD3(V30.T_16B.Group3(), _[X2], X17), asm => asm.LD3(V30.T_16B.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.16B, V31.16B, V0.16B }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_16()
    {
        TestInst(LD3(V0.T_4H.Group3(), _[X2], X2), asm => asm.LD3(V0.T_4H.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.4H, V1.4H, V2.4H }, [X2], X2");
        TestInst(LD3(V30.T_4H.Group3(), _[X2], X2), asm => asm.LD3(V30.T_4H.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.4H, V31.4H, V0.4H }, [X2], X2");
        TestInst(LD3(V0.T_4H.Group3(), _[X2], X17), asm => asm.LD3(V0.T_4H.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.4H, V1.4H, V2.4H }, [X2], X17");
        TestInst(LD3(V30.T_4H.Group3(), _[X2], X17), asm => asm.LD3(V30.T_4H.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.4H, V31.4H, V0.4H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_17()
    {
        TestInst(LD3(V0.T_8H.Group3(), _[X2], X2), asm => asm.LD3(V0.T_8H.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.8H, V1.8H, V2.8H }, [X2], X2");
        TestInst(LD3(V30.T_8H.Group3(), _[X2], X2), asm => asm.LD3(V30.T_8H.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.8H, V31.8H, V0.8H }, [X2], X2");
        TestInst(LD3(V0.T_8H.Group3(), _[X2], X17), asm => asm.LD3(V0.T_8H.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.8H, V1.8H, V2.8H }, [X2], X17");
        TestInst(LD3(V30.T_8H.Group3(), _[X2], X17), asm => asm.LD3(V30.T_8H.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.8H, V31.8H, V0.8H }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_18()
    {
        TestInst(LD3(V0.T_2S.Group3(), _[X2], X2), asm => asm.LD3(V0.T_2S.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.2S, V1.2S, V2.2S }, [X2], X2");
        TestInst(LD3(V30.T_2S.Group3(), _[X2], X2), asm => asm.LD3(V30.T_2S.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.2S, V31.2S, V0.2S }, [X2], X2");
        TestInst(LD3(V0.T_2S.Group3(), _[X2], X17), asm => asm.LD3(V0.T_2S.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.2S, V1.2S, V2.2S }, [X2], X17");
        TestInst(LD3(V30.T_2S.Group3(), _[X2], X17), asm => asm.LD3(V30.T_2S.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.2S, V31.2S, V0.2S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_19()
    {
        TestInst(LD3(V0.T_4S.Group3(), _[X2], X2), asm => asm.LD3(V0.T_4S.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.4S, V1.4S, V2.4S }, [X2], X2");
        TestInst(LD3(V30.T_4S.Group3(), _[X2], X2), asm => asm.LD3(V30.T_4S.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.4S, V31.4S, V0.4S }, [X2], X2");
        TestInst(LD3(V0.T_4S.Group3(), _[X2], X17), asm => asm.LD3(V0.T_4S.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.4S, V1.4S, V2.4S }, [X2], X17");
        TestInst(LD3(V30.T_4S.Group3(), _[X2], X17), asm => asm.LD3(V30.T_4S.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.4S, V31.4S, V0.4S }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsep_r3_r_20()
    {
        TestInst(LD3(V0.T_2D.Group3(), _[X2], X2), asm => asm.LD3(V0.T_2D.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.2D, V1.2D, V2.2D }, [X2], X2");
        TestInst(LD3(V30.T_2D.Group3(), _[X2], X2), asm => asm.LD3(V30.T_2D.Group3(), _[X2], X2), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.2D, V31.2D, V0.2D }, [X2], X2");
        TestInst(LD3(V0.T_2D.Group3(), _[X2], X17), asm => asm.LD3(V0.T_2D.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V0.2D, V1.2D, V2.2D }, [X2], X17");
        TestInst(LD3(V30.T_2D.Group3(), _[X2], X17), asm => asm.LD3(V30.T_2D.Group3(), _[X2], X17), Arm64InstructionId.LD3_asisdlsep_r3_r, Arm64Mnemonic.LD3, "LD3 { V30.2D, V31.2D, V0.2D }, [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlso_b3_3b_21()
    {
        TestInst(LD3(V0.B.Group3()[1], _[X2]), asm => asm.LD3(V0.B.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_b3_3b, Arm64Mnemonic.LD3, "LD3 { V0.B, V1.B, V2.B }[1], [X2]");
        TestInst(LD3(V30.B.Group3()[1], _[X2]), asm => asm.LD3(V30.B.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_b3_3b, Arm64Mnemonic.LD3, "LD3 { V30.B, V31.B, V0.B }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlso_h3_3h_22()
    {
        TestInst(LD3(V0.H.Group3()[1], _[X2]), asm => asm.LD3(V0.H.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_h3_3h, Arm64Mnemonic.LD3, "LD3 { V0.H, V1.H, V2.H }[1], [X2]");
        TestInst(LD3(V30.H.Group3()[1], _[X2]), asm => asm.LD3(V30.H.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_h3_3h, Arm64Mnemonic.LD3, "LD3 { V30.H, V31.H, V0.H }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlso_s3_3s_23()
    {
        TestInst(LD3(V0.S.Group3()[1], _[X2]), asm => asm.LD3(V0.S.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_s3_3s, Arm64Mnemonic.LD3, "LD3 { V0.S, V1.S, V2.S }[1], [X2]");
        TestInst(LD3(V30.S.Group3()[1], _[X2]), asm => asm.LD3(V30.S.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_s3_3s, Arm64Mnemonic.LD3, "LD3 { V30.S, V31.S, V0.S }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlso_d3_3d_24()
    {
        TestInst(LD3(V0.D.Group3()[1], _[X2]), asm => asm.LD3(V0.D.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_d3_3d, Arm64Mnemonic.LD3, "LD3 { V0.D, V1.D, V2.D }[1], [X2]");
        TestInst(LD3(V30.D.Group3()[1], _[X2]), asm => asm.LD3(V30.D.Group3()[1], _[X2]), Arm64InstructionId.LD3_asisdlso_d3_3d, Arm64Mnemonic.LD3, "LD3 { V30.D, V31.D, V0.D }[1], [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_b3_i3b_25()
    {
        TestInst(LD3(V0.B.Group3()[1], _[X2], 3), asm => asm.LD3(V0.B.Group3()[1], _[X2], 3), Arm64InstructionId.LD3_asisdlsop_b3_i3b, Arm64Mnemonic.LD3, "LD3 { V0.B, V1.B, V2.B }[1], [X2], #3");
        TestInst(LD3(V30.B.Group3()[1], _[X2], 3), asm => asm.LD3(V30.B.Group3()[1], _[X2], 3), Arm64InstructionId.LD3_asisdlsop_b3_i3b, Arm64Mnemonic.LD3, "LD3 { V30.B, V31.B, V0.B }[1], [X2], #3");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_bx3_r3b_26()
    {
        TestInst(LD3(V0.B.Group3()[1], _[X2], X2), asm => asm.LD3(V0.B.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_bx3_r3b, Arm64Mnemonic.LD3, "LD3 { V0.B, V1.B, V2.B }[1], [X2], X2");
        TestInst(LD3(V30.B.Group3()[1], _[X2], X2), asm => asm.LD3(V30.B.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_bx3_r3b, Arm64Mnemonic.LD3, "LD3 { V30.B, V31.B, V0.B }[1], [X2], X2");
        TestInst(LD3(V0.B.Group3()[1], _[X2], X17), asm => asm.LD3(V0.B.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_bx3_r3b, Arm64Mnemonic.LD3, "LD3 { V0.B, V1.B, V2.B }[1], [X2], X17");
        TestInst(LD3(V30.B.Group3()[1], _[X2], X17), asm => asm.LD3(V30.B.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_bx3_r3b, Arm64Mnemonic.LD3, "LD3 { V30.B, V31.B, V0.B }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_h3_i3h_27()
    {
        TestInst(LD3(V0.H.Group3()[1], _[X2], 6), asm => asm.LD3(V0.H.Group3()[1], _[X2], 6), Arm64InstructionId.LD3_asisdlsop_h3_i3h, Arm64Mnemonic.LD3, "LD3 { V0.H, V1.H, V2.H }[1], [X2], #6");
        TestInst(LD3(V30.H.Group3()[1], _[X2], 6), asm => asm.LD3(V30.H.Group3()[1], _[X2], 6), Arm64InstructionId.LD3_asisdlsop_h3_i3h, Arm64Mnemonic.LD3, "LD3 { V30.H, V31.H, V0.H }[1], [X2], #6");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_hx3_r3h_28()
    {
        TestInst(LD3(V0.H.Group3()[1], _[X2], X2), asm => asm.LD3(V0.H.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_hx3_r3h, Arm64Mnemonic.LD3, "LD3 { V0.H, V1.H, V2.H }[1], [X2], X2");
        TestInst(LD3(V30.H.Group3()[1], _[X2], X2), asm => asm.LD3(V30.H.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_hx3_r3h, Arm64Mnemonic.LD3, "LD3 { V30.H, V31.H, V0.H }[1], [X2], X2");
        TestInst(LD3(V0.H.Group3()[1], _[X2], X17), asm => asm.LD3(V0.H.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_hx3_r3h, Arm64Mnemonic.LD3, "LD3 { V0.H, V1.H, V2.H }[1], [X2], X17");
        TestInst(LD3(V30.H.Group3()[1], _[X2], X17), asm => asm.LD3(V30.H.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_hx3_r3h, Arm64Mnemonic.LD3, "LD3 { V30.H, V31.H, V0.H }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_s3_i3s_29()
    {
        TestInst(LD3(V0.S.Group3()[1], _[X2], 12), asm => asm.LD3(V0.S.Group3()[1], _[X2], 12), Arm64InstructionId.LD3_asisdlsop_s3_i3s, Arm64Mnemonic.LD3, "LD3 { V0.S, V1.S, V2.S }[1], [X2], #12");
        TestInst(LD3(V30.S.Group3()[1], _[X2], 12), asm => asm.LD3(V30.S.Group3()[1], _[X2], 12), Arm64InstructionId.LD3_asisdlsop_s3_i3s, Arm64Mnemonic.LD3, "LD3 { V30.S, V31.S, V0.S }[1], [X2], #12");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_sx3_r3s_30()
    {
        TestInst(LD3(V0.S.Group3()[1], _[X2], X2), asm => asm.LD3(V0.S.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_sx3_r3s, Arm64Mnemonic.LD3, "LD3 { V0.S, V1.S, V2.S }[1], [X2], X2");
        TestInst(LD3(V30.S.Group3()[1], _[X2], X2), asm => asm.LD3(V30.S.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_sx3_r3s, Arm64Mnemonic.LD3, "LD3 { V30.S, V31.S, V0.S }[1], [X2], X2");
        TestInst(LD3(V0.S.Group3()[1], _[X2], X17), asm => asm.LD3(V0.S.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_sx3_r3s, Arm64Mnemonic.LD3, "LD3 { V0.S, V1.S, V2.S }[1], [X2], X17");
        TestInst(LD3(V30.S.Group3()[1], _[X2], X17), asm => asm.LD3(V30.S.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_sx3_r3s, Arm64Mnemonic.LD3, "LD3 { V30.S, V31.S, V0.S }[1], [X2], X17");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_d3_i3d_31()
    {
        TestInst(LD3(V0.D.Group3()[1], _[X2], 24), asm => asm.LD3(V0.D.Group3()[1], _[X2], 24), Arm64InstructionId.LD3_asisdlsop_d3_i3d, Arm64Mnemonic.LD3, "LD3 { V0.D, V1.D, V2.D }[1], [X2], #24");
        TestInst(LD3(V30.D.Group3()[1], _[X2], 24), asm => asm.LD3(V30.D.Group3()[1], _[X2], 24), Arm64InstructionId.LD3_asisdlsop_d3_i3d, Arm64Mnemonic.LD3, "LD3 { V30.D, V31.D, V0.D }[1], [X2], #24");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD3"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD3_asisdlsop_dx3_r3d_32()
    {
        TestInst(LD3(V0.D.Group3()[1], _[X2], X2), asm => asm.LD3(V0.D.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_dx3_r3d, Arm64Mnemonic.LD3, "LD3 { V0.D, V1.D, V2.D }[1], [X2], X2");
        TestInst(LD3(V30.D.Group3()[1], _[X2], X2), asm => asm.LD3(V30.D.Group3()[1], _[X2], X2), Arm64InstructionId.LD3_asisdlsop_dx3_r3d, Arm64Mnemonic.LD3, "LD3 { V30.D, V31.D, V0.D }[1], [X2], X2");
        TestInst(LD3(V0.D.Group3()[1], _[X2], X17), asm => asm.LD3(V0.D.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_dx3_r3d, Arm64Mnemonic.LD3, "LD3 { V0.D, V1.D, V2.D }[1], [X2], X17");
        TestInst(LD3(V30.D.Group3()[1], _[X2], X17), asm => asm.LD3(V30.D.Group3()[1], _[X2], X17), Arm64InstructionId.LD3_asisdlsop_dx3_r3d, Arm64Mnemonic.LD3, "LD3 { V30.D, V31.D, V0.D }[1], [X2], X17");
    }
}
