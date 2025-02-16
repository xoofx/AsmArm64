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
namespace AsmArm64.Tests.Float;

[TestClass]
public class Arm64InstructionFactoryTests_FCCMPE_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMPE_h_floatccmp_0()
    {
        TestInst(FCCMPE(H0, H1, 5, NE), asm => asm.FCCMPE(H0, H1, 5, NE), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H0, H1, #5, NE");
        TestInst(FCCMPE(H31, H1, 5, NE), asm => asm.FCCMPE(H31, H1, 5, NE), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H31, H1, #5, NE");
        TestInst(FCCMPE(H0, H31, 5, NE), asm => asm.FCCMPE(H0, H31, 5, NE), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H0, H31, #5, NE");
        TestInst(FCCMPE(H31, H31, 5, NE), asm => asm.FCCMPE(H31, H31, 5, NE), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H31, H31, #5, NE");
        TestInst(FCCMPE(H0, H1, 5, HS), asm => asm.FCCMPE(H0, H1, 5, HS), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H0, H1, #5, HS");
        TestInst(FCCMPE(H31, H1, 5, HS), asm => asm.FCCMPE(H31, H1, 5, HS), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H31, H1, #5, HS");
        TestInst(FCCMPE(H0, H31, 5, HS), asm => asm.FCCMPE(H0, H31, 5, HS), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H0, H31, #5, HS");
        TestInst(FCCMPE(H31, H31, 5, HS), asm => asm.FCCMPE(H31, H31, 5, HS), Arm64InstructionId.FCCMPE_h_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE H31, H31, #5, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMPE_s_floatccmp_1()
    {
        TestInst(FCCMPE(S0, S1, 5, NE), asm => asm.FCCMPE(S0, S1, 5, NE), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S0, S1, #5, NE");
        TestInst(FCCMPE(S31, S1, 5, NE), asm => asm.FCCMPE(S31, S1, 5, NE), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S31, S1, #5, NE");
        TestInst(FCCMPE(S0, S31, 5, NE), asm => asm.FCCMPE(S0, S31, 5, NE), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S0, S31, #5, NE");
        TestInst(FCCMPE(S31, S31, 5, NE), asm => asm.FCCMPE(S31, S31, 5, NE), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S31, S31, #5, NE");
        TestInst(FCCMPE(S0, S1, 5, HS), asm => asm.FCCMPE(S0, S1, 5, HS), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S0, S1, #5, HS");
        TestInst(FCCMPE(S31, S1, 5, HS), asm => asm.FCCMPE(S31, S1, 5, HS), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S31, S1, #5, HS");
        TestInst(FCCMPE(S0, S31, 5, HS), asm => asm.FCCMPE(S0, S31, 5, HS), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S0, S31, #5, HS");
        TestInst(FCCMPE(S31, S31, 5, HS), asm => asm.FCCMPE(S31, S31, 5, HS), Arm64InstructionId.FCCMPE_s_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE S31, S31, #5, HS");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FCCMPE"/>.
    /// </summary>
    [TestMethod]
    public void Test_FCCMPE_d_floatccmp_2()
    {
        TestInst(FCCMPE(D0, D1, 5, NE), asm => asm.FCCMPE(D0, D1, 5, NE), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D0, D1, #5, NE");
        TestInst(FCCMPE(D31, D1, 5, NE), asm => asm.FCCMPE(D31, D1, 5, NE), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D31, D1, #5, NE");
        TestInst(FCCMPE(D0, D31, 5, NE), asm => asm.FCCMPE(D0, D31, 5, NE), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D0, D31, #5, NE");
        TestInst(FCCMPE(D31, D31, 5, NE), asm => asm.FCCMPE(D31, D31, 5, NE), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D31, D31, #5, NE");
        TestInst(FCCMPE(D0, D1, 5, HS), asm => asm.FCCMPE(D0, D1, 5, HS), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D0, D1, #5, HS");
        TestInst(FCCMPE(D31, D1, 5, HS), asm => asm.FCCMPE(D31, D1, 5, HS), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D31, D1, #5, HS");
        TestInst(FCCMPE(D0, D31, 5, HS), asm => asm.FCCMPE(D0, D31, 5, HS), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D0, D31, #5, HS");
        TestInst(FCCMPE(D31, D31, 5, HS), asm => asm.FCCMPE(D31, D31, 5, HS), Arm64InstructionId.FCCMPE_d_floatccmp, Arm64Mnemonic.FCCMPE, "FCCMPE D31, D31, #5, HS");
    }
}
