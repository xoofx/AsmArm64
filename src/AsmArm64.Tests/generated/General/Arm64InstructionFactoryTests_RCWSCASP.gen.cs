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
public class Arm64InstructionFactoryTests_RCWSCASP_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.RCWSCASP"/>.
    /// </summary>
    [TestMethod]
    public void Test_RCWSCASP_c64_rcwcomswappr_0()
    {
        TestInst(RCWSCASP(X0, X1, X2, X3, _[X5]), asm => asm.RCWSCASP(X0, X1, X2, X3, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X0, X1, X2, X3, [X5]");
        TestInst(RCWSCASP(X15, X16, X2, X3, _[X5]), asm => asm.RCWSCASP(X15, X16, X2, X3, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X15, X16, X2, X3, [X5]");
        TestInst(RCWSCASP(XZR, X0, X2, X3, _[X5]), asm => asm.RCWSCASP(XZR, X0, X2, X3, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP XZR, X0, X2, X3, [X5]");
        TestInst(RCWSCASP(X0, X1, X17, X18, _[X5]), asm => asm.RCWSCASP(X0, X1, X17, X18, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X0, X1, X17, X18, [X5]");
        TestInst(RCWSCASP(X15, X16, X17, X18, _[X5]), asm => asm.RCWSCASP(X15, X16, X17, X18, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X15, X16, X17, X18, [X5]");
        TestInst(RCWSCASP(XZR, X0, X17, X18, _[X5]), asm => asm.RCWSCASP(XZR, X0, X17, X18, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP XZR, X0, X17, X18, [X5]");
        TestInst(RCWSCASP(X0, X1, XZR, X0, _[X5]), asm => asm.RCWSCASP(X0, X1, XZR, X0, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X0, X1, XZR, X0, [X5]");
        TestInst(RCWSCASP(X15, X16, XZR, X0, _[X5]), asm => asm.RCWSCASP(X15, X16, XZR, X0, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP X15, X16, XZR, X0, [X5]");
        TestInst(RCWSCASP(XZR, X0, XZR, X0, _[X5]), asm => asm.RCWSCASP(XZR, X0, XZR, X0, _[X5]), Arm64InstructionId.RCWSCASP_c64_rcwcomswappr, Arm64Mnemonic.RCWSCASP, "RCWSCASP XZR, X0, XZR, X0, [X5]");
    }
}
