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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STSET_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STSET"/>.
    /// </summary>
    [TestMethod]
    public void Test_STSET_ldset_32_memop_0()
    {
        TestInst(STSET(W0, _[X2]), Arm64InstructionId.STSET_ldset_32_memop, Arm64Mnemonic.STSET, "STSET W0, [X2]");
        TestInst(STSET(W15, _[X2]), Arm64InstructionId.STSET_ldset_32_memop, Arm64Mnemonic.STSET, "STSET W15, [X2]");
        TestInst(STSET(WZR, _[X2]), Arm64InstructionId.STSET_ldset_32_memop, Arm64Mnemonic.STSET, "STSET WZR, [X2]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STSET"/>.
    /// </summary>
    [TestMethod]
    public void Test_STSET_ldset_64_memop_1()
    {
        TestInst(STSET(X0, _[X2]), Arm64InstructionId.STSET_ldset_64_memop, Arm64Mnemonic.STSET, "STSET X0, [X2]");
        TestInst(STSET(X15, _[X2]), Arm64InstructionId.STSET_ldset_64_memop, Arm64Mnemonic.STSET, "STSET X15, [X2]");
        TestInst(STSET(XZR, _[X2]), Arm64InstructionId.STSET_ldset_64_memop, Arm64Mnemonic.STSET, "STSET XZR, [X2]");
    }
}
