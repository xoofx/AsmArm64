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
namespace AsmArm64.Tests.General;

[TestClass]
public class Arm64InstructionFactoryTests_STEORLH_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.STEORLH"/>.
    /// </summary>
    [TestMethod]
    public void Test_STEORLH_ldeorlh_32_memop_0()
    {
        TestInst(STEORLH(W0, _[X2]), asm => asm.STEORLH(W0, _[X2]), Arm64InstructionId.STEORLH_ldeorlh_32_memop, Arm64Mnemonic.STEORLH, "STEORLH W0, [X2]");
        TestInst(STEORLH(W15, _[X2]), asm => asm.STEORLH(W15, _[X2]), Arm64InstructionId.STEORLH_ldeorlh_32_memop, Arm64Mnemonic.STEORLH, "STEORLH W15, [X2]");
        TestInst(STEORLH(WZR, _[X2]), asm => asm.STEORLH(WZR, _[X2]), Arm64InstructionId.STEORLH_ldeorlh_32_memop, Arm64Mnemonic.STEORLH, "STEORLH WZR, [X2]");
    }
}
