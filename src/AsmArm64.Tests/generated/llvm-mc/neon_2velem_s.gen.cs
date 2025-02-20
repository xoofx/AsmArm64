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
    [DataRow(new byte[] { 0x20, 0x08, 0x82, 0x2f }, "mla v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x08, 0x96, 0x2f }, "mla v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x03, 0x01, 0xa2, 0x6f }, "mla v3.4s, v8.4s, v2.s[1]")]
    [DataRow(new byte[] { 0x03, 0x09, 0xb6, 0x6f }, "mla v3.4s, v8.4s, v22.s[3]")]
    [DataRow(new byte[] { 0x20, 0x00, 0x62, 0x2f }, "mla v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x00, 0x6f, 0x2f }, "mla v0.4h, v1.4h, v15.h[2]")]
    [DataRow(new byte[] { 0x20, 0x08, 0x72, 0x6f }, "mla v0.8h, v1.8h, v2.h[7]")]
    [DataRow(new byte[] { 0x20, 0x08, 0x6e, 0x6f }, "mla v0.8h, v1.8h, v14.h[6]")]
    [DataRow(new byte[] { 0x20, 0x48, 0x82, 0x2f }, "mls v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x48, 0x96, 0x2f }, "mls v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x03, 0x41, 0xa2, 0x6f }, "mls v3.4s, v8.4s, v2.s[1]")]
    [DataRow(new byte[] { 0x03, 0x49, 0xb6, 0x6f }, "mls v3.4s, v8.4s, v22.s[3]")]
    [DataRow(new byte[] { 0x20, 0x40, 0x62, 0x2f }, "mls v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x40, 0x6f, 0x2f }, "mls v0.4h, v1.4h, v15.h[2]")]
    [DataRow(new byte[] { 0x20, 0x48, 0x72, 0x6f }, "mls v0.8h, v1.8h, v2.h[7]")]
    [DataRow(new byte[] { 0x20, 0x48, 0x6e, 0x6f }, "mls v0.8h, v1.8h, v14.h[6]")]
    [DataRow(new byte[] { 0x20, 0x10, 0x22, 0x0f }, "fmla v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x03, 0x11, 0x12, 0x4f }, "fmla v3.8h, v8.8h, v2.h[1]")]
    [DataRow(new byte[] { 0x20, 0x18, 0x82, 0x0f }, "fmla v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x18, 0x96, 0x0f }, "fmla v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x03, 0x11, 0xa2, 0x4f }, "fmla v3.4s, v8.4s, v2.s[1]")]
    [DataRow(new byte[] { 0x03, 0x19, 0xb6, 0x4f }, "fmla v3.4s, v8.4s, v22.s[3]")]
    [DataRow(new byte[] { 0x20, 0x18, 0xc2, 0x4f }, "fmla v0.2d, v1.2d, v2.d[1]")]
    [DataRow(new byte[] { 0x20, 0x18, 0xd6, 0x4f }, "fmla v0.2d, v1.2d, v22.d[1]")]
    [DataRow(new byte[] { 0x20, 0x50, 0x22, 0x0f }, "fmls v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x03, 0x51, 0x12, 0x4f }, "fmls v3.8h, v8.8h, v2.h[1]")]
    [DataRow(new byte[] { 0x20, 0x58, 0x82, 0x0f }, "fmls v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x58, 0x96, 0x0f }, "fmls v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x03, 0x51, 0xa2, 0x4f }, "fmls v3.4s, v8.4s, v2.s[1]")]
    [DataRow(new byte[] { 0x03, 0x59, 0xb6, 0x4f }, "fmls v3.4s, v8.4s, v22.s[3]")]
    [DataRow(new byte[] { 0x20, 0x58, 0xc2, 0x4f }, "fmls v0.2d, v1.2d, v2.d[1]")]
    [DataRow(new byte[] { 0x20, 0x58, 0xd6, 0x4f }, "fmls v0.2d, v1.2d, v22.d[1]")]
    [DataRow(new byte[] { 0x20, 0x20, 0x62, 0x0f }, "smlal v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x82, 0x0f }, "smlal v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x96, 0x0f }, "smlal v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x20, 0x61, 0x4f }, "smlal2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x81, 0x4f }, "smlal2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x96, 0x4f }, "smlal2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x60, 0x62, 0x0f }, "smlsl v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x82, 0x0f }, "smlsl v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x96, 0x0f }, "smlsl v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x60, 0x61, 0x4f }, "smlsl2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x81, 0x4f }, "smlsl2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x96, 0x4f }, "smlsl2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x30, 0x62, 0x0f }, "sqdmlal v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x38, 0x82, 0x0f }, "sqdmlal v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x38, 0x96, 0x0f }, "sqdmlal v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x30, 0x61, 0x4f }, "sqdmlal2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x38, 0x81, 0x4f }, "sqdmlal2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x38, 0x96, 0x4f }, "sqdmlal2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x20, 0x62, 0x2f }, "umlal v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x82, 0x2f }, "umlal v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x96, 0x2f }, "umlal v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x20, 0x61, 0x6f }, "umlal2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x81, 0x6f }, "umlal2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x28, 0x96, 0x6f }, "umlal2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x60, 0x62, 0x2f }, "umlsl v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x82, 0x2f }, "umlsl v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x96, 0x2f }, "umlsl v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x60, 0x61, 0x6f }, "umlsl2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x81, 0x6f }, "umlsl2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x68, 0x96, 0x6f }, "umlsl2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x70, 0x62, 0x0f }, "sqdmlsl v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x78, 0x82, 0x0f }, "sqdmlsl v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x78, 0x96, 0x0f }, "sqdmlsl v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x70, 0x61, 0x4f }, "sqdmlsl2 v0.4s, v1.8h, v1.h[2]")]
    [DataRow(new byte[] { 0x20, 0x78, 0x81, 0x4f }, "sqdmlsl2 v0.2d, v1.4s, v1.s[2]")]
    [DataRow(new byte[] { 0x20, 0x78, 0x96, 0x4f }, "sqdmlsl2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x80, 0x62, 0x0f }, "mul v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x80, 0x62, 0x4f }, "mul v0.8h, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x88, 0x82, 0x0f }, "mul v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x88, 0x96, 0x0f }, "mul v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x88, 0x82, 0x4f }, "mul v0.4s, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x88, 0x96, 0x4f }, "mul v0.4s, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x90, 0x22, 0x0f }, "fmul v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x90, 0x22, 0x4f }, "fmul v0.8h, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x82, 0x0f }, "fmul v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x96, 0x0f }, "fmul v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x82, 0x4f }, "fmul v0.4s, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x96, 0x4f }, "fmul v0.4s, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0xc2, 0x4f }, "fmul v0.2d, v1.2d, v2.d[1]")]
    [DataRow(new byte[] { 0x20, 0x98, 0xd6, 0x4f }, "fmul v0.2d, v1.2d, v22.d[1]")]
    [DataRow(new byte[] { 0x20, 0x90, 0x22, 0x2f }, "fmulx v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x90, 0x22, 0x6f }, "fmulx v0.8h, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x82, 0x2f }, "fmulx v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x96, 0x2f }, "fmulx v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x82, 0x6f }, "fmulx v0.4s, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0x96, 0x6f }, "fmulx v0.4s, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0x98, 0xc2, 0x6f }, "fmulx v0.2d, v1.2d, v2.d[1]")]
    [DataRow(new byte[] { 0x20, 0x98, 0xd6, 0x6f }, "fmulx v0.2d, v1.2d, v22.d[1]")]
    [DataRow(new byte[] { 0x20, 0xa0, 0x62, 0x0f }, "smull v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x82, 0x0f }, "smull v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x96, 0x0f }, "smull v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa0, 0x62, 0x4f }, "smull2 v0.4s, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x82, 0x4f }, "smull2 v0.2d, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x96, 0x4f }, "smull2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa0, 0x62, 0x2f }, "umull v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x82, 0x2f }, "umull v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x96, 0x2f }, "umull v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa0, 0x62, 0x6f }, "umull2 v0.4s, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x82, 0x6f }, "umull2 v0.2d, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xa8, 0x96, 0x6f }, "umull2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xb0, 0x62, 0x0f }, "sqdmull v0.4s, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xb8, 0x82, 0x0f }, "sqdmull v0.2d, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xb8, 0x96, 0x0f }, "sqdmull v0.2d, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xb0, 0x62, 0x4f }, "sqdmull2 v0.4s, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xb8, 0x82, 0x4f }, "sqdmull2 v0.2d, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xb8, 0x96, 0x4f }, "sqdmull2 v0.2d, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xc0, 0x62, 0x0f }, "sqdmulh v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xc0, 0x62, 0x4f }, "sqdmulh v0.8h, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xc8, 0x82, 0x0f }, "sqdmulh v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xc8, 0x96, 0x0f }, "sqdmulh v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xc8, 0x82, 0x4f }, "sqdmulh v0.4s, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xc8, 0x96, 0x4f }, "sqdmulh v0.4s, v1.4s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xd0, 0x62, 0x0f }, "sqrdmulh v0.4h, v1.4h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xd0, 0x62, 0x4f }, "sqrdmulh v0.8h, v1.8h, v2.h[2]")]
    [DataRow(new byte[] { 0x20, 0xd8, 0x82, 0x0f }, "sqrdmulh v0.2s, v1.2s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xd8, 0x96, 0x0f }, "sqrdmulh v0.2s, v1.2s, v22.s[2]")]
    [DataRow(new byte[] { 0x20, 0xd8, 0x82, 0x4f }, "sqrdmulh v0.4s, v1.4s, v2.s[2]")]
    [DataRow(new byte[] { 0x20, 0xd8, 0x96, 0x4f }, "sqrdmulh v0.4s, v1.4s, v22.s[2]")]
    public void neon_2velem_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
