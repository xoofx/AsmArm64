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
public class Arm64InstructionFactoryTests_STURH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STURH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STURH_32_ldst_unscaled_0()
    {
        TestInst(STURH(W0, _[X2, 5]), Arm64InstructionId.STURH_32_ldst_unscaled, Arm64Mnemonic.STURH, "STURH W0, [X2, #5]");
        TestInst(STURH(W15, _[X2, 5]), Arm64InstructionId.STURH_32_ldst_unscaled, Arm64Mnemonic.STURH, "STURH W15, [X2, #5]");
        TestInst(STURH(WZR, _[X2, 5]), Arm64InstructionId.STURH_32_ldst_unscaled, Arm64Mnemonic.STURH, "STURH WZR, [X2, #5]");
    }
}
