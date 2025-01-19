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
    [DataRow(new byte[] { 0x20, 0x04, 0x22, 0x0e }, "shadd v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0x04, 0x22, 0x4e }, "shadd v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0x04, 0x62, 0x0e }, "shadd v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0x04, 0x62, 0x4e }, "shadd v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0x04, 0xa2, 0x0e }, "shadd v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0x04, 0xa2, 0x4e }, "shadd v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0x04, 0x22, 0x2e }, "uhadd v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0x04, 0x22, 0x6e }, "uhadd v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0x04, 0x62, 0x2e }, "uhadd v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0x04, 0x62, 0x6e }, "uhadd v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0x04, 0xa2, 0x2e }, "uhadd v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0x04, 0xa2, 0x6e }, "uhadd v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0x24, 0x22, 0x0e }, "shsub v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0x24, 0x22, 0x4e }, "shsub v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0x24, 0x62, 0x0e }, "shsub v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0x24, 0x62, 0x4e }, "shsub v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0x24, 0xa2, 0x0e }, "shsub v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0x24, 0xa2, 0x4e }, "shsub v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0x24, 0x22, 0x2e }, "uhsub v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0x24, 0x22, 0x6e }, "uhsub v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0x24, 0x62, 0x2e }, "uhsub v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0x24, 0x62, 0x6e }, "uhsub v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0x24, 0xa2, 0x2e }, "uhsub v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0x24, 0xa2, 0x6e }, "uhsub v0.4s, v1.4s, v2.4s")]
    public void neon_halving_add_sub_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
