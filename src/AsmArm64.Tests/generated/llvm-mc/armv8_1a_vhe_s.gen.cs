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
    [DataRow(new byte[] { 0x20, 0x20, 0x1c, 0xd5 }, "msr TTBR1_EL2, x0")]
    [DataRow(new byte[] { 0x20, 0xd0, 0x1c, 0xd5 }, "msr CONTEXTIDR_EL2, x0")]
    [DataRow(new byte[] { 0x00, 0xe3, 0x1c, 0xd5 }, "msr CNTHV_TVAL_EL2, x0")]
    [DataRow(new byte[] { 0x40, 0xe3, 0x1c, 0xd5 }, "msr CNTHV_CVAL_EL2, x0")]
    [DataRow(new byte[] { 0x20, 0xe3, 0x1c, 0xd5 }, "msr CNTHV_CTL_EL2, x0")]
    [DataRow(new byte[] { 0x00, 0x10, 0x1d, 0xd5 }, "msr SCTLR_EL12, x0")]
    [DataRow(new byte[] { 0x40, 0x10, 0x1d, 0xd5 }, "msr CPACR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0x20, 0x1d, 0xd5 }, "msr TTBR0_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0x20, 0x1d, 0xd5 }, "msr TTBR1_EL12, x0")]
    [DataRow(new byte[] { 0x40, 0x20, 0x1d, 0xd5 }, "msr TCR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0x51, 0x1d, 0xd5 }, "msr AFSR0_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0x51, 0x1d, 0xd5 }, "msr AFSR1_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0x52, 0x1d, 0xd5 }, "msr ESR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0x60, 0x1d, 0xd5 }, "msr FAR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0xa2, 0x1d, 0xd5 }, "msr MAIR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0xa3, 0x1d, 0xd5 }, "msr AMAIR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0xc0, 0x1d, 0xd5 }, "msr VBAR_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0xd0, 0x1d, 0xd5 }, "msr CONTEXTIDR_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0xe1, 0x1d, 0xd5 }, "msr CNTKCTL_EL12, x0")]
    [DataRow(new byte[] { 0x00, 0xe2, 0x1d, 0xd5 }, "msr CNTP_TVAL_EL02, x0")]
    [DataRow(new byte[] { 0x20, 0xe2, 0x1d, 0xd5 }, "msr CNTP_CTL_EL02, x0")]
    [DataRow(new byte[] { 0x40, 0xe2, 0x1d, 0xd5 }, "msr CNTP_CVAL_EL02, x0")]
    [DataRow(new byte[] { 0x00, 0xe3, 0x1d, 0xd5 }, "msr CNTV_TVAL_EL02, x0")]
    [DataRow(new byte[] { 0x20, 0xe3, 0x1d, 0xd5 }, "msr CNTV_CTL_EL02, x0")]
    [DataRow(new byte[] { 0x40, 0xe3, 0x1d, 0xd5 }, "msr CNTV_CVAL_EL02, x0")]
    [DataRow(new byte[] { 0x00, 0x40, 0x1d, 0xd5 }, "msr SPSR_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0x40, 0x1d, 0xd5 }, "msr ELR_EL12, x0")]
    public void armv8_1a_vhe_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
