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
    [DataRow(new byte[] { 0x20, 0x12, 0x18, 0xd5 }, "msr TRFCR_EL1, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x1c, 0xd5 }, "msr TRFCR_EL2, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x1d, 0xd5 }, "msr TRFCR_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x38, 0xd5 }, "mrs x0, TRFCR_EL1")]
    [DataRow(new byte[] { 0x20, 0x12, 0x3c, 0xd5 }, "mrs x0, TRFCR_EL2")]
    [DataRow(new byte[] { 0x20, 0x12, 0x3d, 0xd5 }, "mrs x0, TRFCR_EL12")]
    [DataRow(new byte[] { 0x5f, 0x22, 0x03, 0xd5 }, "tsb csync")]
    [DataRow(new byte[] { 0x20, 0x12, 0x18, 0xd5 }, "msr TRFCR_EL1, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x1c, 0xd5 }, "msr TRFCR_EL2, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x1d, 0xd5 }, "msr TRFCR_EL12, x0")]
    [DataRow(new byte[] { 0x20, 0x12, 0x38, 0xd5 }, "mrs x0, TRFCR_EL1")]
    [DataRow(new byte[] { 0x20, 0x12, 0x3c, 0xd5 }, "mrs x0, TRFCR_EL2")]
    [DataRow(new byte[] { 0x20, 0x12, 0x3d, 0xd5 }, "mrs x0, TRFCR_EL12")]
    [DataRow(new byte[] { 0x5f, 0x22, 0x03, 0xd5 }, "tsb csync")]
    public void armv8_4a_trace_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
