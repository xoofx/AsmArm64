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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FCCMP_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMP_h_floatccmp_0()
    {
        TestInst(FCCMP(H0, H1, 5, NE), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H0, H1, #5, NE");
        TestInst(FCCMP(H31, H1, 5, NE), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H31, H1, #5, NE");
        TestInst(FCCMP(H0, H31, 5, NE), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H0, H31, #5, NE");
        TestInst(FCCMP(H31, H31, 5, NE), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H31, H31, #5, NE");
        TestInst(FCCMP(H0, H1, 5, HS), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H0, H1, #5, HS");
        TestInst(FCCMP(H31, H1, 5, HS), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H31, H1, #5, HS");
        TestInst(FCCMP(H0, H31, 5, HS), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H0, H31, #5, HS");
        TestInst(FCCMP(H31, H31, 5, HS), Arm64InstructionId.FCCMP_h_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP H31, H31, #5, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMP_s_floatccmp_1()
    {
        TestInst(FCCMP(S0, S1, 5, NE), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S0, S1, #5, NE");
        TestInst(FCCMP(S31, S1, 5, NE), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S31, S1, #5, NE");
        TestInst(FCCMP(S0, S31, 5, NE), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S0, S31, #5, NE");
        TestInst(FCCMP(S31, S31, 5, NE), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S31, S31, #5, NE");
        TestInst(FCCMP(S0, S1, 5, HS), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S0, S1, #5, HS");
        TestInst(FCCMP(S31, S1, 5, HS), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S31, S1, #5, HS");
        TestInst(FCCMP(S0, S31, 5, HS), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S0, S31, #5, HS");
        TestInst(FCCMP(S31, S31, 5, HS), Arm64InstructionId.FCCMP_s_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP S31, S31, #5, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMP"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMP_d_floatccmp_2()
    {
        TestInst(FCCMP(D0, D1, 5, NE), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D0, D1, #5, NE");
        TestInst(FCCMP(D31, D1, 5, NE), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D31, D1, #5, NE");
        TestInst(FCCMP(D0, D31, 5, NE), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D0, D31, #5, NE");
        TestInst(FCCMP(D31, D31, 5, NE), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D31, D31, #5, NE");
        TestInst(FCCMP(D0, D1, 5, HS), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D0, D1, #5, HS");
        TestInst(FCCMP(D31, D1, 5, HS), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D31, D1, #5, HS");
        TestInst(FCCMP(D0, D31, 5, HS), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D0, D31, #5, HS");
        TestInst(FCCMP(D31, D31, 5, HS), Arm64InstructionId.FCCMP_d_floatccmp, Arm64Mnemonic.FCCMP, "FCCMP D31, D31, #5, HS");
    }
}
