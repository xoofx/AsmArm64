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
    [DataRow(new byte[] { 0xf1, 0x57, 0xe8, 0x5e }, "srshl d17, d31, d8")]
    [DataRow(new byte[] { 0xf1, 0x57, 0xe8, 0x7e }, "urshl d17, d31, d8")]
    public void neon_scalar_rounding_shift_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
