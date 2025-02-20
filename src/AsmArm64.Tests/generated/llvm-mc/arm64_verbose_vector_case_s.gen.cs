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
    [DataRow(new byte[] { 0x08, 0xe1, 0x28, 0x0e }, "pmull v8.8h, v8.8b, v8.8b")]
    [DataRow(new byte[] { 0x08, 0xe1, 0x28, 0x4e }, "pmull2 v8.8h, v8.16b, v8.16b")]
    [DataRow(new byte[] { 0x08, 0xe1, 0xe8, 0x0e }, "pmull v8.1q, v8.1d, v8.1d")]
    [DataRow(new byte[] { 0x08, 0xe1, 0xe8, 0x4e }, "pmull2 v8.1q, v8.2d, v8.2d")]
    [DataRow(new byte[] { 0x08, 0xe1, 0x28, 0x0e }, "pmull v8.8h, v8.8b, v8.8b")]
    [DataRow(new byte[] { 0x08, 0xe1, 0x28, 0x4e }, "pmull2 v8.8h, v8.16b, v8.16b")]
    [DataRow(new byte[] { 0x08, 0xe1, 0xe8, 0x0e }, "pmull v8.1q, v8.1d, v8.1d")]
    [DataRow(new byte[] { 0x08, 0xe1, 0xe8, 0x4e }, "pmull2 v8.1q, v8.2d, v8.2d")]
    public void arm64_verbose_vector_case_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
