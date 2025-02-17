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
public class Arm64InstructionFactoryTests_CASALB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASALB"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASALB_c32_comswap_0()
    {
        TestInst(CASALB(W0, W1, _[X3]), asm => asm.CASALB(W0, W1, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W0, W1, [X3]");
        TestInst(CASALB(W15, W1, _[X3]), asm => asm.CASALB(W15, W1, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W15, W1, [X3]");
        TestInst(CASALB(WZR, W1, _[X3]), asm => asm.CASALB(WZR, W1, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB WZR, W1, [X3]");
        TestInst(CASALB(W0, W16, _[X3]), asm => asm.CASALB(W0, W16, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W0, W16, [X3]");
        TestInst(CASALB(W15, W16, _[X3]), asm => asm.CASALB(W15, W16, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W15, W16, [X3]");
        TestInst(CASALB(WZR, W16, _[X3]), asm => asm.CASALB(WZR, W16, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB WZR, W16, [X3]");
        TestInst(CASALB(W0, WZR, _[X3]), asm => asm.CASALB(W0, WZR, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W0, WZR, [X3]");
        TestInst(CASALB(W15, WZR, _[X3]), asm => asm.CASALB(W15, WZR, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB W15, WZR, [X3]");
        TestInst(CASALB(WZR, WZR, _[X3]), asm => asm.CASALB(WZR, WZR, _[X3]), Arm64InstructionId.CASALB_c32_comswap, Arm64Mnemonic.CASALB, "CASALB WZR, WZR, [X3]");
    }
}
