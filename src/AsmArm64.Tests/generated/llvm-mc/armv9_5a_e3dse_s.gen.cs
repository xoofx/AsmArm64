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
    [DataRow(new byte[] { 0x20, 0xc1, 0x3e, 0xd5 }, "mrs x0, VDISR_EL3")]
    [DataRow(new byte[] { 0x20, 0xc1, 0x1e, 0xd5 }, "msr VDISR_EL3, x0")]
    [DataRow(new byte[] { 0x60, 0x52, 0x3e, 0xd5 }, "mrs x0, VSESR_EL3")]
    [DataRow(new byte[] { 0x60, 0x52, 0x1e, 0xd5 }, "msr VSESR_EL3, x0")]
    public void armv9_5a_e3dse_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
