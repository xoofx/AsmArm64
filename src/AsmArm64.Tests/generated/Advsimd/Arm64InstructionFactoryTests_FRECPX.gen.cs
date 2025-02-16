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
public class Arm64InstructionFactoryTests_FRECPX_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRECPX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRECPX_asisdmiscfp16_r_0()
    {
        TestInst(FRECPX(H0, H1), asm => asm.FRECPX(H0, H1), Arm64InstructionId.FRECPX_asisdmiscfp16_r, Arm64Mnemonic.FRECPX, "FRECPX H0, H1");
        TestInst(FRECPX(H31, H1), asm => asm.FRECPX(H31, H1), Arm64InstructionId.FRECPX_asisdmiscfp16_r, Arm64Mnemonic.FRECPX, "FRECPX H31, H1");
        TestInst(FRECPX(H0, H31), asm => asm.FRECPX(H0, H31), Arm64InstructionId.FRECPX_asisdmiscfp16_r, Arm64Mnemonic.FRECPX, "FRECPX H0, H31");
        TestInst(FRECPX(H31, H31), asm => asm.FRECPX(H31, H31), Arm64InstructionId.FRECPX_asisdmiscfp16_r, Arm64Mnemonic.FRECPX, "FRECPX H31, H31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRECPX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRECPX_asisdmisc_r_1()
    {
        TestInst(FRECPX(S1, S2), asm => asm.FRECPX(S1, S2), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX S1, S2");
        TestInst(FRECPX(S31, S2), asm => asm.FRECPX(S31, S2), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX S31, S2");
        TestInst(FRECPX(S1, S0), asm => asm.FRECPX(S1, S0), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX S1, S0");
        TestInst(FRECPX(S31, S0), asm => asm.FRECPX(S31, S0), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX S31, S0");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRECPX"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRECPX_asisdmisc_r_2()
    {
        TestInst(FRECPX(D1, D2), asm => asm.FRECPX(D1, D2), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX D1, D2");
        TestInst(FRECPX(D31, D2), asm => asm.FRECPX(D31, D2), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX D31, D2");
        TestInst(FRECPX(D1, D0), asm => asm.FRECPX(D1, D0), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX D1, D0");
        TestInst(FRECPX(D31, D0), asm => asm.FRECPX(D31, D0), Arm64InstructionId.FRECPX_asisdmisc_r, Arm64Mnemonic.FRECPX, "FRECPX D31, D0");
    }
}
