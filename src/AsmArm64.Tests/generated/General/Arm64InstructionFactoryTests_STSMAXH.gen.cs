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
public class Arm64InstructionFactoryTests_STSMAXH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STSMAXH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STSMAXH_ldsmaxh_32_memop_0()
    {
        TestInst(STSMAXH(W0, _[X2]), asm => asm.STSMAXH(W0, _[X2]), Arm64InstructionId.STSMAXH_ldsmaxh_32_memop, Arm64Mnemonic.STSMAXH, "STSMAXH W0, [X2]");
        TestInst(STSMAXH(W15, _[X2]), asm => asm.STSMAXH(W15, _[X2]), Arm64InstructionId.STSMAXH_ldsmaxh_32_memop, Arm64Mnemonic.STSMAXH, "STSMAXH W15, [X2]");
        TestInst(STSMAXH(WZR, _[X2]), asm => asm.STSMAXH(WZR, _[X2]), Arm64InstructionId.STSMAXH_ldsmaxh_32_memop, Arm64Mnemonic.STSMAXH, "STSMAXH WZR, [X2]");
    }
}
