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
    [DataRow(new byte[] { 0x00, 0x68, 0xc0, 0x9a }, "smin x0, x0, x0")]
    [DataRow(new byte[] { 0x55, 0x69, 0xd5, 0x9a }, "smin x21, x10, x21")]
    [DataRow(new byte[] { 0xb7, 0x69, 0xc8, 0x9a }, "smin x23, x13, x8")]
    [DataRow(new byte[] { 0xff, 0x6b, 0xdf, 0x9a }, "smin xzr, xzr, xzr")]
    public void CSSC_smin_64_reg_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
