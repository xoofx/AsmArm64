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
public class Arm64InstructionFactoryTests_CASPAT_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASPAT"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASPAT_cp64_comswappr_unpriv_0()
    {
        TestInst(CASPAT(X0, X1, X2, X3, _[X5]), asm => asm.CASPAT(X0, X1, X2, X3, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X0, X1, X2, X3, [X5]");
        TestInst(CASPAT(X15, X16, X2, X3, _[X5]), asm => asm.CASPAT(X15, X16, X2, X3, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X15, X16, X2, X3, [X5]");
        TestInst(CASPAT(XZR, X0, X2, X3, _[X5]), asm => asm.CASPAT(XZR, X0, X2, X3, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT XZR, X0, X2, X3, [X5]");
        TestInst(CASPAT(X0, X1, X17, X18, _[X5]), asm => asm.CASPAT(X0, X1, X17, X18, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X0, X1, X17, X18, [X5]");
        TestInst(CASPAT(X15, X16, X17, X18, _[X5]), asm => asm.CASPAT(X15, X16, X17, X18, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X15, X16, X17, X18, [X5]");
        TestInst(CASPAT(XZR, X0, X17, X18, _[X5]), asm => asm.CASPAT(XZR, X0, X17, X18, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT XZR, X0, X17, X18, [X5]");
        TestInst(CASPAT(X0, X1, XZR, X0, _[X5]), asm => asm.CASPAT(X0, X1, XZR, X0, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X0, X1, XZR, X0, [X5]");
        TestInst(CASPAT(X15, X16, XZR, X0, _[X5]), asm => asm.CASPAT(X15, X16, XZR, X0, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT X15, X16, XZR, X0, [X5]");
        TestInst(CASPAT(XZR, X0, XZR, X0, _[X5]), asm => asm.CASPAT(XZR, X0, XZR, X0, _[X5]), Arm64InstructionId.CASPAT_cp64_comswappr_unpriv, Arm64Mnemonic.CASPAT, "CASPAT XZR, X0, XZR, X0, [X5]");
    }
}
