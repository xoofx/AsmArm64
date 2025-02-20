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
    [DataRow(new byte[] { 0x66, 0x00, 0x80, 0xf9 }, "prfm pldslckeep, [x3]")]
    [DataRow(new byte[] { 0x67, 0x00, 0x80, 0xf9 }, "prfm pldslcstrm, [x3]")]
    [DataRow(new byte[] { 0x6e, 0x00, 0x80, 0xf9 }, "prfm plislckeep, [x3]")]
    [DataRow(new byte[] { 0x6f, 0x00, 0x80, 0xf9 }, "prfm plislcstrm, [x3]")]
    [DataRow(new byte[] { 0x76, 0x00, 0x80, 0xf9 }, "prfm pstslckeep, [x3]")]
    [DataRow(new byte[] { 0x77, 0x00, 0x80, 0xf9 }, "prfm pstslcstrm, [x3]")]
    [DataRow(new byte[] { 0x66, 0x68, 0xa5, 0xf8 }, "prfm pldslckeep, [x3, x5]")]
    [DataRow(new byte[] { 0x66, 0x00, 0x80, 0xf9 }, "prfm pldslckeep, [x3]")]
    [DataRow(new byte[] { 0x67, 0x00, 0x80, 0xf9 }, "prfm pldslcstrm, [x3]")]
    [DataRow(new byte[] { 0x6e, 0x00, 0x80, 0xf9 }, "prfm plislckeep, [x3]")]
    [DataRow(new byte[] { 0x6f, 0x00, 0x80, 0xf9 }, "prfm plislcstrm, [x3]")]
    [DataRow(new byte[] { 0x76, 0x00, 0x80, 0xf9 }, "prfm pstslckeep, [x3]")]
    [DataRow(new byte[] { 0x77, 0x00, 0x80, 0xf9 }, "prfm pstslcstrm, [x3]")]
    [DataRow(new byte[] { 0x66, 0x68, 0xa5, 0xf8 }, "prfm pldslckeep, [x3, x5]")]
    [DataRow(new byte[] { 0x66, 0x00, 0x80, 0xf9 }, "prfm pldslckeep, [x3]")]
    [DataRow(new byte[] { 0x67, 0x00, 0x80, 0xf9 }, "prfm pldslcstrm, [x3]")]
    [DataRow(new byte[] { 0x6e, 0x00, 0x80, 0xf9 }, "prfm plislckeep, [x3]")]
    [DataRow(new byte[] { 0x6f, 0x00, 0x80, 0xf9 }, "prfm plislcstrm, [x3]")]
    [DataRow(new byte[] { 0x76, 0x00, 0x80, 0xf9 }, "prfm pstslckeep, [x3]")]
    [DataRow(new byte[] { 0x77, 0x00, 0x80, 0xf9 }, "prfm pstslcstrm, [x3]")]
    [DataRow(new byte[] { 0x66, 0x68, 0xa5, 0xf8 }, "prfm pldslckeep, [x3, x5]")]
    public void armv8_9a_prfm_slc_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
