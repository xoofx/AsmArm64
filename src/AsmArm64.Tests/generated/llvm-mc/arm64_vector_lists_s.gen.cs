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
    [DataRow(new byte[] { 0x00, 0x00, 0x00, 0x0c }, "st4 {v0.8b, v1.8b, v2.8b, v3.8b}, [x0]")]
    [DataRow(new byte[] { 0x00, 0x04, 0x00, 0x0c }, "st4 {v0.4h, v1.4h, v2.4h, v3.4h}, [x0]")]
    public void arm64_vector_lists_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
