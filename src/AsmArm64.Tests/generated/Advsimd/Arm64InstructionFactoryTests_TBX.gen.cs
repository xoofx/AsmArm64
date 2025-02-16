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
public class Arm64InstructionFactoryTests_TBX_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l1_1_0()
    {
        TestInst(TBX(V0.T_8B, V1.T_16B.Group1(), V2.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group1(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group1(), V2.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group1(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group1(), V2.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group1(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group1(), V2.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group1(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V1.T_16B.Group1(), V0.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group1(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group1(), V0.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group1(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B }, V0.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group1(), V0.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group1(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group1(), V0.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group1(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B }, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l1_1_1()
    {
        TestInst(TBX(V0.T_16B, V1.T_16B.Group1(), V2.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group1(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group1(), V2.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group1(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group1(), V2.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group1(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group1(), V2.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group1(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V1.T_16B.Group1(), V0.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group1(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group1(), V0.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group1(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B }, V0.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group1(), V0.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group1(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group1(), V0.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group1(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l1_1, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B }, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l2_2_2()
    {
        TestInst(TBX(V0.T_8B, V1.T_16B.Group2(), V2.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group2(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group2(), V2.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group2(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group2(), V2.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group2(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group2(), V2.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group2(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V1.T_16B.Group2(), V0.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group2(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group2(), V0.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group2(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B }, V0.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group2(), V0.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group2(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group2(), V0.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group2(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B }, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l2_2_3()
    {
        TestInst(TBX(V0.T_16B, V1.T_16B.Group2(), V2.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group2(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group2(), V2.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group2(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group2(), V2.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group2(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group2(), V2.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group2(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V1.T_16B.Group2(), V0.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group2(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group2(), V0.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group2(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B }, V0.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group2(), V0.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group2(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group2(), V0.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group2(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l2_2, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B }, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l3_3_4()
    {
        TestInst(TBX(V0.T_8B, V1.T_16B.Group3(), V2.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group3(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B, V3.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group3(), V2.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group3(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B, V3.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group3(), V2.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group3(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B, V1.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group3(), V2.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group3(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B, V1.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V1.T_16B.Group3(), V0.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group3(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B, V3.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group3(), V0.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group3(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B, V3.16B }, V0.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group3(), V0.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group3(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B, V1.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group3(), V0.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group3(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B, V1.16B }, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l3_3_5()
    {
        TestInst(TBX(V0.T_16B, V1.T_16B.Group3(), V2.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group3(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B, V3.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group3(), V2.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group3(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B, V3.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group3(), V2.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group3(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B, V1.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group3(), V2.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group3(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B, V1.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V1.T_16B.Group3(), V0.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group3(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B, V3.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group3(), V0.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group3(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B, V3.16B }, V0.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group3(), V0.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group3(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B, V1.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group3(), V0.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group3(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l3_3, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B, V1.16B }, V0.16B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l4_4_6()
    {
        TestInst(TBX(V0.T_8B, V1.T_16B.Group4(), V2.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group4(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B, V3.16B, V4.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group4(), V2.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group4(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B, V3.16B, V4.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group4(), V2.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group4(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B, V1.16B, V2.16B }, V2.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group4(), V2.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group4(), V2.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B, V1.16B, V2.16B }, V2.8B");
        TestInst(TBX(V0.T_8B, V1.T_16B.Group4(), V0.T_8B), asm => asm.TBX(V0.T_8B, V1.T_16B.Group4(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.8B, { V1.16B, V2.16B, V3.16B, V4.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V1.T_16B.Group4(), V0.T_8B), asm => asm.TBX(V30.T_8B, V1.T_16B.Group4(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.8B, { V1.16B, V2.16B, V3.16B, V4.16B }, V0.8B");
        TestInst(TBX(V0.T_8B, V31.T_16B.Group4(), V0.T_8B), asm => asm.TBX(V0.T_8B, V31.T_16B.Group4(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.8B, { V31.16B, V0.16B, V1.16B, V2.16B }, V0.8B");
        TestInst(TBX(V30.T_8B, V31.T_16B.Group4(), V0.T_8B), asm => asm.TBX(V30.T_8B, V31.T_16B.Group4(), V0.T_8B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.8B, { V31.16B, V0.16B, V1.16B, V2.16B }, V0.8B");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TBX"/>.
    /// </summary>
    [TestMethod]
    public void Test_TBX_asimdtbl_l4_4_7()
    {
        TestInst(TBX(V0.T_16B, V1.T_16B.Group4(), V2.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group4(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B, V3.16B, V4.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group4(), V2.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group4(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B, V3.16B, V4.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group4(), V2.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group4(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B, V1.16B, V2.16B }, V2.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group4(), V2.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group4(), V2.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B, V1.16B, V2.16B }, V2.16B");
        TestInst(TBX(V0.T_16B, V1.T_16B.Group4(), V0.T_16B), asm => asm.TBX(V0.T_16B, V1.T_16B.Group4(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.16B, { V1.16B, V2.16B, V3.16B, V4.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V1.T_16B.Group4(), V0.T_16B), asm => asm.TBX(V30.T_16B, V1.T_16B.Group4(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.16B, { V1.16B, V2.16B, V3.16B, V4.16B }, V0.16B");
        TestInst(TBX(V0.T_16B, V31.T_16B.Group4(), V0.T_16B), asm => asm.TBX(V0.T_16B, V31.T_16B.Group4(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V0.16B, { V31.16B, V0.16B, V1.16B, V2.16B }, V0.16B");
        TestInst(TBX(V30.T_16B, V31.T_16B.Group4(), V0.T_16B), asm => asm.TBX(V30.T_16B, V31.T_16B.Group4(), V0.T_16B), Arm64InstructionId.TBX_asimdtbl_l4_4, Arm64Mnemonic.TBX, "TBX V30.16B, { V31.16B, V0.16B, V1.16B, V2.16B }, V0.16B");
    }
}
