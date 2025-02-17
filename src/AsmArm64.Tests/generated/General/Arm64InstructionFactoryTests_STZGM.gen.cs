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
public class Arm64InstructionFactoryTests_STZGM_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STZGM"/>.
    /// </summary>
    [TestMethod]
    public void Test_STZGM_64bulk_ldsttags_0()
    {
        TestInst(STZGM(X0, _[X2]), asm => asm.STZGM(X0, _[X2]), Arm64InstructionId.STZGM_64bulk_ldsttags, Arm64Mnemonic.STZGM, "STZGM X0, [X2]");
        TestInst(STZGM(X15, _[X2]), asm => asm.STZGM(X15, _[X2]), Arm64InstructionId.STZGM_64bulk_ldsttags, Arm64Mnemonic.STZGM, "STZGM X15, [X2]");
        TestInst(STZGM(XZR, _[X2]), asm => asm.STZGM(XZR, _[X2]), Arm64InstructionId.STZGM_64bulk_ldsttags, Arm64Mnemonic.STZGM, "STZGM XZR, [X2]");
    }
}
