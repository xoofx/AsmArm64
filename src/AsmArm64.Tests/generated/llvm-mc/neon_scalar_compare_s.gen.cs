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
    [DataRow(new byte[] { 0xb4, 0x8e, 0xf6, 0x7e }, "cmeq d20, d21, d22")]
    [DataRow(new byte[] { 0xb4, 0x9a, 0xe0, 0x5e }, "cmeq d20, d21, #0")]
    [DataRow(new byte[] { 0xb4, 0x3e, 0xf6, 0x7e }, "cmhs d20, d21, d22")]
    [DataRow(new byte[] { 0xb4, 0x3e, 0xf6, 0x5e }, "cmge d20, d21, d22")]
    [DataRow(new byte[] { 0xb4, 0x8a, 0xe0, 0x7e }, "cmge d20, d21, #0")]
    [DataRow(new byte[] { 0xb4, 0x36, 0xf6, 0x7e }, "cmhi d20, d21, d22")]
    [DataRow(new byte[] { 0xb4, 0x36, 0xf6, 0x5e }, "cmgt d20, d21, d22")]
    [DataRow(new byte[] { 0xb4, 0x8a, 0xe0, 0x5e }, "cmgt d20, d21, #0")]
    [DataRow(new byte[] { 0xb4, 0x9a, 0xe0, 0x7e }, "cmle d20, d21, #0")]
    [DataRow(new byte[] { 0xb4, 0xaa, 0xe0, 0x5e }, "cmlt d20, d21, #0")]
    [DataRow(new byte[] { 0xb4, 0x8e, 0xf6, 0x5e }, "cmtst d20, d21, d22")]
    public void neon_scalar_compare_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
