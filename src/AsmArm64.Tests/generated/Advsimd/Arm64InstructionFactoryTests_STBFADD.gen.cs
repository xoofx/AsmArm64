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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_STBFADD_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STBFADD"/>.
    /// </summary>
    [TestMethod]
    public void Test_STBFADD_16_0()
    {
        TestInst(STBFADD(H0, _[X2]), Arm64InstructionId.STBFADD_16, Arm64Mnemonic.STBFADD, "STBFADD H0, [X2]");
        TestInst(STBFADD(H31, _[X2]), Arm64InstructionId.STBFADD_16, Arm64Mnemonic.STBFADD, "STBFADD H31, [X2]");
    }
}
