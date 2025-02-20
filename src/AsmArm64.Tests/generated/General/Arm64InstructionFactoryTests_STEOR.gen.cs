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
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
using static AsmArm64.Arm64InstructionFactory;
using static AsmArm64.Arm64Factory;
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STEOR_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEOR_ldeor_32_memop_0()
    {
        TestInst(STEOR(W0, _[X2]), asm => asm.STEOR(W0, _[X2]), Arm64InstructionId.STEOR_ldeor_32_memop, Arm64Mnemonic.STEOR, "STEOR W0, [X2]");
        TestInst(STEOR(W15, _[X2]), asm => asm.STEOR(W15, _[X2]), Arm64InstructionId.STEOR_ldeor_32_memop, Arm64Mnemonic.STEOR, "STEOR W15, [X2]");
        TestInst(STEOR(WZR, _[X2]), asm => asm.STEOR(WZR, _[X2]), Arm64InstructionId.STEOR_ldeor_32_memop, Arm64Mnemonic.STEOR, "STEOR WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEOR"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEOR_ldeor_64_memop_1()
    {
        TestInst(STEOR(X0, _[X2]), asm => asm.STEOR(X0, _[X2]), Arm64InstructionId.STEOR_ldeor_64_memop, Arm64Mnemonic.STEOR, "STEOR X0, [X2]");
        TestInst(STEOR(X15, _[X2]), asm => asm.STEOR(X15, _[X2]), Arm64InstructionId.STEOR_ldeor_64_memop, Arm64Mnemonic.STEOR, "STEOR X15, [X2]");
        TestInst(STEOR(XZR, _[X2]), asm => asm.STEOR(XZR, _[X2]), Arm64InstructionId.STEOR_ldeor_64_memop, Arm64Mnemonic.STEOR, "STEOR XZR, [X2]");
    }
}
