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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STSMINL_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STSMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STSMINL_ldsminl_32_memop_0()
    {
        TestInst(STSMINL(W0, _[X2]), asm => asm.STSMINL(W0, _[X2]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL W0, [X2]");
        TestInst(STSMINL(W15, _[X2]), asm => asm.STSMINL(W15, _[X2]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL W15, [X2]");
        TestInst(STSMINL(WZR, _[X2]), asm => asm.STSMINL(WZR, _[X2]), Arm64InstructionId.STSMINL_ldsminl_32_memop, Arm64Mnemonic.STSMINL, "STSMINL WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STSMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STSMINL_ldsminl_64_memop_1()
    {
        TestInst(STSMINL(X0, _[X2]), asm => asm.STSMINL(X0, _[X2]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL X0, [X2]");
        TestInst(STSMINL(X15, _[X2]), asm => asm.STSMINL(X15, _[X2]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL X15, [X2]");
        TestInst(STSMINL(XZR, _[X2]), asm => asm.STSMINL(XZR, _[X2]), Arm64InstructionId.STSMINL_ldsminl_64_memop, Arm64Mnemonic.STSMINL, "STSMINL XZR, [X2]");
    }
}
