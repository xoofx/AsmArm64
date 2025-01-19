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
    [DataRow(new byte[] { 0x00, 0x00, 0x00, 0x10 }, "adr x0, #0")]
    [DataRow(new byte[] { 0x00, 0x00, 0x00, 0x30 }, "adr x0, #1")]
    [DataRow(new byte[] { 0x00, 0x00, 0x00, 0x90 }, "adrp x0, #0")]
    [DataRow(new byte[] { 0x00, 0x00, 0x00, 0xb0 }, "adrp x0, #4096")]
    public void arm64_adr_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
