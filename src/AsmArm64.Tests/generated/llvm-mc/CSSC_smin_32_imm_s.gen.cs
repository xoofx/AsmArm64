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
    [DataRow(new byte[] { 0x00, 0x00, 0xc8, 0x11 }, "smin w0, w0, #0")]
    [DataRow(new byte[] { 0x55, 0x55, 0xc9, 0x11 }, "smin w21, w10, #85")]
    [DataRow(new byte[] { 0xb7, 0xed, 0xc8, 0x11 }, "smin w23, w13, #59")]
    [DataRow(new byte[] { 0xff, 0xff, 0xcb, 0x11 }, "smin wzr, wzr, #-1")]
    public void CSSC_smin_32_imm_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
