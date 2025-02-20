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
public class Arm64InstructionFactoryTests_CASAB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASAB"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASAB_c32_comswap_0()
    {
        TestInst(CASAB(W0, W1, _[X3]), asm => asm.CASAB(W0, W1, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W0, W1, [X3]");
        TestInst(CASAB(W15, W1, _[X3]), asm => asm.CASAB(W15, W1, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W15, W1, [X3]");
        TestInst(CASAB(WZR, W1, _[X3]), asm => asm.CASAB(WZR, W1, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB WZR, W1, [X3]");
        TestInst(CASAB(W0, W16, _[X3]), asm => asm.CASAB(W0, W16, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W0, W16, [X3]");
        TestInst(CASAB(W15, W16, _[X3]), asm => asm.CASAB(W15, W16, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W15, W16, [X3]");
        TestInst(CASAB(WZR, W16, _[X3]), asm => asm.CASAB(WZR, W16, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB WZR, W16, [X3]");
        TestInst(CASAB(W0, WZR, _[X3]), asm => asm.CASAB(W0, WZR, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W0, WZR, [X3]");
        TestInst(CASAB(W15, WZR, _[X3]), asm => asm.CASAB(W15, WZR, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB W15, WZR, [X3]");
        TestInst(CASAB(WZR, WZR, _[X3]), asm => asm.CASAB(WZR, WZR, _[X3]), Arm64InstructionId.CASAB_c32_comswap, Arm64Mnemonic.CASAB, "CASAB WZR, WZR, [X3]");
    }
}
