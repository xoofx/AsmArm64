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
public class Arm64InstructionFactoryTests_MOVK_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVK"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVK_32_movewide_0()
    {
        TestInst(MOVK(W0, 5, _LSL, 16), Arm64InstructionId.MOVK_32_movewide, Arm64Mnemonic.MOVK, "MOVK W0, #5, LSL #16");
        TestInst(MOVK(W15, 5, _LSL, 16), Arm64InstructionId.MOVK_32_movewide, Arm64Mnemonic.MOVK, "MOVK W15, #5, LSL #16");
        TestInst(MOVK(WZR, 5, _LSL, 16), Arm64InstructionId.MOVK_32_movewide, Arm64Mnemonic.MOVK, "MOVK WZR, #5, LSL #16");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVK"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVK_64_movewide_1()
    {
        TestInst(MOVK(X0, 5, _LSL, 16), Arm64InstructionId.MOVK_64_movewide, Arm64Mnemonic.MOVK, "MOVK X0, #5, LSL #16");
        TestInst(MOVK(X15, 5, _LSL, 16), Arm64InstructionId.MOVK_64_movewide, Arm64Mnemonic.MOVK, "MOVK X15, #5, LSL #16");
        TestInst(MOVK(XZR, 5, _LSL, 16), Arm64InstructionId.MOVK_64_movewide, Arm64Mnemonic.MOVK, "MOVK XZR, #5, LSL #16");
    }
}
