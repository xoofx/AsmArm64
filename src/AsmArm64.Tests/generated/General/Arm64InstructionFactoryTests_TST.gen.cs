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
public class Arm64InstructionFactoryTests_TST_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TST"/>.
    /// </summary>
    [TestMethod]
    public void Test_TST_ands_32s_log_imm_0()
    {
        TestInst(TST(W0, 0x3030303), Arm64InstructionId.TST_ands_32s_log_imm, Arm64Mnemonic.TST, "TST W0, #0x3030303");
        TestInst(TST(W15, 0x3030303), Arm64InstructionId.TST_ands_32s_log_imm, Arm64Mnemonic.TST, "TST W15, #0x3030303");
        TestInst(TST(WZR, 0x3030303), Arm64InstructionId.TST_ands_32s_log_imm, Arm64Mnemonic.TST, "TST WZR, #0x3030303");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TST"/>.
    /// </summary>
    [TestMethod]
    public void Test_TST_ands_64s_log_imm_1()
    {
        TestInst(TST(X0, 0x303030303030303UL), Arm64InstructionId.TST_ands_64s_log_imm, Arm64Mnemonic.TST, "TST X0, #0x303030303030303");
        TestInst(TST(X15, 0x303030303030303UL), Arm64InstructionId.TST_ands_64s_log_imm, Arm64Mnemonic.TST, "TST X15, #0x303030303030303");
        TestInst(TST(XZR, 0x303030303030303UL), Arm64InstructionId.TST_ands_64s_log_imm, Arm64Mnemonic.TST, "TST XZR, #0x303030303030303");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TST"/>.
    /// </summary>
    [TestMethod]
    public void Test_TST_ands_32_log_shift_2()
    {
        TestInst(TST(W0, W1, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W1");
        TestInst(TST(W15, W1, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W1");
        TestInst(TST(WZR, W1, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W1");
        TestInst(TST(W0, W16, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W16");
        TestInst(TST(W15, W16, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W16");
        TestInst(TST(WZR, W16, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W16");
        TestInst(TST(W0, WZR, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, WZR");
        TestInst(TST(W15, WZR, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, WZR");
        TestInst(TST(WZR, WZR, _LSL, 0), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, WZR");
        TestInst(TST(W0, W1, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W1, LSL #1");
        TestInst(TST(W15, W1, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W1, LSL #1");
        TestInst(TST(WZR, W1, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W1, LSL #1");
        TestInst(TST(W0, W16, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W16, LSL #1");
        TestInst(TST(W15, W16, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W16, LSL #1");
        TestInst(TST(WZR, W16, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W16, LSL #1");
        TestInst(TST(W0, WZR, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, WZR, LSL #1");
        TestInst(TST(W15, WZR, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, WZR, LSL #1");
        TestInst(TST(WZR, WZR, _LSL, 1), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, WZR, LSL #1");
        TestInst(TST(W0, W1, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W1, LSR #10");
        TestInst(TST(W15, W1, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W1, LSR #10");
        TestInst(TST(WZR, W1, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W1, LSR #10");
        TestInst(TST(W0, W16, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W16, LSR #10");
        TestInst(TST(W15, W16, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W16, LSR #10");
        TestInst(TST(WZR, W16, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W16, LSR #10");
        TestInst(TST(W0, WZR, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, WZR, LSR #10");
        TestInst(TST(W15, WZR, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, WZR, LSR #10");
        TestInst(TST(WZR, WZR, _LSR, 10), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, WZR, LSR #10");
        TestInst(TST(W0, W1, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W1, ASR #12");
        TestInst(TST(W15, W1, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W1, ASR #12");
        TestInst(TST(WZR, W1, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W1, ASR #12");
        TestInst(TST(W0, W16, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W16, ASR #12");
        TestInst(TST(W15, W16, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W16, ASR #12");
        TestInst(TST(WZR, W16, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W16, ASR #12");
        TestInst(TST(W0, WZR, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, WZR, ASR #12");
        TestInst(TST(W15, WZR, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, WZR, ASR #12");
        TestInst(TST(WZR, WZR, _ASR, 12), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, WZR, ASR #12");
        TestInst(TST(W0, W1, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W1, ROR #7");
        TestInst(TST(W15, W1, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W1, ROR #7");
        TestInst(TST(WZR, W1, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W1, ROR #7");
        TestInst(TST(W0, W16, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, W16, ROR #7");
        TestInst(TST(W15, W16, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, W16, ROR #7");
        TestInst(TST(WZR, W16, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, W16, ROR #7");
        TestInst(TST(W0, WZR, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W0, WZR, ROR #7");
        TestInst(TST(W15, WZR, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST W15, WZR, ROR #7");
        TestInst(TST(WZR, WZR, _ROR, 7), Arm64InstructionId.TST_ands_32_log_shift, Arm64Mnemonic.TST, "TST WZR, WZR, ROR #7");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.TST"/>.
    /// </summary>
    [TestMethod]
    public void Test_TST_ands_64_log_shift_3()
    {
        TestInst(TST(X0, X1, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X1");
        TestInst(TST(X15, X1, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X1");
        TestInst(TST(XZR, X1, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X1");
        TestInst(TST(X0, X16, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X16");
        TestInst(TST(X15, X16, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X16");
        TestInst(TST(XZR, X16, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X16");
        TestInst(TST(X0, XZR, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, XZR");
        TestInst(TST(X15, XZR, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, XZR");
        TestInst(TST(XZR, XZR, _LSL, 0), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, XZR");
        TestInst(TST(X0, X1, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X1, LSL #1");
        TestInst(TST(X15, X1, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X1, LSL #1");
        TestInst(TST(XZR, X1, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X1, LSL #1");
        TestInst(TST(X0, X16, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X16, LSL #1");
        TestInst(TST(X15, X16, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X16, LSL #1");
        TestInst(TST(XZR, X16, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X16, LSL #1");
        TestInst(TST(X0, XZR, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, XZR, LSL #1");
        TestInst(TST(X15, XZR, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, XZR, LSL #1");
        TestInst(TST(XZR, XZR, _LSL, 1), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, XZR, LSL #1");
        TestInst(TST(X0, X1, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X1, LSR #10");
        TestInst(TST(X15, X1, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X1, LSR #10");
        TestInst(TST(XZR, X1, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X1, LSR #10");
        TestInst(TST(X0, X16, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X16, LSR #10");
        TestInst(TST(X15, X16, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X16, LSR #10");
        TestInst(TST(XZR, X16, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X16, LSR #10");
        TestInst(TST(X0, XZR, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, XZR, LSR #10");
        TestInst(TST(X15, XZR, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, XZR, LSR #10");
        TestInst(TST(XZR, XZR, _LSR, 10), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, XZR, LSR #10");
        TestInst(TST(X0, X1, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X1, ASR #12");
        TestInst(TST(X15, X1, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X1, ASR #12");
        TestInst(TST(XZR, X1, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X1, ASR #12");
        TestInst(TST(X0, X16, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X16, ASR #12");
        TestInst(TST(X15, X16, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X16, ASR #12");
        TestInst(TST(XZR, X16, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X16, ASR #12");
        TestInst(TST(X0, XZR, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, XZR, ASR #12");
        TestInst(TST(X15, XZR, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, XZR, ASR #12");
        TestInst(TST(XZR, XZR, _ASR, 12), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, XZR, ASR #12");
        TestInst(TST(X0, X1, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X1, ROR #7");
        TestInst(TST(X15, X1, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X1, ROR #7");
        TestInst(TST(XZR, X1, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X1, ROR #7");
        TestInst(TST(X0, X16, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, X16, ROR #7");
        TestInst(TST(X15, X16, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, X16, ROR #7");
        TestInst(TST(XZR, X16, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, X16, ROR #7");
        TestInst(TST(X0, XZR, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X0, XZR, ROR #7");
        TestInst(TST(X15, XZR, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST X15, XZR, ROR #7");
        TestInst(TST(XZR, XZR, _ROR, 7), Arm64InstructionId.TST_ands_64_log_shift, Arm64Mnemonic.TST, "TST XZR, XZR, ROR #7");
    }
}
