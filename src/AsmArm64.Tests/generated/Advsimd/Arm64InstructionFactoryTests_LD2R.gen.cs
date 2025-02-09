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
public class Arm64InstructionFactoryTests_LD2R_Advsimd
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_0()
    {
        
        {
            var raw = LD2R(V0.T_8B.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8B, V1.8B }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_8B.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8B, V31.8B }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_1()
    {
        
        {
            var raw = LD2R(V0.T_16B.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.16B, V1.16B }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_16B.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.16B, V31.16B }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_2()
    {
        
        {
            var raw = LD2R(V0.T_4H.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4H, V1.4H }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_4H.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4H, V31.4H }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_3()
    {
        
        {
            var raw = LD2R(V0.T_8H.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8H, V1.8H }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_8H.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8H, V31.8H }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_4()
    {
        
        {
            var raw = LD2R(V0.T_2S.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2S, V1.2S }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_2S.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2S, V31.2S }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_5()
    {
        
        {
            var raw = LD2R(V0.T_4S.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4S, V1.4S }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_4S.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4S, V31.4S }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_6()
    {
        
        {
            var raw = LD2R(V0.T_1D.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.1D, V1.1D }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_1D.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.1D, V31.1D }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlso_r2_7()
    {
        
        {
            var raw = LD2R(V0.T_2D.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2D, V1.2D }, [X2]", asm);
        }
        
        {
            var raw = LD2R(V30.T_2D.Group2(), _[X2]);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlso_r2, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2D, V31.2D }, [X2]", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_8()
    {
        
        {
            var raw = LD2R(V0.T_8B.Group2(), _[X2], 2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8B, V1.8B }, [X2], #2", asm);
        }
        
        {
            var raw = LD2R(V30.T_8B.Group2(), _[X2], 2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8B, V31.8B }, [X2], #2", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_9()
    {
        
        {
            var raw = LD2R(V0.T_16B.Group2(), _[X2], 2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.16B, V1.16B }, [X2], #2", asm);
        }
        
        {
            var raw = LD2R(V30.T_16B.Group2(), _[X2], 2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.16B, V31.16B }, [X2], #2", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_10()
    {
        
        {
            var raw = LD2R(V0.T_4H.Group2(), _[X2], 4);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4H, V1.4H }, [X2], #4", asm);
        }
        
        {
            var raw = LD2R(V30.T_4H.Group2(), _[X2], 4);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4H, V31.4H }, [X2], #4", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_11()
    {
        
        {
            var raw = LD2R(V0.T_8H.Group2(), _[X2], 4);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8H, V1.8H }, [X2], #4", asm);
        }
        
        {
            var raw = LD2R(V30.T_8H.Group2(), _[X2], 4);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8H, V31.8H }, [X2], #4", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_12()
    {
        
        {
            var raw = LD2R(V0.T_2S.Group2(), _[X2], 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2S, V1.2S }, [X2], #8", asm);
        }
        
        {
            var raw = LD2R(V30.T_2S.Group2(), _[X2], 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2S, V31.2S }, [X2], #8", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_13()
    {
        
        {
            var raw = LD2R(V0.T_4S.Group2(), _[X2], 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4S, V1.4S }, [X2], #8", asm);
        }
        
        {
            var raw = LD2R(V30.T_4S.Group2(), _[X2], 8);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4S, V31.4S }, [X2], #8", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_14()
    {
        
        {
            var raw = LD2R(V0.T_1D.Group2(), _[X2], 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.1D, V1.1D }, [X2], #16", asm);
        }
        
        {
            var raw = LD2R(V30.T_1D.Group2(), _[X2], 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.1D, V31.1D }, [X2], #16", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_r2_i_15()
    {
        
        {
            var raw = LD2R(V0.T_2D.Group2(), _[X2], 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2D, V1.2D }, [X2], #16", asm);
        }
        
        {
            var raw = LD2R(V30.T_2D.Group2(), _[X2], 16);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_r2_i, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2D, V31.2D }, [X2], #16", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_16()
    {
        
        {
            var raw = LD2R(V0.T_8B.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8B, V1.8B }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_8B.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8B, V31.8B }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_8B.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8B, V1.8B }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_8B.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8B, V31.8B }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_17()
    {
        
        {
            var raw = LD2R(V0.T_16B.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.16B, V1.16B }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_16B.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.16B, V31.16B }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_16B.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.16B, V1.16B }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_16B.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.16B, V31.16B }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_18()
    {
        
        {
            var raw = LD2R(V0.T_4H.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4H, V1.4H }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_4H.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4H, V31.4H }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_4H.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4H, V1.4H }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_4H.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4H, V31.4H }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_19()
    {
        
        {
            var raw = LD2R(V0.T_8H.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8H, V1.8H }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_8H.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8H, V31.8H }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_8H.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.8H, V1.8H }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_8H.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.8H, V31.8H }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_20()
    {
        
        {
            var raw = LD2R(V0.T_2S.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2S, V1.2S }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_2S.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2S, V31.2S }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_2S.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2S, V1.2S }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_2S.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2S, V31.2S }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_21()
    {
        
        {
            var raw = LD2R(V0.T_4S.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4S, V1.4S }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_4S.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4S, V31.4S }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_4S.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.4S, V1.4S }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_4S.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.4S, V31.4S }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_22()
    {
        
        {
            var raw = LD2R(V0.T_1D.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.1D, V1.1D }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_1D.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.1D, V31.1D }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_1D.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.1D, V1.1D }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_1D.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.1D, V31.1D }, [X2], X17", asm);
        }
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.LD2R"/>.
    /// </summary>
    [TestMethod]
    public void Test_LD2R_asisdlsop_rx2_r_23()
    {
        
        {
            var raw = LD2R(V0.T_2D.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2D, V1.2D }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V30.T_2D.Group2(), _[X2], X2);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2D, V31.2D }, [X2], X2", asm);
        }
        
        {
            var raw = LD2R(V0.T_2D.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V0.2D, V1.2D }, [X2], X17", asm);
        }
        
        {
            var raw = LD2R(V30.T_2D.Group2(), _[X2], X17);
            var instruction = Arm64Instruction.Decode(raw);
            Assert.AreEqual(Arm64InstructionId.LD2R_asisdlsop_rx2_r, instruction.Id);
            Assert.AreEqual(Arm64Mnemonic.LD2R, instruction.Mnemonic);
            var asm = instruction.ToString("H", null);
            Assert.AreEqual("LD2R { V30.2D, V31.2D }, [X2], X17", asm);
        }
    }
}
