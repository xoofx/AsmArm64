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
    [DataRow(new byte[] { 0x00, 0x20, 0x58, 0xd5 }, "msrr TTBR0_EL1, x0, x1")]
    [DataRow(new byte[] { 0x20, 0x20, 0x58, 0xd5 }, "msrr TTBR1_EL1, x0, x1")]
    [DataRow(new byte[] { 0x00, 0x74, 0x58, 0xd5 }, "msrr PAR_EL1, x0, x1")]
    [DataRow(new byte[] { 0x60, 0xd0, 0x58, 0xd5 }, "msrr RCWSMASK_EL1, x0, x1")]
    [DataRow(new byte[] { 0xc0, 0xd0, 0x58, 0xd5 }, "msrr RCWMASK_EL1, x0, x1")]
    [DataRow(new byte[] { 0x00, 0x20, 0x5c, 0xd5 }, "msrr TTBR0_EL2, x0, x1")]
    [DataRow(new byte[] { 0x20, 0x20, 0x5c, 0xd5 }, "msrr TTBR1_EL2, x0, x1")]
    [DataRow(new byte[] { 0x00, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x0, x1")]
    [DataRow(new byte[] { 0x00, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x0, x1")]
    [DataRow(new byte[] { 0x02, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x2, x3")]
    [DataRow(new byte[] { 0x04, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x4, x5")]
    [DataRow(new byte[] { 0x06, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x6, x7")]
    [DataRow(new byte[] { 0x08, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x8, x9")]
    [DataRow(new byte[] { 0x0a, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x10, x11")]
    [DataRow(new byte[] { 0x0c, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x12, x13")]
    [DataRow(new byte[] { 0x0e, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x14, x15")]
    [DataRow(new byte[] { 0x10, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x16, x17")]
    [DataRow(new byte[] { 0x12, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x18, x19")]
    [DataRow(new byte[] { 0x14, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x20, x21")]
    [DataRow(new byte[] { 0x16, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x22, x23")]
    [DataRow(new byte[] { 0x18, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x24, x25")]
    [DataRow(new byte[] { 0x1a, 0x21, 0x5c, 0xd5 }, "msrr VTTBR_EL2, x26, x27")]
    public void armv9_msrr_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
