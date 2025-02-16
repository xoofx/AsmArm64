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
namespace AsmArm64.Tests.Advsimd;

[TestClass]
public class Arm64InstructionFactoryTests_STBFMINL_Advsimd : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STBFMINL"/>.
    /// </summary>
    [TestMethod]
    public void Test_STBFMINL_16_0()
    {
        TestInst(STBFMINL(H0, _[X2]), asm => asm.STBFMINL(H0, _[X2]), Arm64InstructionId.STBFMINL_16, Arm64Mnemonic.STBFMINL, "STBFMINL H0, [X2]");
        TestInst(STBFMINL(H31, _[X2]), asm => asm.STBFMINL(H31, _[X2]), Arm64InstructionId.STBFMINL_16, Arm64Mnemonic.STBFMINL, "STBFMINL H31, [X2]");
    }
}
