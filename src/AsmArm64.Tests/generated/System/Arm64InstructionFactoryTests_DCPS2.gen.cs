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
public class Arm64InstructionFactoryTests_DCPS2_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.DCPS2"/>.
    /// </summary>
    [TestMethod]
    public void Test_DCPS2_dc_exception_0()
    {
        TestInst(DCPS2(5), Arm64InstructionId.DCPS2_dc_exception, Arm64Mnemonic.DCPS2, "DCPS2 #5");
    }
}
