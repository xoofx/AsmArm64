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
public class Arm64InstructionFactoryTests_CASPA_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASPA"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASPA_cp32_comswappr_0()
    {
        TestInst(CASPA(W0, W1, W2, W3, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W0, W1, W2, W3, [X5]");
        TestInst(CASPA(W15, W16, W2, W3, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W15, W16, W2, W3, [X5]");
        TestInst(CASPA(WZR, W0, W2, W3, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA WZR, W0, W2, W3, [X5]");
        TestInst(CASPA(W0, W1, W17, W18, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W0, W1, W17, W18, [X5]");
        TestInst(CASPA(W15, W16, W17, W18, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W15, W16, W17, W18, [X5]");
        TestInst(CASPA(WZR, W0, W17, W18, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA WZR, W0, W17, W18, [X5]");
        TestInst(CASPA(W0, W1, WZR, W0, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W0, W1, WZR, W0, [X5]");
        TestInst(CASPA(W15, W16, WZR, W0, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA W15, W16, WZR, W0, [X5]");
        TestInst(CASPA(WZR, W0, WZR, W0, _[X5]), Arm64InstructionId.CASPA_cp32_comswappr, Arm64Mnemonic.CASPA, "CASPA WZR, W0, WZR, W0, [X5]");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.CASPA"/>.
    /// </summary>
    [TestMethod]
    public void Test_CASPA_cp64_comswappr_1()
    {
        TestInst(CASPA(X0, X1, X2, X3, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X0, X1, X2, X3, [X5]");
        TestInst(CASPA(X15, X16, X2, X3, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X15, X16, X2, X3, [X5]");
        TestInst(CASPA(XZR, X0, X2, X3, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA XZR, X0, X2, X3, [X5]");
        TestInst(CASPA(X0, X1, X17, X18, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X0, X1, X17, X18, [X5]");
        TestInst(CASPA(X15, X16, X17, X18, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X15, X16, X17, X18, [X5]");
        TestInst(CASPA(XZR, X0, X17, X18, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA XZR, X0, X17, X18, [X5]");
        TestInst(CASPA(X0, X1, XZR, X0, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X0, X1, XZR, X0, [X5]");
        TestInst(CASPA(X15, X16, XZR, X0, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA X15, X16, XZR, X0, [X5]");
        TestInst(CASPA(XZR, X0, XZR, X0, _[X5]), Arm64InstructionId.CASPA_cp64_comswappr, Arm64Mnemonic.CASPA, "CASPA XZR, X0, XZR, X0, [X5]");
    }
}
