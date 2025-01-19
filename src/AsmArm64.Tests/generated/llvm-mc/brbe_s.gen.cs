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

using System;
namespace AsmArm64.Tests;

partial class McInstructionTests
{
    [TestMethod]
    [DataRow(new byte[] { 0x00, 0x90, 0x11, 0xd5 }, "msr BRBCR_EL1, x0")]
    [DataRow(new byte[] { 0x01, 0x90, 0x31, 0xd5 }, "mrs x1, BRBCR_EL1")]
    [DataRow(new byte[] { 0x02, 0x90, 0x15, 0xd5 }, "msr BRBCR_EL12, x2")]
    [DataRow(new byte[] { 0x03, 0x90, 0x35, 0xd5 }, "mrs x3, BRBCR_EL12")]
    [DataRow(new byte[] { 0x04, 0x90, 0x14, 0xd5 }, "msr BRBCR_EL2, x4")]
    [DataRow(new byte[] { 0x05, 0x90, 0x34, 0xd5 }, "mrs x5, BRBCR_EL2")]
    [DataRow(new byte[] { 0x26, 0x90, 0x11, 0xd5 }, "msr BRBFCR_EL1, x6")]
    [DataRow(new byte[] { 0x27, 0x90, 0x31, 0xd5 }, "mrs x7, BRBFCR_EL1")]
    [DataRow(new byte[] { 0x09, 0x92, 0x31, 0xd5 }, "mrs x9, BRBIDR0_EL1")]
    [DataRow(new byte[] { 0x0a, 0x91, 0x11, 0xd5 }, "msr BRBINFINJ_EL1, x10")]
    [DataRow(new byte[] { 0x0b, 0x91, 0x31, 0xd5 }, "mrs x11, BRBINFINJ_EL1")]
    [DataRow(new byte[] { 0x2c, 0x91, 0x11, 0xd5 }, "msr BRBSRCINJ_EL1, x12")]
    [DataRow(new byte[] { 0x2d, 0x91, 0x31, 0xd5 }, "mrs x13, BRBSRCINJ_EL1")]
    [DataRow(new byte[] { 0x4e, 0x91, 0x11, 0xd5 }, "msr BRBTGTINJ_EL1, x14")]
    [DataRow(new byte[] { 0x4f, 0x91, 0x31, 0xd5 }, "mrs x15, BRBTGTINJ_EL1")]
    [DataRow(new byte[] { 0x50, 0x90, 0x11, 0xd5 }, "msr BRBTS_EL1, x16")]
    [DataRow(new byte[] { 0x51, 0x90, 0x31, 0xd5 }, "mrs x17, BRBTS_EL1")]
    [DataRow(new byte[] { 0x13, 0x80, 0x31, 0xd5 }, "mrs x19, BRBINF0_EL1")]
    [DataRow(new byte[] { 0x15, 0x81, 0x31, 0xd5 }, "mrs x21, BRBINF1_EL1")]
    [DataRow(new byte[] { 0x17, 0x82, 0x31, 0xd5 }, "mrs x23, BRBINF2_EL1")]
    [DataRow(new byte[] { 0x39, 0x84, 0x31, 0xd5 }, "mrs x25, BRBSRC4_EL1")]
    [DataRow(new byte[] { 0x3b, 0x88, 0x31, 0xd5 }, "mrs x27, BRBSRC8_EL1")]
    [DataRow(new byte[] { 0xbd, 0x80, 0x31, 0xd5 }, "mrs x29, BRBSRC16_EL1")]
    [DataRow(new byte[] { 0x41, 0x8a, 0x31, 0xd5 }, "mrs x1, BRBTGT10_EL1")]
    [DataRow(new byte[] { 0xc3, 0x85, 0x31, 0xd5 }, "mrs x3, BRBTGT21_EL1")]
    [DataRow(new byte[] { 0xc5, 0x8f, 0x31, 0xd5 }, "mrs x5, BRBTGT31_EL1")]
    [DataRow(new byte[] { 0x9f, 0x72, 0x09, 0xd5 }, "brb iall")]
    [DataRow(new byte[] { 0xbf, 0x72, 0x09, 0xd5 }, "brb inj")]
    [DataRow(new byte[] { 0x9f, 0x72, 0x09, 0xd5 }, "brb iall")]
    [DataRow(new byte[] { 0xbf, 0x72, 0x09, 0xd5 }, "brb inj")]
    public void brbe_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
