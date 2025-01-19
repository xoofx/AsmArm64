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
    [DataRow(new byte[] { 0x00, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBLIMITR_EL1")]
    [DataRow(new byte[] { 0x20, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBPTR_EL1")]
    [DataRow(new byte[] { 0x40, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBBASER_EL1")]
    [DataRow(new byte[] { 0x60, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBSR_EL1")]
    [DataRow(new byte[] { 0x80, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBMAR_EL1")]
    [DataRow(new byte[] { 0xc0, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBTRG_EL1")]
    [DataRow(new byte[] { 0xe0, 0x9b, 0x38, 0xd5 }, "mrs x0, TRBIDR_EL1")]
    [DataRow(new byte[] { 0x00, 0x9b, 0x18, 0xd5 }, "msr TRBLIMITR_EL1, x0")]
    [DataRow(new byte[] { 0x20, 0x9b, 0x18, 0xd5 }, "msr TRBPTR_EL1, x0")]
    [DataRow(new byte[] { 0x40, 0x9b, 0x18, 0xd5 }, "msr TRBBASER_EL1, x0")]
    [DataRow(new byte[] { 0x60, 0x9b, 0x18, 0xd5 }, "msr TRBSR_EL1, x0")]
    [DataRow(new byte[] { 0x80, 0x9b, 0x18, 0xd5 }, "msr TRBMAR_EL1, x0")]
    [DataRow(new byte[] { 0xc0, 0x9b, 0x18, 0xd5 }, "msr TRBTRG_EL1, x0")]
    public void trbe_sysreg_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
