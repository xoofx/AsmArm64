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
public class Arm64InstructionFactoryTests_EON_General : Arm64InstructionFactoryTests
{
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EON"/>.
    /// </summary>
    [TestMethod]
    public void Test_EON_32_log_shift_0()
    {
        TestInst(EON(W0, W1, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W2");
        TestInst(EON(W15, W1, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W2");
        TestInst(EON(WZR, W1, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W2");
        TestInst(EON(W0, W16, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W2");
        TestInst(EON(W15, W16, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W2");
        TestInst(EON(WZR, W16, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W2");
        TestInst(EON(W0, WZR, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W2");
        TestInst(EON(W15, WZR, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W2");
        TestInst(EON(WZR, WZR, W2, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W2");
        TestInst(EON(W0, W1, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W17");
        TestInst(EON(W15, W1, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W17");
        TestInst(EON(WZR, W1, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W17");
        TestInst(EON(W0, W16, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W17");
        TestInst(EON(W15, W16, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W17");
        TestInst(EON(WZR, W16, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W17");
        TestInst(EON(W0, WZR, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W17");
        TestInst(EON(W15, WZR, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W17");
        TestInst(EON(WZR, WZR, W17, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W17");
        TestInst(EON(W0, W1, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, WZR");
        TestInst(EON(W15, W1, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, WZR");
        TestInst(EON(WZR, W1, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, WZR");
        TestInst(EON(W0, W16, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, WZR");
        TestInst(EON(W15, W16, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, WZR");
        TestInst(EON(WZR, W16, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, WZR");
        TestInst(EON(W0, WZR, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, WZR");
        TestInst(EON(W15, WZR, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, WZR");
        TestInst(EON(WZR, WZR, WZR, _LSL, 0), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, WZR");
        TestInst(EON(W0, W1, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W2, LSL #1");
        TestInst(EON(W15, W1, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W2, LSL #1");
        TestInst(EON(WZR, W1, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W2, LSL #1");
        TestInst(EON(W0, W16, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W2, LSL #1");
        TestInst(EON(W15, W16, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W2, LSL #1");
        TestInst(EON(WZR, W16, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W2, LSL #1");
        TestInst(EON(W0, WZR, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W2, LSL #1");
        TestInst(EON(W15, WZR, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W2, LSL #1");
        TestInst(EON(WZR, WZR, W2, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W2, LSL #1");
        TestInst(EON(W0, W1, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W17, LSL #1");
        TestInst(EON(W15, W1, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W17, LSL #1");
        TestInst(EON(WZR, W1, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W17, LSL #1");
        TestInst(EON(W0, W16, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W17, LSL #1");
        TestInst(EON(W15, W16, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W17, LSL #1");
        TestInst(EON(WZR, W16, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W17, LSL #1");
        TestInst(EON(W0, WZR, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W17, LSL #1");
        TestInst(EON(W15, WZR, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W17, LSL #1");
        TestInst(EON(WZR, WZR, W17, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W17, LSL #1");
        TestInst(EON(W0, W1, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, WZR, LSL #1");
        TestInst(EON(W15, W1, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, WZR, LSL #1");
        TestInst(EON(WZR, W1, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, WZR, LSL #1");
        TestInst(EON(W0, W16, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, WZR, LSL #1");
        TestInst(EON(W15, W16, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, WZR, LSL #1");
        TestInst(EON(WZR, W16, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, WZR, LSL #1");
        TestInst(EON(W0, WZR, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, WZR, LSL #1");
        TestInst(EON(W15, WZR, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, WZR, LSL #1");
        TestInst(EON(WZR, WZR, WZR, _LSL, 1), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, WZR, LSL #1");
        TestInst(EON(W0, W1, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W2, LSR #10");
        TestInst(EON(W15, W1, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W2, LSR #10");
        TestInst(EON(WZR, W1, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W2, LSR #10");
        TestInst(EON(W0, W16, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W2, LSR #10");
        TestInst(EON(W15, W16, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W2, LSR #10");
        TestInst(EON(WZR, W16, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W2, LSR #10");
        TestInst(EON(W0, WZR, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W2, LSR #10");
        TestInst(EON(W15, WZR, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W2, LSR #10");
        TestInst(EON(WZR, WZR, W2, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W2, LSR #10");
        TestInst(EON(W0, W1, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W17, LSR #10");
        TestInst(EON(W15, W1, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W17, LSR #10");
        TestInst(EON(WZR, W1, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W17, LSR #10");
        TestInst(EON(W0, W16, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W17, LSR #10");
        TestInst(EON(W15, W16, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W17, LSR #10");
        TestInst(EON(WZR, W16, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W17, LSR #10");
        TestInst(EON(W0, WZR, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W17, LSR #10");
        TestInst(EON(W15, WZR, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W17, LSR #10");
        TestInst(EON(WZR, WZR, W17, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W17, LSR #10");
        TestInst(EON(W0, W1, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, WZR, LSR #10");
        TestInst(EON(W15, W1, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, WZR, LSR #10");
        TestInst(EON(WZR, W1, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, WZR, LSR #10");
        TestInst(EON(W0, W16, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, WZR, LSR #10");
        TestInst(EON(W15, W16, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, WZR, LSR #10");
        TestInst(EON(WZR, W16, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, WZR, LSR #10");
        TestInst(EON(W0, WZR, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, WZR, LSR #10");
        TestInst(EON(W15, WZR, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, WZR, LSR #10");
        TestInst(EON(WZR, WZR, WZR, _LSR, 10), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, WZR, LSR #10");
        TestInst(EON(W0, W1, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W2, ASR #12");
        TestInst(EON(W15, W1, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W2, ASR #12");
        TestInst(EON(WZR, W1, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W2, ASR #12");
        TestInst(EON(W0, W16, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W2, ASR #12");
        TestInst(EON(W15, W16, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W2, ASR #12");
        TestInst(EON(WZR, W16, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W2, ASR #12");
        TestInst(EON(W0, WZR, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W2, ASR #12");
        TestInst(EON(W15, WZR, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W2, ASR #12");
        TestInst(EON(WZR, WZR, W2, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W2, ASR #12");
        TestInst(EON(W0, W1, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W17, ASR #12");
        TestInst(EON(W15, W1, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W17, ASR #12");
        TestInst(EON(WZR, W1, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W17, ASR #12");
        TestInst(EON(W0, W16, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W17, ASR #12");
        TestInst(EON(W15, W16, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W17, ASR #12");
        TestInst(EON(WZR, W16, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W17, ASR #12");
        TestInst(EON(W0, WZR, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W17, ASR #12");
        TestInst(EON(W15, WZR, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W17, ASR #12");
        TestInst(EON(WZR, WZR, W17, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W17, ASR #12");
        TestInst(EON(W0, W1, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, WZR, ASR #12");
        TestInst(EON(W15, W1, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, WZR, ASR #12");
        TestInst(EON(WZR, W1, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, WZR, ASR #12");
        TestInst(EON(W0, W16, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, WZR, ASR #12");
        TestInst(EON(W15, W16, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, WZR, ASR #12");
        TestInst(EON(WZR, W16, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, WZR, ASR #12");
        TestInst(EON(W0, WZR, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, WZR, ASR #12");
        TestInst(EON(W15, WZR, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, WZR, ASR #12");
        TestInst(EON(WZR, WZR, WZR, _ASR, 12), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, WZR, ASR #12");
        TestInst(EON(W0, W1, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W2, ROR #7");
        TestInst(EON(W15, W1, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W2, ROR #7");
        TestInst(EON(WZR, W1, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W2, ROR #7");
        TestInst(EON(W0, W16, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W2, ROR #7");
        TestInst(EON(W15, W16, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W2, ROR #7");
        TestInst(EON(WZR, W16, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W2, ROR #7");
        TestInst(EON(W0, WZR, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W2, ROR #7");
        TestInst(EON(W15, WZR, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W2, ROR #7");
        TestInst(EON(WZR, WZR, W2, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W2, ROR #7");
        TestInst(EON(W0, W1, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, W17, ROR #7");
        TestInst(EON(W15, W1, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, W17, ROR #7");
        TestInst(EON(WZR, W1, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, W17, ROR #7");
        TestInst(EON(W0, W16, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, W17, ROR #7");
        TestInst(EON(W15, W16, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, W17, ROR #7");
        TestInst(EON(WZR, W16, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, W17, ROR #7");
        TestInst(EON(W0, WZR, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, W17, ROR #7");
        TestInst(EON(W15, WZR, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, W17, ROR #7");
        TestInst(EON(WZR, WZR, W17, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, W17, ROR #7");
        TestInst(EON(W0, W1, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W1, WZR, ROR #7");
        TestInst(EON(W15, W1, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W1, WZR, ROR #7");
        TestInst(EON(WZR, W1, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W1, WZR, ROR #7");
        TestInst(EON(W0, W16, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, W16, WZR, ROR #7");
        TestInst(EON(W15, W16, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, W16, WZR, ROR #7");
        TestInst(EON(WZR, W16, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, W16, WZR, ROR #7");
        TestInst(EON(W0, WZR, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W0, WZR, WZR, ROR #7");
        TestInst(EON(W15, WZR, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON W15, WZR, WZR, ROR #7");
        TestInst(EON(WZR, WZR, WZR, _ROR, 7), Arm64InstructionId.EON_32_log_shift, Arm64Mnemonic.EON, "EON WZR, WZR, WZR, ROR #7");
    }
    
    /// <summary>
    /// Test of <see cref="Arm64InstructionFactory.EON"/>.
    /// </summary>
    [TestMethod]
    public void Test_EON_64_log_shift_1()
    {
        TestInst(EON(X0, X1, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X2");
        TestInst(EON(X15, X1, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X2");
        TestInst(EON(XZR, X1, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X2");
        TestInst(EON(X0, X16, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X2");
        TestInst(EON(X15, X16, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X2");
        TestInst(EON(XZR, X16, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X2");
        TestInst(EON(X0, XZR, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X2");
        TestInst(EON(X15, XZR, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X2");
        TestInst(EON(XZR, XZR, X2, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X2");
        TestInst(EON(X0, X1, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X17");
        TestInst(EON(X15, X1, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X17");
        TestInst(EON(XZR, X1, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X17");
        TestInst(EON(X0, X16, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X17");
        TestInst(EON(X15, X16, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X17");
        TestInst(EON(XZR, X16, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X17");
        TestInst(EON(X0, XZR, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X17");
        TestInst(EON(X15, XZR, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X17");
        TestInst(EON(XZR, XZR, X17, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X17");
        TestInst(EON(X0, X1, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, XZR");
        TestInst(EON(X15, X1, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, XZR");
        TestInst(EON(XZR, X1, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, XZR");
        TestInst(EON(X0, X16, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, XZR");
        TestInst(EON(X15, X16, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, XZR");
        TestInst(EON(XZR, X16, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, XZR");
        TestInst(EON(X0, XZR, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, XZR");
        TestInst(EON(X15, XZR, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, XZR");
        TestInst(EON(XZR, XZR, XZR, _LSL, 0), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, XZR");
        TestInst(EON(X0, X1, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X2, LSL #1");
        TestInst(EON(X15, X1, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X2, LSL #1");
        TestInst(EON(XZR, X1, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X2, LSL #1");
        TestInst(EON(X0, X16, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X2, LSL #1");
        TestInst(EON(X15, X16, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X2, LSL #1");
        TestInst(EON(XZR, X16, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X2, LSL #1");
        TestInst(EON(X0, XZR, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X2, LSL #1");
        TestInst(EON(X15, XZR, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X2, LSL #1");
        TestInst(EON(XZR, XZR, X2, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X2, LSL #1");
        TestInst(EON(X0, X1, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X17, LSL #1");
        TestInst(EON(X15, X1, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X17, LSL #1");
        TestInst(EON(XZR, X1, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X17, LSL #1");
        TestInst(EON(X0, X16, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X17, LSL #1");
        TestInst(EON(X15, X16, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X17, LSL #1");
        TestInst(EON(XZR, X16, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X17, LSL #1");
        TestInst(EON(X0, XZR, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X17, LSL #1");
        TestInst(EON(X15, XZR, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X17, LSL #1");
        TestInst(EON(XZR, XZR, X17, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X17, LSL #1");
        TestInst(EON(X0, X1, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, XZR, LSL #1");
        TestInst(EON(X15, X1, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, XZR, LSL #1");
        TestInst(EON(XZR, X1, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, XZR, LSL #1");
        TestInst(EON(X0, X16, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, XZR, LSL #1");
        TestInst(EON(X15, X16, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, XZR, LSL #1");
        TestInst(EON(XZR, X16, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, XZR, LSL #1");
        TestInst(EON(X0, XZR, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, XZR, LSL #1");
        TestInst(EON(X15, XZR, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, XZR, LSL #1");
        TestInst(EON(XZR, XZR, XZR, _LSL, 1), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, XZR, LSL #1");
        TestInst(EON(X0, X1, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X2, LSR #10");
        TestInst(EON(X15, X1, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X2, LSR #10");
        TestInst(EON(XZR, X1, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X2, LSR #10");
        TestInst(EON(X0, X16, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X2, LSR #10");
        TestInst(EON(X15, X16, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X2, LSR #10");
        TestInst(EON(XZR, X16, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X2, LSR #10");
        TestInst(EON(X0, XZR, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X2, LSR #10");
        TestInst(EON(X15, XZR, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X2, LSR #10");
        TestInst(EON(XZR, XZR, X2, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X2, LSR #10");
        TestInst(EON(X0, X1, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X17, LSR #10");
        TestInst(EON(X15, X1, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X17, LSR #10");
        TestInst(EON(XZR, X1, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X17, LSR #10");
        TestInst(EON(X0, X16, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X17, LSR #10");
        TestInst(EON(X15, X16, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X17, LSR #10");
        TestInst(EON(XZR, X16, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X17, LSR #10");
        TestInst(EON(X0, XZR, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X17, LSR #10");
        TestInst(EON(X15, XZR, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X17, LSR #10");
        TestInst(EON(XZR, XZR, X17, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X17, LSR #10");
        TestInst(EON(X0, X1, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, XZR, LSR #10");
        TestInst(EON(X15, X1, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, XZR, LSR #10");
        TestInst(EON(XZR, X1, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, XZR, LSR #10");
        TestInst(EON(X0, X16, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, XZR, LSR #10");
        TestInst(EON(X15, X16, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, XZR, LSR #10");
        TestInst(EON(XZR, X16, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, XZR, LSR #10");
        TestInst(EON(X0, XZR, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, XZR, LSR #10");
        TestInst(EON(X15, XZR, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, XZR, LSR #10");
        TestInst(EON(XZR, XZR, XZR, _LSR, 10), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, XZR, LSR #10");
        TestInst(EON(X0, X1, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X2, ASR #12");
        TestInst(EON(X15, X1, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X2, ASR #12");
        TestInst(EON(XZR, X1, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X2, ASR #12");
        TestInst(EON(X0, X16, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X2, ASR #12");
        TestInst(EON(X15, X16, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X2, ASR #12");
        TestInst(EON(XZR, X16, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X2, ASR #12");
        TestInst(EON(X0, XZR, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X2, ASR #12");
        TestInst(EON(X15, XZR, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X2, ASR #12");
        TestInst(EON(XZR, XZR, X2, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X2, ASR #12");
        TestInst(EON(X0, X1, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X17, ASR #12");
        TestInst(EON(X15, X1, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X17, ASR #12");
        TestInst(EON(XZR, X1, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X17, ASR #12");
        TestInst(EON(X0, X16, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X17, ASR #12");
        TestInst(EON(X15, X16, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X17, ASR #12");
        TestInst(EON(XZR, X16, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X17, ASR #12");
        TestInst(EON(X0, XZR, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X17, ASR #12");
        TestInst(EON(X15, XZR, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X17, ASR #12");
        TestInst(EON(XZR, XZR, X17, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X17, ASR #12");
        TestInst(EON(X0, X1, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, XZR, ASR #12");
        TestInst(EON(X15, X1, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, XZR, ASR #12");
        TestInst(EON(XZR, X1, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, XZR, ASR #12");
        TestInst(EON(X0, X16, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, XZR, ASR #12");
        TestInst(EON(X15, X16, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, XZR, ASR #12");
        TestInst(EON(XZR, X16, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, XZR, ASR #12");
        TestInst(EON(X0, XZR, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, XZR, ASR #12");
        TestInst(EON(X15, XZR, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, XZR, ASR #12");
        TestInst(EON(XZR, XZR, XZR, _ASR, 12), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, XZR, ASR #12");
        TestInst(EON(X0, X1, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X2, ROR #7");
        TestInst(EON(X15, X1, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X2, ROR #7");
        TestInst(EON(XZR, X1, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X2, ROR #7");
        TestInst(EON(X0, X16, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X2, ROR #7");
        TestInst(EON(X15, X16, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X2, ROR #7");
        TestInst(EON(XZR, X16, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X2, ROR #7");
        TestInst(EON(X0, XZR, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X2, ROR #7");
        TestInst(EON(X15, XZR, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X2, ROR #7");
        TestInst(EON(XZR, XZR, X2, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X2, ROR #7");
        TestInst(EON(X0, X1, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, X17, ROR #7");
        TestInst(EON(X15, X1, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, X17, ROR #7");
        TestInst(EON(XZR, X1, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, X17, ROR #7");
        TestInst(EON(X0, X16, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, X17, ROR #7");
        TestInst(EON(X15, X16, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, X17, ROR #7");
        TestInst(EON(XZR, X16, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, X17, ROR #7");
        TestInst(EON(X0, XZR, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, X17, ROR #7");
        TestInst(EON(X15, XZR, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, X17, ROR #7");
        TestInst(EON(XZR, XZR, X17, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, X17, ROR #7");
        TestInst(EON(X0, X1, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X1, XZR, ROR #7");
        TestInst(EON(X15, X1, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X1, XZR, ROR #7");
        TestInst(EON(XZR, X1, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X1, XZR, ROR #7");
        TestInst(EON(X0, X16, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, X16, XZR, ROR #7");
        TestInst(EON(X15, X16, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, X16, XZR, ROR #7");
        TestInst(EON(XZR, X16, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, X16, XZR, ROR #7");
        TestInst(EON(X0, XZR, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X0, XZR, XZR, ROR #7");
        TestInst(EON(X15, XZR, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON X15, XZR, XZR, ROR #7");
        TestInst(EON(XZR, XZR, XZR, _ROR, 7), Arm64InstructionId.EON_64_log_shift, Arm64Mnemonic.EON, "EON XZR, XZR, XZR, ROR #7");
    }
}
