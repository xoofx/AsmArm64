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
    [DataRow(new byte[] { 0x89, 0x03, 0x38, 0xd5 }, "mrs x9, ID_PFR2_EL1")]
    [DataRow(new byte[] { 0xe8, 0xd0, 0x3b, 0xd5 }, "mrs x8, SCXTNUM_EL0")]
    [DataRow(new byte[] { 0xe7, 0xd0, 0x38, 0xd5 }, "mrs x7, SCXTNUM_EL1")]
    [DataRow(new byte[] { 0xe6, 0xd0, 0x3c, 0xd5 }, "mrs x6, SCXTNUM_EL2")]
    [DataRow(new byte[] { 0xe5, 0xd0, 0x3e, 0xd5 }, "mrs x5, SCXTNUM_EL3")]
    [DataRow(new byte[] { 0xe4, 0xd0, 0x3d, 0xd5 }, "mrs x4, SCXTNUM_EL12")]
    [DataRow(new byte[] { 0xe8, 0xd0, 0x1b, 0xd5 }, "msr SCXTNUM_EL0, x8")]
    [DataRow(new byte[] { 0xe7, 0xd0, 0x18, 0xd5 }, "msr SCXTNUM_EL1, x7")]
    [DataRow(new byte[] { 0xe6, 0xd0, 0x1c, 0xd5 }, "msr SCXTNUM_EL2, x6")]
    [DataRow(new byte[] { 0xe5, 0xd0, 0x1e, 0xd5 }, "msr SCXTNUM_EL3, x5")]
    [DataRow(new byte[] { 0xe4, 0xd0, 0x1d, 0xd5 }, "msr SCXTNUM_EL12, x4")]
    [DataRow(new byte[] { 0x89, 0x03, 0x38, 0xd5 }, "mrs x9, ID_PFR2_EL1")]
    [DataRow(new byte[] { 0xe8, 0xd0, 0x3b, 0xd5 }, "mrs x8, SCXTNUM_EL0")]
    [DataRow(new byte[] { 0xe7, 0xd0, 0x38, 0xd5 }, "mrs x7, SCXTNUM_EL1")]
    [DataRow(new byte[] { 0xe6, 0xd0, 0x3c, 0xd5 }, "mrs x6, SCXTNUM_EL2")]
    [DataRow(new byte[] { 0xe5, 0xd0, 0x3e, 0xd5 }, "mrs x5, SCXTNUM_EL3")]
    [DataRow(new byte[] { 0xe4, 0xd0, 0x3d, 0xd5 }, "mrs x4, SCXTNUM_EL12")]
    [DataRow(new byte[] { 0xe8, 0xd0, 0x1b, 0xd5 }, "msr SCXTNUM_EL0, x8")]
    [DataRow(new byte[] { 0xe7, 0xd0, 0x18, 0xd5 }, "msr SCXTNUM_EL1, x7")]
    [DataRow(new byte[] { 0xe6, 0xd0, 0x1c, 0xd5 }, "msr SCXTNUM_EL2, x6")]
    [DataRow(new byte[] { 0xe5, 0xd0, 0x1e, 0xd5 }, "msr SCXTNUM_EL3, x5")]
    [DataRow(new byte[] { 0xe4, 0xd0, 0x1d, 0xd5 }, "msr SCXTNUM_EL12, x4")]
    public void armv8_5a_specrestrict_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
