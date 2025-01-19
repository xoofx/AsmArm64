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
    [DataRow(new byte[] { 0x20, 0xa4, 0x22, 0x0e }, "smaxp v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x22, 0x4e }, "smaxp v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x62, 0x0e }, "smaxp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x62, 0x4e }, "smaxp v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0xa4, 0xa2, 0x0e }, "smaxp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0xa4, 0xa2, 0x4e }, "smaxp v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x22, 0x2e }, "umaxp v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x22, 0x6e }, "umaxp v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x62, 0x2e }, "umaxp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0xa4, 0x62, 0x6e }, "umaxp v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0xa4, 0xa2, 0x2e }, "umaxp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0xa4, 0xa2, 0x6e }, "umaxp v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0xac, 0x22, 0x0e }, "sminp v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0xac, 0x22, 0x4e }, "sminp v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0xac, 0x62, 0x0e }, "sminp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0xac, 0x62, 0x4e }, "sminp v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0xac, 0xa2, 0x0e }, "sminp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0xac, 0xa2, 0x4e }, "sminp v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0xac, 0x22, 0x2e }, "uminp v0.8b, v1.8b, v2.8b")]
    [DataRow(new byte[] { 0x20, 0xac, 0x22, 0x6e }, "uminp v0.16b, v1.16b, v2.16b")]
    [DataRow(new byte[] { 0x20, 0xac, 0x62, 0x2e }, "uminp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0x20, 0xac, 0x62, 0x6e }, "uminp v0.8h, v1.8h, v2.8h")]
    [DataRow(new byte[] { 0x20, 0xac, 0xa2, 0x2e }, "uminp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0x20, 0xac, 0xa2, 0x6e }, "uminp v0.4s, v1.4s, v2.4s")]
    [DataRow(new byte[] { 0x20, 0x34, 0x42, 0x2e }, "fmaxp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0xff, 0x35, 0x50, 0x6e }, "fmaxp v31.8h, v15.8h, v16.8h")]
    [DataRow(new byte[] { 0x20, 0xf4, 0x22, 0x2e }, "fmaxp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0xff, 0xf5, 0x30, 0x6e }, "fmaxp v31.4s, v15.4s, v16.4s")]
    [DataRow(new byte[] { 0x07, 0xf5, 0x79, 0x6e }, "fmaxp v7.2d, v8.2d, v25.2d")]
    [DataRow(new byte[] { 0xea, 0x35, 0xd6, 0x2e }, "fminp v10.4h, v15.4h, v22.4h")]
    [DataRow(new byte[] { 0xa3, 0x34, 0xc6, 0x6e }, "fminp v3.8h, v5.8h, v6.8h")]
    [DataRow(new byte[] { 0xea, 0xf5, 0xb6, 0x2e }, "fminp v10.2s, v15.2s, v22.2s")]
    [DataRow(new byte[] { 0xa3, 0xf4, 0xa6, 0x6e }, "fminp v3.4s, v5.4s, v6.4s")]
    [DataRow(new byte[] { 0xb1, 0xf5, 0xe2, 0x6e }, "fminp v17.2d, v13.2d, v2.2d")]
    [DataRow(new byte[] { 0x20, 0x04, 0x42, 0x2e }, "fmaxnmp v0.4h, v1.4h, v2.4h")]
    [DataRow(new byte[] { 0xff, 0x05, 0x50, 0x6e }, "fmaxnmp v31.8h, v15.8h, v16.8h")]
    [DataRow(new byte[] { 0x20, 0xc4, 0x22, 0x2e }, "fmaxnmp v0.2s, v1.2s, v2.2s")]
    [DataRow(new byte[] { 0xff, 0xc5, 0x30, 0x6e }, "fmaxnmp v31.4s, v15.4s, v16.4s")]
    [DataRow(new byte[] { 0x07, 0xc5, 0x79, 0x6e }, "fmaxnmp v7.2d, v8.2d, v25.2d")]
    [DataRow(new byte[] { 0xea, 0x05, 0xd6, 0x2e }, "fminnmp v10.4h, v15.4h, v22.4h")]
    [DataRow(new byte[] { 0xa3, 0x04, 0xc6, 0x6e }, "fminnmp v3.8h, v5.8h, v6.8h")]
    [DataRow(new byte[] { 0xea, 0xc5, 0xb6, 0x2e }, "fminnmp v10.2s, v15.2s, v22.2s")]
    [DataRow(new byte[] { 0xa3, 0xc4, 0xa6, 0x6e }, "fminnmp v3.4s, v5.4s, v6.4s")]
    [DataRow(new byte[] { 0xb1, 0xc5, 0xe2, 0x6e }, "fminnmp v17.2d, v13.2d, v2.2d")]
    public void neon_max_min_pairwise_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
