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
    [DataRow(new byte[] { 0x00, 0x1c, 0xc0, 0x5a }, "cnt w0, w0")]
    [DataRow(new byte[] { 0x55, 0x1d, 0xc0, 0x5a }, "cnt w21, w10")]
    [DataRow(new byte[] { 0xb7, 0x1d, 0xc0, 0x5a }, "cnt w23, w13")]
    [DataRow(new byte[] { 0xff, 0x1f, 0xc0, 0x5a }, "cnt wzr, wzr")]
    public void CSSC_cnt_32_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
