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
public class Arm64InstructionFactoryTests_TSTART_System : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TSTART"/>.
    /// </summary>
    [TestMethod]
    public void Test_TSTART_br_systemresult_0()
    {
        TestInst(TSTART(X0), Arm64InstructionId.TSTART_br_systemresult, Arm64Mnemonic.TSTART, "TSTART X0");
        TestInst(TSTART(X15), Arm64InstructionId.TSTART_br_systemresult, Arm64Mnemonic.TSTART, "TSTART X15");
        TestInst(TSTART(XZR), Arm64InstructionId.TSTART_br_systemresult, Arm64Mnemonic.TSTART, "TSTART XZR");
    }
}
