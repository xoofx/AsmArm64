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
    [DataRow(new byte[] { 0x3f, 0x40, 0x00, 0xd5 }, "xaflag")]
    [DataRow(new byte[] { 0x5f, 0x40, 0x00, 0xd5 }, "axflag")]
    public void armv8_5a_altnzcv_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
