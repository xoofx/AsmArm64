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
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    [DataRow(new byte[] { 0xc2, 0x42, 0x3b, 0xd5 }, "mrs x2, SSBS")]
    [DataRow(new byte[] { 0xc3, 0x42, 0x1b, 0xd5 }, "msr SSBS, x3")]
    [DataRow(new byte[] { 0x3f, 0x41, 0x03, 0xd5 }, "msr SSBS, #1")]
    public void armv8_5a_ssbs_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
