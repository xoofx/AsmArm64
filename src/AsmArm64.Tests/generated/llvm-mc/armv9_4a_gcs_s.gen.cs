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
    [DataRow(new byte[] { 0x00, 0x25, 0x18, 0xd5 }, "msr GCSCR_EL1, x0")]
    [DataRow(new byte[] { 0x01, 0x25, 0x38, 0xd5 }, "mrs x1, GCSCR_EL1")]
    [DataRow(new byte[] { 0x22, 0x25, 0x18, 0xd5 }, "msr GCSPR_EL1, x2")]
    [DataRow(new byte[] { 0x23, 0x25, 0x38, 0xd5 }, "mrs x3, GCSPR_EL1")]
    [DataRow(new byte[] { 0x44, 0x25, 0x18, 0xd5 }, "msr GCSCRE0_EL1, x4")]
    [DataRow(new byte[] { 0x45, 0x25, 0x38, 0xd5 }, "mrs x5, GCSCRE0_EL1")]
    [DataRow(new byte[] { 0x26, 0x25, 0x1b, 0xd5 }, "msr GCSPR_EL0, x6")]
    [DataRow(new byte[] { 0x27, 0x25, 0x3b, 0xd5 }, "mrs x7, GCSPR_EL0")]
    [DataRow(new byte[] { 0x0a, 0x25, 0x1c, 0xd5 }, "msr GCSCR_EL2, x10")]
    [DataRow(new byte[] { 0x0b, 0x25, 0x3c, 0xd5 }, "mrs x11, GCSCR_EL2")]
    [DataRow(new byte[] { 0x2c, 0x25, 0x1c, 0xd5 }, "msr GCSPR_EL2, x12")]
    [DataRow(new byte[] { 0x2d, 0x25, 0x3c, 0xd5 }, "mrs x13, GCSPR_EL2")]
    [DataRow(new byte[] { 0x0e, 0x25, 0x1d, 0xd5 }, "msr GCSCR_EL12, x14")]
    [DataRow(new byte[] { 0x0f, 0x25, 0x3d, 0xd5 }, "mrs x15, GCSCR_EL12")]
    [DataRow(new byte[] { 0x30, 0x25, 0x1d, 0xd5 }, "msr GCSPR_EL12, x16")]
    [DataRow(new byte[] { 0x31, 0x25, 0x3d, 0xd5 }, "mrs x17, GCSPR_EL12")]
    [DataRow(new byte[] { 0x12, 0x25, 0x1e, 0xd5 }, "msr GCSCR_EL3, x18")]
    [DataRow(new byte[] { 0x13, 0x25, 0x3e, 0xd5 }, "mrs x19, GCSCR_EL3")]
    [DataRow(new byte[] { 0x34, 0x25, 0x1e, 0xd5 }, "msr GCSPR_EL3, x20")]
    [DataRow(new byte[] { 0x35, 0x25, 0x3e, 0xd5 }, "mrs x21, GCSPR_EL3")]
    [DataRow(new byte[] { 0x55, 0x77, 0x0b, 0xd5 }, "gcsss1 x21")]
    [DataRow(new byte[] { 0x76, 0x77, 0x2b, 0xd5 }, "gcsss2 x22")]
    [DataRow(new byte[] { 0x19, 0x77, 0x0b, 0xd5 }, "gcspushm x25")]
    [DataRow(new byte[] { 0x3f, 0x77, 0x2b, 0xd5 }, "gcspopm")]
    [DataRow(new byte[] { 0x3f, 0x77, 0x2b, 0xd5 }, "gcspopm")]
    [DataRow(new byte[] { 0x39, 0x77, 0x2b, 0xd5 }, "gcspopm x25")]
    [DataRow(new byte[] { 0x7f, 0x22, 0x03, 0xd5 }, "gcsb dsync")]
    [DataRow(new byte[] { 0x7f, 0x22, 0x03, 0xd5 }, "gcsb dsync")]
    [DataRow(new byte[] { 0x7a, 0x0f, 0x1f, 0xd9 }, "gcsstr x26, [x27]")]
    [DataRow(new byte[] { 0xfa, 0x0f, 0x1f, 0xd9 }, "gcsstr x26, [sp]")]
    [DataRow(new byte[] { 0x7a, 0x1f, 0x1f, 0xd9 }, "gcssttr x26, [x27]")]
    [DataRow(new byte[] { 0xfa, 0x1f, 0x1f, 0xd9 }, "gcssttr x26, [sp]")]
    [DataRow(new byte[] { 0x9f, 0x77, 0x08, 0xd5 }, "gcspushx")]
    [DataRow(new byte[] { 0xbf, 0x77, 0x08, 0xd5 }, "gcspopcx")]
    [DataRow(new byte[] { 0xdf, 0x77, 0x08, 0xd5 }, "gcspopx")]
    public void armv9_4a_gcs_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
