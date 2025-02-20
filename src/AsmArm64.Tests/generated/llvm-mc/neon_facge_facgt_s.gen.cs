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
    [DataRow(new byte[] { 0xe0, 0x2f, 0x50, 0x2e }, "facge v0.4h, v31.4h, v16.4h")]
    [DataRow(new byte[] { 0xe4, 0x2c, 0x4f, 0x6e }, "facge v4.8h, v7.8h, v15.8h")]
    [DataRow(new byte[] { 0xe0, 0xef, 0x30, 0x2e }, "facge v0.2s, v31.2s, v16.2s")]
    [DataRow(new byte[] { 0xe4, 0xec, 0x2f, 0x6e }, "facge v4.4s, v7.4s, v15.4s")]
    [DataRow(new byte[] { 0x5d, 0xec, 0x65, 0x6e }, "facge v29.2d, v2.2d, v5.2d")]
    [DataRow(new byte[] { 0xe0, 0x2f, 0x50, 0x2e }, "facge v0.4h, v31.4h, v16.4h")]
    [DataRow(new byte[] { 0xe4, 0x2c, 0x4f, 0x6e }, "facge v4.8h, v7.8h, v15.8h")]
    [DataRow(new byte[] { 0xe0, 0xef, 0x30, 0x2e }, "facge v0.2s, v31.2s, v16.2s")]
    [DataRow(new byte[] { 0xe4, 0xec, 0x2f, 0x6e }, "facge v4.4s, v7.4s, v15.4s")]
    [DataRow(new byte[] { 0x5d, 0xec, 0x65, 0x6e }, "facge v29.2d, v2.2d, v5.2d")]
    [DataRow(new byte[] { 0x03, 0x2d, 0xcc, 0x2e }, "facgt v3.4h, v8.4h, v12.4h")]
    [DataRow(new byte[] { 0xbf, 0x2f, 0xdc, 0x6e }, "facgt v31.8h, v29.8h, v28.8h")]
    [DataRow(new byte[] { 0xbf, 0xef, 0xbc, 0x6e }, "facgt v31.4s, v29.4s, v28.4s")]
    [DataRow(new byte[] { 0x03, 0xed, 0xac, 0x2e }, "facgt v3.2s, v8.2s, v12.2s")]
    [DataRow(new byte[] { 0xf1, 0xed, 0xed, 0x6e }, "facgt v17.2d, v15.2d, v13.2d")]
    [DataRow(new byte[] { 0x03, 0x2d, 0xcc, 0x2e }, "facgt v3.4h, v8.4h, v12.4h")]
    [DataRow(new byte[] { 0xbf, 0x2f, 0xdc, 0x6e }, "facgt v31.8h, v29.8h, v28.8h")]
    [DataRow(new byte[] { 0xbf, 0xef, 0xbc, 0x6e }, "facgt v31.4s, v29.4s, v28.4s")]
    [DataRow(new byte[] { 0x03, 0xed, 0xac, 0x2e }, "facgt v3.2s, v8.2s, v12.2s")]
    [DataRow(new byte[] { 0xf1, 0xed, 0xed, 0x6e }, "facgt v17.2d, v15.2d, v13.2d")]
    public void neon_facge_facgt_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
