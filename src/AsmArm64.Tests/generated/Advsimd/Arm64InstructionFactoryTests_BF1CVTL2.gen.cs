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
public class Arm64InstructionFactoryTests_BF1CVTL2_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BF1CVTL2"/>.
    /// </summary>
    [TestMethod]
    public void Test_BF1CVTL2_asimdmisc_v_0()
    {
        TestInst(BF1CVTL2(V0.T_8H, V1.T_16B), asm => asm.BF1CVTL2(V0.T_8H, V1.T_16B), Arm64InstructionId.BF1CVTL2_asimdmisc_v, Arm64Mnemonic.BF1CVTL2, "BF1CVTL2 V0.8H, V1.16B");
        TestInst(BF1CVTL2(V30.T_8H, V1.T_16B), asm => asm.BF1CVTL2(V30.T_8H, V1.T_16B), Arm64InstructionId.BF1CVTL2_asimdmisc_v, Arm64Mnemonic.BF1CVTL2, "BF1CVTL2 V30.8H, V1.16B");
        TestInst(BF1CVTL2(V0.T_8H, V31.T_16B), asm => asm.BF1CVTL2(V0.T_8H, V31.T_16B), Arm64InstructionId.BF1CVTL2_asimdmisc_v, Arm64Mnemonic.BF1CVTL2, "BF1CVTL2 V0.8H, V31.16B");
        TestInst(BF1CVTL2(V30.T_8H, V31.T_16B), asm => asm.BF1CVTL2(V30.T_8H, V31.T_16B), Arm64InstructionId.BF1CVTL2_asimdmisc_v, Arm64Mnemonic.BF1CVTL2, "BF1CVTL2 V30.8H, V31.16B");
    }
}
