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
public class Arm64InstructionFactoryTests_FRINT64Z_Float : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINT64Z"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINT64Z_s_floatdp1_0()
    {
        TestInst(FRINT64Z(S0, S1), Arm64InstructionId.FRINT64Z_s_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z S0, S1");
        TestInst(FRINT64Z(S31, S1), Arm64InstructionId.FRINT64Z_s_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z S31, S1");
        TestInst(FRINT64Z(S0, S31), Arm64InstructionId.FRINT64Z_s_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z S0, S31");
        TestInst(FRINT64Z(S31, S31), Arm64InstructionId.FRINT64Z_s_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z S31, S31");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.FRINT64Z"/>.
    /// </summary>
    [TestMethod]
    public void Test_FRINT64Z_d_floatdp1_1()
    {
        TestInst(FRINT64Z(D0, D1), Arm64InstructionId.FRINT64Z_d_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z D0, D1");
        TestInst(FRINT64Z(D31, D1), Arm64InstructionId.FRINT64Z_d_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z D31, D1");
        TestInst(FRINT64Z(D0, D31), Arm64InstructionId.FRINT64Z_d_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z D0, D31");
        TestInst(FRINT64Z(D31, D31), Arm64InstructionId.FRINT64Z_d_floatdp1, Arm64Mnemonic.FRINT64Z, "FRINT64Z D31, D31");
    }
}
