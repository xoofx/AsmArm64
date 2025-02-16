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
namespace AsmArm64.Tests.System;

[TestClass]
public class Arm64InstructionFactoryTests_BTI_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.BTI"/>.
    /// </summary>
    [TestMethod]
    public void Test_BTI_hb_hints_0()
    {
        TestInst(BTI(C), Arm64InstructionId.BTI_hb_hints, Arm64Mnemonic.BTI, "BTI C");
        TestInst(BTI(J), Arm64InstructionId.BTI_hb_hints, Arm64Mnemonic.BTI, "BTI J");
    }
}
