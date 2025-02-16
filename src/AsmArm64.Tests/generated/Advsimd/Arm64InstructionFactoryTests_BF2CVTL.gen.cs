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
public class Arm64InstructionFactoryTests_BF2CVTL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BF2CVTL"/>.
    /// </summary>
    [TestMethod]
    public void Test_BF2CVTL_asimdmisc_v_0()
    {
        TestInst(BF2CVTL(V0.T_8H, V1.T_8B), asm => asm.BF2CVTL(V0.T_8H, V1.T_8B), Arm64InstructionId.BF2CVTL_asimdmisc_v, Arm64Mnemonic.BF2CVTL, "BF2CVTL V0.8H, V1.8B");
        TestInst(BF2CVTL(V30.T_8H, V1.T_8B), asm => asm.BF2CVTL(V30.T_8H, V1.T_8B), Arm64InstructionId.BF2CVTL_asimdmisc_v, Arm64Mnemonic.BF2CVTL, "BF2CVTL V30.8H, V1.8B");
        TestInst(BF2CVTL(V0.T_8H, V31.T_8B), asm => asm.BF2CVTL(V0.T_8H, V31.T_8B), Arm64InstructionId.BF2CVTL_asimdmisc_v, Arm64Mnemonic.BF2CVTL, "BF2CVTL V0.8H, V31.8B");
        TestInst(BF2CVTL(V30.T_8H, V31.T_8B), asm => asm.BF2CVTL(V30.T_8H, V31.T_8B), Arm64InstructionId.BF2CVTL_asimdmisc_v, Arm64Mnemonic.BF2CVTL, "BF2CVTL V30.8H, V31.8B");
    }
}
