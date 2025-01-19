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
    [DataRow(new byte[] { 0x00, 0x20, 0x78, 0xd5 }, "mrrs x0, x1, TTBR0_EL1")]
    [DataRow(new byte[] { 0x20, 0x20, 0x78, 0xd5 }, "mrrs x0, x1, TTBR1_EL1")]
    [DataRow(new byte[] { 0x00, 0x74, 0x78, 0xd5 }, "mrrs x0, x1, PAR_EL1")]
    [DataRow(new byte[] { 0x60, 0xd0, 0x78, 0xd5 }, "mrrs x0, x1, RCWSMASK_EL1")]
    [DataRow(new byte[] { 0xc0, 0xd0, 0x78, 0xd5 }, "mrrs x0, x1, RCWMASK_EL1")]
    [DataRow(new byte[] { 0x00, 0x20, 0x7c, 0xd5 }, "mrrs x0, x1, TTBR0_EL2")]
    [DataRow(new byte[] { 0x20, 0x20, 0x7c, 0xd5 }, "mrrs x0, x1, TTBR1_EL2")]
    [DataRow(new byte[] { 0x00, 0x21, 0x7c, 0xd5 }, "mrrs x0, x1, VTTBR_EL2")]
    [DataRow(new byte[] { 0x00, 0x21, 0x7c, 0xd5 }, "mrrs x0, x1, VTTBR_EL2")]
    [DataRow(new byte[] { 0x02, 0x21, 0x7c, 0xd5 }, "mrrs x2, x3, VTTBR_EL2")]
    [DataRow(new byte[] { 0x04, 0x21, 0x7c, 0xd5 }, "mrrs x4, x5, VTTBR_EL2")]
    [DataRow(new byte[] { 0x06, 0x21, 0x7c, 0xd5 }, "mrrs x6, x7, VTTBR_EL2")]
    [DataRow(new byte[] { 0x08, 0x21, 0x7c, 0xd5 }, "mrrs x8, x9, VTTBR_EL2")]
    [DataRow(new byte[] { 0x0a, 0x21, 0x7c, 0xd5 }, "mrrs x10, x11, VTTBR_EL2")]
    [DataRow(new byte[] { 0x0c, 0x21, 0x7c, 0xd5 }, "mrrs x12, x13, VTTBR_EL2")]
    [DataRow(new byte[] { 0x0e, 0x21, 0x7c, 0xd5 }, "mrrs x14, x15, VTTBR_EL2")]
    [DataRow(new byte[] { 0x10, 0x21, 0x7c, 0xd5 }, "mrrs x16, x17, VTTBR_EL2")]
    [DataRow(new byte[] { 0x12, 0x21, 0x7c, 0xd5 }, "mrrs x18, x19, VTTBR_EL2")]
    [DataRow(new byte[] { 0x14, 0x21, 0x7c, 0xd5 }, "mrrs x20, x21, VTTBR_EL2")]
    [DataRow(new byte[] { 0x16, 0x21, 0x7c, 0xd5 }, "mrrs x22, x23, VTTBR_EL2")]
    [DataRow(new byte[] { 0x18, 0x21, 0x7c, 0xd5 }, "mrrs x24, x25, VTTBR_EL2")]
    [DataRow(new byte[] { 0x1a, 0x21, 0x7c, 0xd5 }, "mrrs x26, x27, VTTBR_EL2")]
    public void armv9_mrrs_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
