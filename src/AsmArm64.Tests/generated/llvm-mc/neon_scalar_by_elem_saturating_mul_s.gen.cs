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
    [DataRow(new byte[] { 0x21, 0xb0, 0x51, 0x5f }, "sqdmull s1, h1, v1.h[1]")]
    [DataRow(new byte[] { 0x48, 0xb0, 0x65, 0x5f }, "sqdmull s8, h2, v5.h[2]")]
    [DataRow(new byte[] { 0x2c, 0xb2, 0x79, 0x5f }, "sqdmull s12, h17, v9.h[3]")]
    [DataRow(new byte[] { 0xff, 0xbb, 0x7f, 0x5f }, "sqdmull s31, h31, v15.h[7]")]
    [DataRow(new byte[] { 0x21, 0xb0, 0x84, 0x5f }, "sqdmull d1, s1, v4.s[0]")]
    [DataRow(new byte[] { 0xff, 0xbb, 0xbf, 0x5f }, "sqdmull d31, s31, v31.s[3]")]
    [DataRow(new byte[] { 0x49, 0xb1, 0x8f, 0x5f }, "sqdmull d9, s10, v15.s[0]")]
    [DataRow(new byte[] { 0x20, 0xc0, 0x40, 0x5f }, "sqdmulh h0, h1, v0.h[0]")]
    [DataRow(new byte[] { 0x6a, 0xc9, 0x4a, 0x5f }, "sqdmulh h10, h11, v10.h[4]")]
    [DataRow(new byte[] { 0xb4, 0xca, 0x7f, 0x5f }, "sqdmulh h20, h21, v15.h[7]")]
    [DataRow(new byte[] { 0x59, 0xcb, 0xbb, 0x5f }, "sqdmulh s25, s26, v27.s[3]")]
    [DataRow(new byte[] { 0xc2, 0xc0, 0x87, 0x5f }, "sqdmulh s2, s6, v7.s[0]")]
    [DataRow(new byte[] { 0xdf, 0xd3, 0x6e, 0x5f }, "sqrdmulh h31, h30, v14.h[2]")]
    [DataRow(new byte[] { 0x21, 0xd8, 0x41, 0x5f }, "sqrdmulh h1, h1, v1.h[4]")]
    [DataRow(new byte[] { 0xd5, 0xda, 0x7f, 0x5f }, "sqrdmulh h21, h22, v15.h[7]")]
    [DataRow(new byte[] { 0xc5, 0xd8, 0x87, 0x5f }, "sqrdmulh s5, s6, v7.s[2]")]
    [DataRow(new byte[] { 0x54, 0xd3, 0xbb, 0x5f }, "sqrdmulh s20, s26, v27.s[1]")]
    public void neon_scalar_by_elem_saturating_mul_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
