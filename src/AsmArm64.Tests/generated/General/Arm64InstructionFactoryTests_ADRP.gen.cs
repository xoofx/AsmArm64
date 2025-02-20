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
public class Arm64InstructionFactoryTests_ADRP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.ADRP"/>.
    /// </summary>
    [TestMethod]
    public void Test_ADRP_only_pcreladdr_0()
    {
        TestInst(ADRP(X0, 12288), null, Arm64InstructionId.ADRP_only_pcreladdr, Arm64Mnemonic.ADRP, "ADRP X0, #12288");
        TestInst(ADRP(X15, 12288), null, Arm64InstructionId.ADRP_only_pcreladdr, Arm64Mnemonic.ADRP, "ADRP X15, #12288");
        TestInst(ADRP(XZR, 12288), null, Arm64InstructionId.ADRP_only_pcreladdr, Arm64Mnemonic.ADRP, "ADRP XZR, #12288");
    }
}
