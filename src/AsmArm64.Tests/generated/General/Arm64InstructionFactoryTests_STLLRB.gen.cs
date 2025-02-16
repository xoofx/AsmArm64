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
public class Arm64InstructionFactoryTests_STLLRB_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STLLRB"/>.
    /// </summary>
    [TestMethod]
    public void Test_STLLRB_sl32_ldstord_0()
    {
        TestInst(STLLRB(W0, _[X2]), Arm64InstructionId.STLLRB_sl32_ldstord, Arm64Mnemonic.STLLRB, "STLLRB W0, [X2]");
        TestInst(STLLRB(W15, _[X2]), Arm64InstructionId.STLLRB_sl32_ldstord, Arm64Mnemonic.STLLRB, "STLLRB W15, [X2]");
        TestInst(STLLRB(WZR, _[X2]), Arm64InstructionId.STLLRB_sl32_ldstord, Arm64Mnemonic.STLLRB, "STLLRB WZR, [X2]");
    }
}
