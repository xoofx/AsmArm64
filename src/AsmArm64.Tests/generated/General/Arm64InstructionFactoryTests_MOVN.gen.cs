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
public class Arm64InstructionFactoryTests_MOVN_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVN_32_movewide_0()
    {
        TestInst(MOVN(W0, 5, _LSL, 16), asm => asm.MOVN(W0, 5, _LSL, 16), Arm64InstructionId.MOV_movn_32_movewide, Arm64Mnemonic.MOV, "MOV W0, #-327681");
        TestInst(MOVN(W15, 5, _LSL, 16), asm => asm.MOVN(W15, 5, _LSL, 16), Arm64InstructionId.MOV_movn_32_movewide, Arm64Mnemonic.MOV, "MOV W15, #-327681");
        TestInst(MOVN(WZR, 5, _LSL, 16), asm => asm.MOVN(WZR, 5, _LSL, 16), Arm64InstructionId.MOV_movn_32_movewide, Arm64Mnemonic.MOV, "MOV WZR, #-327681");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.MOVN"/>.
    /// </summary>
    [TestMethod]
    public void Test_MOVN_64_movewide_1()
    {
        TestInst(MOVN(X0, 5, _LSL, 16), asm => asm.MOVN(X0, 5, _LSL, 16), Arm64InstructionId.MOV_movn_64_movewide, Arm64Mnemonic.MOV, "MOV X0, #-327681");
        TestInst(MOVN(X15, 5, _LSL, 16), asm => asm.MOVN(X15, 5, _LSL, 16), Arm64InstructionId.MOV_movn_64_movewide, Arm64Mnemonic.MOV, "MOV X15, #-327681");
        TestInst(MOVN(XZR, 5, _LSL, 16), asm => asm.MOVN(XZR, 5, _LSL, 16), Arm64InstructionId.MOV_movn_64_movewide, Arm64Mnemonic.MOV, "MOV XZR, #-327681");
    }
}
