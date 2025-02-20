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
    [DataRow(new byte[] { 0xe5, 0x40, 0xd4, 0x1a }, "crc32b w5, w7, w20")]
    [DataRow(new byte[] { 0xfc, 0x47, 0xde, 0x1a }, "crc32h w28, wzr, w30")]
    [DataRow(new byte[] { 0x20, 0x48, 0xc2, 0x1a }, "crc32w w0, w1, w2")]
    [DataRow(new byte[] { 0x27, 0x4d, 0xd4, 0x9a }, "crc32x w7, w9, x20")]
    [DataRow(new byte[] { 0xa9, 0x50, 0xc4, 0x1a }, "crc32cb w9, w5, w4")]
    [DataRow(new byte[] { 0x2d, 0x56, 0xd9, 0x1a }, "crc32ch w13, w17, w25")]
    [DataRow(new byte[] { 0x7f, 0x58, 0xc5, 0x1a }, "crc32cw wzr, w3, w5")]
    [DataRow(new byte[] { 0x12, 0x5e, 0xdf, 0x9a }, "crc32cx w18, w16, xzr")]
    public void arm64_basic_a64_instructions_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
