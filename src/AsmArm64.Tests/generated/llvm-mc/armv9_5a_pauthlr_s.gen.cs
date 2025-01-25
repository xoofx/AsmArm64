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
    [DataRow(new byte[] { 0x1f, 0x20, 0x03, 0xd5 }, "nop")]
    [DataRow(new byte[] { 0xfe, 0xa3, 0xc1, 0xda }, "paciasppc")]
    [DataRow(new byte[] { 0xfe, 0xa7, 0xc1, 0xda }, "pacibsppc")]
    [DataRow(new byte[] { 0xfe, 0x83, 0xc1, 0xda }, "pacnbiasppc")]
    [DataRow(new byte[] { 0xfe, 0x87, 0xc1, 0xda }, "pacnbibsppc")]
    [DataRow(new byte[] { 0x1f, 0x00, 0xa0, 0xf3 }, "autibsppc #0")]
    [DataRow(new byte[] { 0xff, 0xff, 0xbf, 0xf3 }, "autibsppc #-262140")]
    [DataRow(new byte[] { 0x1e, 0x90, 0xc1, 0xda }, "autiasppcr x0")]
    [DataRow(new byte[] { 0x3e, 0x94, 0xc1, 0xda }, "autibsppcr x1")]
    [DataRow(new byte[] { 0xfe, 0x93, 0xc1, 0xda }, "autiasppcr xzr")]
    [DataRow(new byte[] { 0xfe, 0x97, 0xc1, 0xda }, "autibsppcr xzr")]
    [DataRow(new byte[] { 0xfe, 0x8b, 0xc1, 0xda }, "pacia171615")]
    [DataRow(new byte[] { 0xfe, 0x8f, 0xc1, 0xda }, "pacib171615")]
    [DataRow(new byte[] { 0xfe, 0xbb, 0xc1, 0xda }, "autia171615")]
    [DataRow(new byte[] { 0xfe, 0xbf, 0xc1, 0xda }, "autib171615")]
    [DataRow(new byte[] { 0x1f, 0x00, 0x00, 0x55 }, "retaasppc #0")]
    [DataRow(new byte[] { 0xff, 0xff, 0x1f, 0x55 }, "retaasppc #-262140")]
    [DataRow(new byte[] { 0xe2, 0x0b, 0x5f, 0xd6 }, "retaasppcr x2")]
    [DataRow(new byte[] { 0xe3, 0x0f, 0x5f, 0xd6 }, "retabsppcr x3")]
    [DataRow(new byte[] { 0xff, 0x24, 0x03, 0xd5 }, "pacm")]
    public void armv9_5a_pauthlr_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
