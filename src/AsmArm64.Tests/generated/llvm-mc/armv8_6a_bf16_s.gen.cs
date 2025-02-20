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
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x2e }, "bfdot v2.2s, v3.4h, v4.4h")]
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x6e }, "bfdot v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xec, 0x44, 0x6e }, "bfmmla v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x83, 0xec, 0x45, 0x6e }, "bfmmla v3.4s, v4.8h, v5.8h")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x0e }, "bfcvtn v5.4h, v5.4s")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x4e }, "bfcvtn2 v5.8h, v5.4s")]
    [DataRow(new byte[] { 0x65, 0x40, 0x63, 0x1e }, "bfcvt h5, s3")]
    [DataRow(new byte[] { 0xaa, 0xfe, 0xce, 0x2e }, "bfmlalb v10.4s, v21.8h, v14.8h")]
    [DataRow(new byte[] { 0xd5, 0xfd, 0xca, 0x6e }, "bfmlalt v21.4s, v14.8h, v10.8h")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xda, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[1]")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xea, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[2]")]
    [DataRow(new byte[] { 0xae, 0xfa, 0xfa, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[7]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xde, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[1]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xee, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[2]")]
    [DataRow(new byte[] { 0x55, 0xf9, 0xfe, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[7]")]
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x2e }, "bfdot v2.2s, v3.4h, v4.4h")]
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x6e }, "bfdot v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xec, 0x44, 0x6e }, "bfmmla v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x83, 0xec, 0x45, 0x6e }, "bfmmla v3.4s, v4.8h, v5.8h")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x0e }, "bfcvtn v5.4h, v5.4s")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x4e }, "bfcvtn2 v5.8h, v5.4s")]
    [DataRow(new byte[] { 0x65, 0x40, 0x63, 0x1e }, "bfcvt h5, s3")]
    [DataRow(new byte[] { 0xaa, 0xfe, 0xce, 0x2e }, "bfmlalb v10.4s, v21.8h, v14.8h")]
    [DataRow(new byte[] { 0xd5, 0xfd, 0xca, 0x6e }, "bfmlalt v21.4s, v14.8h, v10.8h")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xda, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[1]")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xea, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[2]")]
    [DataRow(new byte[] { 0xae, 0xfa, 0xfa, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[7]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xde, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[1]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xee, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[2]")]
    [DataRow(new byte[] { 0x55, 0xf9, 0xfe, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[7]")]
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x2e }, "bfdot v2.2s, v3.4h, v4.4h")]
    [DataRow(new byte[] { 0x62, 0xfc, 0x44, 0x6e }, "bfdot v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x0f }, "bfdot v2.2s, v3.4h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[0]")]
    [DataRow(new byte[] { 0x62, 0xf0, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[1]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x44, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[2]")]
    [DataRow(new byte[] { 0x62, 0xf8, 0x64, 0x4f }, "bfdot v2.4s, v3.8h, v4.2h[3]")]
    [DataRow(new byte[] { 0x62, 0xec, 0x44, 0x6e }, "bfmmla v2.4s, v3.8h, v4.8h")]
    [DataRow(new byte[] { 0x83, 0xec, 0x45, 0x6e }, "bfmmla v3.4s, v4.8h, v5.8h")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x0e }, "bfcvtn v5.4h, v5.4s")]
    [DataRow(new byte[] { 0xa5, 0x68, 0xa1, 0x4e }, "bfcvtn2 v5.8h, v5.4s")]
    [DataRow(new byte[] { 0x65, 0x40, 0x63, 0x1e }, "bfcvt h5, s3")]
    [DataRow(new byte[] { 0xaa, 0xfe, 0xce, 0x2e }, "bfmlalb v10.4s, v21.8h, v14.8h")]
    [DataRow(new byte[] { 0xd5, 0xfd, 0xca, 0x6e }, "bfmlalt v21.4s, v14.8h, v10.8h")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xda, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[1]")]
    [DataRow(new byte[] { 0xae, 0xf2, 0xea, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[2]")]
    [DataRow(new byte[] { 0xae, 0xfa, 0xfa, 0x0f }, "bfmlalb v14.4s, v21.8h, v10.h[7]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xde, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[1]")]
    [DataRow(new byte[] { 0x55, 0xf1, 0xee, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[2]")]
    [DataRow(new byte[] { 0x55, 0xf9, 0xfe, 0x4f }, "bfmlalt v21.4s, v10.8h, v14.h[7]")]
    public void armv8_6a_bf16_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
