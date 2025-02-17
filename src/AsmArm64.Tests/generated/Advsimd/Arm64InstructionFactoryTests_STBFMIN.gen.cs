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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_STBFMIN_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STBFMIN"/>.
    /// </summary>
    [TestMethod]
    public void Test_STBFMIN_16_0()
    {
        TestInst(STBFMIN(H0, _[X2]), asm => asm.STBFMIN(H0, _[X2]), Arm64InstructionId.STBFMIN_16, Arm64Mnemonic.STBFMIN, "STBFMIN H0, [X2]");
        TestInst(STBFMIN(H31, _[X2]), asm => asm.STBFMIN(H31, _[X2]), Arm64InstructionId.STBFMIN_16, Arm64Mnemonic.STBFMIN, "STBFMIN H31, [X2]");
    }
}
