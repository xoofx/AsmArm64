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
    [DataRow(new byte[] { 0xe0, 0x0b, 0x20, 0x4e }, "rev64 v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x08, 0x60, 0x4e }, "rev64 v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x09, 0xa0, 0x4e }, "rev64 v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x21, 0x09, 0x20, 0x0e }, "rev64 v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x0a, 0x60, 0x0e }, "rev64 v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x08, 0xa0, 0x0e }, "rev64 v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xfe, 0x0b, 0x20, 0x6e }, "rev32 v30.16b, v31.16b")]
    [DataRow(new byte[] { 0xe4, 0x08, 0x60, 0x6e }, "rev32 v4.8h, v7.8h")]
    [DataRow(new byte[] { 0x35, 0x08, 0x20, 0x2e }, "rev32 v21.8b, v1.8b")]
    [DataRow(new byte[] { 0x20, 0x09, 0x60, 0x2e }, "rev32 v0.4h, v9.4h")]
    [DataRow(new byte[] { 0xfe, 0x1b, 0x20, 0x4e }, "rev16 v30.16b, v31.16b")]
    [DataRow(new byte[] { 0x35, 0x18, 0x20, 0x0e }, "rev16 v21.8b, v1.8b")]
    [DataRow(new byte[] { 0xa3, 0x2a, 0x20, 0x4e }, "saddlp v3.8h, v21.16b")]
    [DataRow(new byte[] { 0xa8, 0x28, 0x20, 0x0e }, "saddlp v8.4h, v5.8b")]
    [DataRow(new byte[] { 0x29, 0x28, 0x60, 0x4e }, "saddlp v9.4s, v1.8h")]
    [DataRow(new byte[] { 0x20, 0x28, 0x60, 0x0e }, "saddlp v0.2s, v1.4h")]
    [DataRow(new byte[] { 0x8c, 0x28, 0xa0, 0x4e }, "saddlp v12.2d, v4.4s")]
    [DataRow(new byte[] { 0x91, 0x2b, 0xa0, 0x0e }, "saddlp v17.1d, v28.2s")]
    [DataRow(new byte[] { 0xa3, 0x2a, 0x20, 0x6e }, "uaddlp v3.8h, v21.16b")]
    [DataRow(new byte[] { 0xa8, 0x28, 0x20, 0x2e }, "uaddlp v8.4h, v5.8b")]
    [DataRow(new byte[] { 0x29, 0x28, 0x60, 0x6e }, "uaddlp v9.4s, v1.8h")]
    [DataRow(new byte[] { 0x20, 0x28, 0x60, 0x2e }, "uaddlp v0.2s, v1.4h")]
    [DataRow(new byte[] { 0x8c, 0x28, 0xa0, 0x6e }, "uaddlp v12.2d, v4.4s")]
    [DataRow(new byte[] { 0x91, 0x2b, 0xa0, 0x2e }, "uaddlp v17.1d, v28.2s")]
    [DataRow(new byte[] { 0xa3, 0x6a, 0x20, 0x4e }, "sadalp v3.8h, v21.16b")]
    [DataRow(new byte[] { 0xa8, 0x68, 0x20, 0x0e }, "sadalp v8.4h, v5.8b")]
    [DataRow(new byte[] { 0x29, 0x68, 0x60, 0x4e }, "sadalp v9.4s, v1.8h")]
    [DataRow(new byte[] { 0x20, 0x68, 0x60, 0x0e }, "sadalp v0.2s, v1.4h")]
    [DataRow(new byte[] { 0x8c, 0x68, 0xa0, 0x4e }, "sadalp v12.2d, v4.4s")]
    [DataRow(new byte[] { 0x91, 0x6b, 0xa0, 0x0e }, "sadalp v17.1d, v28.2s")]
    [DataRow(new byte[] { 0xa3, 0x6a, 0x20, 0x6e }, "uadalp v3.8h, v21.16b")]
    [DataRow(new byte[] { 0xa8, 0x68, 0x20, 0x2e }, "uadalp v8.4h, v5.8b")]
    [DataRow(new byte[] { 0x29, 0x68, 0x60, 0x6e }, "uadalp v9.4s, v1.8h")]
    [DataRow(new byte[] { 0x20, 0x68, 0x60, 0x2e }, "uadalp v0.2s, v1.4h")]
    [DataRow(new byte[] { 0x8c, 0x68, 0xa0, 0x6e }, "uadalp v12.2d, v4.4s")]
    [DataRow(new byte[] { 0x91, 0x6b, 0xa0, 0x2e }, "uadalp v17.1d, v28.2s")]
    [DataRow(new byte[] { 0xe0, 0x3b, 0x20, 0x4e }, "suqadd v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x38, 0x60, 0x4e }, "suqadd v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x39, 0xa0, 0x4e }, "suqadd v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x39, 0xe0, 0x4e }, "suqadd v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x39, 0x20, 0x0e }, "suqadd v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x3a, 0x60, 0x0e }, "suqadd v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x38, 0xa0, 0x0e }, "suqadd v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x3b, 0x20, 0x6e }, "usqadd v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x38, 0x60, 0x6e }, "usqadd v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x39, 0xa0, 0x6e }, "usqadd v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x39, 0xe0, 0x6e }, "usqadd v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x39, 0x20, 0x2e }, "usqadd v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x3a, 0x60, 0x2e }, "usqadd v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x38, 0xa0, 0x2e }, "usqadd v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x7b, 0x20, 0x4e }, "sqabs v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x78, 0x60, 0x4e }, "sqabs v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x79, 0xa0, 0x4e }, "sqabs v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x79, 0xe0, 0x4e }, "sqabs v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x79, 0x20, 0x0e }, "sqabs v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x7a, 0x60, 0x0e }, "sqabs v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x78, 0xa0, 0x0e }, "sqabs v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x7b, 0x20, 0x6e }, "sqneg v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x78, 0x60, 0x6e }, "sqneg v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x79, 0xa0, 0x6e }, "sqneg v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x79, 0xe0, 0x6e }, "sqneg v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x79, 0x20, 0x2e }, "sqneg v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x7a, 0x60, 0x2e }, "sqneg v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x78, 0xa0, 0x2e }, "sqneg v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0xbb, 0x20, 0x4e }, "abs v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0xb8, 0x60, 0x4e }, "abs v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xa0, 0x4e }, "abs v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xe0, 0x4e }, "abs v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0xb9, 0x20, 0x0e }, "abs v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0xba, 0x60, 0x0e }, "abs v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xa0, 0x0e }, "abs v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0xbb, 0x20, 0x6e }, "neg v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0xb8, 0x60, 0x6e }, "neg v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xa0, 0x6e }, "neg v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xe0, 0x6e }, "neg v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x21, 0xb9, 0x20, 0x2e }, "neg v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0xba, 0x60, 0x2e }, "neg v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xa0, 0x2e }, "neg v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x4b, 0x20, 0x4e }, "cls v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x48, 0x60, 0x4e }, "cls v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x49, 0xa0, 0x4e }, "cls v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x21, 0x49, 0x20, 0x0e }, "cls v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x4a, 0x60, 0x0e }, "cls v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x48, 0xa0, 0x0e }, "cls v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x4b, 0x20, 0x6e }, "clz v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x82, 0x48, 0x60, 0x6e }, "clz v2.8h, v4.8h")]
    [DataRow(new byte[] { 0x06, 0x49, 0xa0, 0x6e }, "clz v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x21, 0x49, 0x20, 0x2e }, "clz v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xad, 0x4a, 0x60, 0x2e }, "clz v13.4h, v21.4h")]
    [DataRow(new byte[] { 0x04, 0x48, 0xa0, 0x2e }, "clz v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x5b, 0x20, 0x4e }, "cnt v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x21, 0x59, 0x20, 0x0e }, "cnt v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xe0, 0x5b, 0x20, 0x6e }, "mvn v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x21, 0x59, 0x20, 0x2e }, "mvn v1.8b, v9.8b")]
    [DataRow(new byte[] { 0xe0, 0x5b, 0x60, 0x6e }, "rbit v0.16b, v31.16b")]
    [DataRow(new byte[] { 0x21, 0x59, 0x60, 0x2e }, "rbit v1.8b, v9.8b")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xf8, 0x0e }, "fabs v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xf8, 0x4e }, "fabs v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xa0, 0x4e }, "fabs v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xe0, 0x4e }, "fabs v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xa0, 0x0e }, "fabs v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xf8, 0x2e }, "fneg v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xf8, 0x6e }, "fneg v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xa0, 0x6e }, "fneg v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xe0, 0x6e }, "fneg v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xa0, 0x2e }, "fneg v4.2s, v0.2s")]
    [DataRow(new byte[] { 0xe0, 0x2b, 0x21, 0x4e }, "xtn2 v0.16b, v31.8h")]
    [DataRow(new byte[] { 0x82, 0x28, 0x61, 0x4e }, "xtn2 v2.8h, v4.4s")]
    [DataRow(new byte[] { 0x06, 0x29, 0xa1, 0x4e }, "xtn2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x29, 0x21, 0x0e }, "xtn v1.8b, v9.8h")]
    [DataRow(new byte[] { 0xad, 0x2a, 0x61, 0x0e }, "xtn v13.4h, v21.4s")]
    [DataRow(new byte[] { 0x04, 0x28, 0xa1, 0x0e }, "xtn v4.2s, v0.2d")]
    [DataRow(new byte[] { 0xe0, 0x2b, 0x21, 0x6e }, "sqxtun2 v0.16b, v31.8h")]
    [DataRow(new byte[] { 0x82, 0x28, 0x61, 0x6e }, "sqxtun2 v2.8h, v4.4s")]
    [DataRow(new byte[] { 0x06, 0x29, 0xa1, 0x6e }, "sqxtun2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x29, 0x21, 0x2e }, "sqxtun v1.8b, v9.8h")]
    [DataRow(new byte[] { 0xad, 0x2a, 0x61, 0x2e }, "sqxtun v13.4h, v21.4s")]
    [DataRow(new byte[] { 0x04, 0x28, 0xa1, 0x2e }, "sqxtun v4.2s, v0.2d")]
    [DataRow(new byte[] { 0xe0, 0x4b, 0x21, 0x4e }, "sqxtn2 v0.16b, v31.8h")]
    [DataRow(new byte[] { 0x82, 0x48, 0x61, 0x4e }, "sqxtn2 v2.8h, v4.4s")]
    [DataRow(new byte[] { 0x06, 0x49, 0xa1, 0x4e }, "sqxtn2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x49, 0x21, 0x0e }, "sqxtn v1.8b, v9.8h")]
    [DataRow(new byte[] { 0xad, 0x4a, 0x61, 0x0e }, "sqxtn v13.4h, v21.4s")]
    [DataRow(new byte[] { 0x04, 0x48, 0xa1, 0x0e }, "sqxtn v4.2s, v0.2d")]
    [DataRow(new byte[] { 0xe0, 0x4b, 0x21, 0x6e }, "uqxtn2 v0.16b, v31.8h")]
    [DataRow(new byte[] { 0x82, 0x48, 0x61, 0x6e }, "uqxtn2 v2.8h, v4.4s")]
    [DataRow(new byte[] { 0x06, 0x49, 0xa1, 0x6e }, "uqxtn2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0x21, 0x49, 0x21, 0x2e }, "uqxtn v1.8b, v9.8h")]
    [DataRow(new byte[] { 0xad, 0x4a, 0x61, 0x2e }, "uqxtn v13.4h, v21.4s")]
    [DataRow(new byte[] { 0x04, 0x48, 0xa1, 0x2e }, "uqxtn v4.2s, v0.2d")]
    [DataRow(new byte[] { 0x82, 0x38, 0x21, 0x6e }, "shll2 v2.8h, v4.16b, #8")]
    [DataRow(new byte[] { 0x06, 0x39, 0x61, 0x6e }, "shll2 v6.4s, v8.8h, #16")]
    [DataRow(new byte[] { 0x06, 0x39, 0xa1, 0x6e }, "shll2 v6.2d, v8.4s, #32")]
    [DataRow(new byte[] { 0x82, 0x38, 0x21, 0x2e }, "shll v2.8h, v4.8b, #8")]
    [DataRow(new byte[] { 0x06, 0x39, 0x61, 0x2e }, "shll v6.4s, v8.4h, #16")]
    [DataRow(new byte[] { 0x06, 0x39, 0xa1, 0x2e }, "shll v6.2d, v8.2s, #32")]
    [DataRow(new byte[] { 0x82, 0x68, 0x21, 0x4e }, "fcvtn2 v2.8h, v4.4s")]
    [DataRow(new byte[] { 0x06, 0x69, 0x61, 0x4e }, "fcvtn2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0xad, 0x6a, 0x21, 0x0e }, "fcvtn v13.4h, v21.4s")]
    [DataRow(new byte[] { 0x04, 0x68, 0x61, 0x0e }, "fcvtn v4.2s, v0.2d")]
    [DataRow(new byte[] { 0x06, 0x69, 0x61, 0x6e }, "fcvtxn2 v6.4s, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x68, 0x61, 0x2e }, "fcvtxn v4.2s, v0.2d")]
    [DataRow(new byte[] { 0x29, 0x78, 0x21, 0x0e }, "fcvtl v9.4s, v1.4h")]
    [DataRow(new byte[] { 0x20, 0x78, 0x61, 0x0e }, "fcvtl v0.2d, v1.2s")]
    [DataRow(new byte[] { 0x8c, 0x78, 0x21, 0x4e }, "fcvtl2 v12.4s, v4.8h")]
    [DataRow(new byte[] { 0x91, 0x7b, 0x61, 0x4e }, "fcvtl2 v17.2d, v28.4s")]
    [DataRow(new byte[] { 0x04, 0x88, 0x79, 0x0e }, "frintn v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x89, 0x79, 0x4e }, "frintn v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x89, 0x21, 0x4e }, "frintn v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x89, 0x61, 0x4e }, "frintn v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x88, 0x21, 0x0e }, "frintn v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x88, 0x79, 0x2e }, "frinta v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x89, 0x79, 0x6e }, "frinta v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x89, 0x21, 0x6e }, "frinta v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x89, 0x61, 0x6e }, "frinta v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x88, 0x21, 0x2e }, "frinta v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x88, 0xf9, 0x0e }, "frintp v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x89, 0xf9, 0x4e }, "frintp v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x89, 0xa1, 0x4e }, "frintp v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x89, 0xe1, 0x4e }, "frintp v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x88, 0xa1, 0x0e }, "frintp v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x98, 0x79, 0x0e }, "frintm v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x99, 0x79, 0x4e }, "frintm v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x99, 0x21, 0x4e }, "frintm v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x99, 0x61, 0x4e }, "frintm v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x98, 0x21, 0x0e }, "frintm v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x98, 0x79, 0x2e }, "frintx v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x99, 0x79, 0x6e }, "frintx v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x99, 0x21, 0x6e }, "frintx v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x99, 0x61, 0x6e }, "frintx v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x98, 0x21, 0x2e }, "frintx v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x98, 0xf9, 0x0e }, "frintz v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x99, 0xf9, 0x4e }, "frintz v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x99, 0xa1, 0x4e }, "frintz v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x99, 0xe1, 0x4e }, "frintz v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x98, 0xa1, 0x0e }, "frintz v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0x98, 0xf9, 0x2e }, "frinti v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0x99, 0xf9, 0x6e }, "frinti v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0x99, 0xa1, 0x6e }, "frinti v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0x99, 0xe1, 0x6e }, "frinti v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0x98, 0xa1, 0x2e }, "frinti v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xa8, 0x79, 0x0e }, "fcvtns v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x79, 0x4e }, "fcvtns v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x21, 0x4e }, "fcvtns v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x61, 0x4e }, "fcvtns v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xa8, 0x21, 0x0e }, "fcvtns v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xa8, 0x79, 0x2e }, "fcvtnu v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x79, 0x6e }, "fcvtnu v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x21, 0x6e }, "fcvtnu v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xa9, 0x61, 0x6e }, "fcvtnu v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xa8, 0x21, 0x2e }, "fcvtnu v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xa8, 0xf9, 0x0e }, "fcvtps v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xf9, 0x4e }, "fcvtps v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xa1, 0x4e }, "fcvtps v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xe1, 0x4e }, "fcvtps v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xa8, 0xa1, 0x0e }, "fcvtps v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xa8, 0xf9, 0x2e }, "fcvtpu v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xf9, 0x6e }, "fcvtpu v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xa1, 0x6e }, "fcvtpu v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xa9, 0xe1, 0x6e }, "fcvtpu v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xa8, 0xa1, 0x2e }, "fcvtpu v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xb8, 0x79, 0x0e }, "fcvtms v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x79, 0x4e }, "fcvtms v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x21, 0x4e }, "fcvtms v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x61, 0x4e }, "fcvtms v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xb8, 0x21, 0x0e }, "fcvtms v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xb8, 0x79, 0x2e }, "fcvtmu v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x79, 0x6e }, "fcvtmu v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x21, 0x6e }, "fcvtmu v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0x61, 0x6e }, "fcvtmu v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xb8, 0x21, 0x2e }, "fcvtmu v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xf9, 0x0e }, "fcvtzs v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xf9, 0x4e }, "fcvtzs v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xa1, 0x4e }, "fcvtzs v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xe1, 0x4e }, "fcvtzs v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xa1, 0x0e }, "fcvtzs v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xf9, 0x2e }, "fcvtzu v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xf9, 0x6e }, "fcvtzu v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xa1, 0x6e }, "fcvtzu v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xb9, 0xe1, 0x6e }, "fcvtzu v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xb8, 0xa1, 0x2e }, "fcvtzu v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xc8, 0x79, 0x0e }, "fcvtas v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x79, 0x4e }, "fcvtas v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x21, 0x4e }, "fcvtas v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x61, 0x4e }, "fcvtas v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xc8, 0x21, 0x0e }, "fcvtas v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xc8, 0x79, 0x2e }, "fcvtau v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x79, 0x6e }, "fcvtau v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x21, 0x6e }, "fcvtau v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xc9, 0x61, 0x6e }, "fcvtau v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xc8, 0x21, 0x2e }, "fcvtau v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x06, 0xc9, 0xa1, 0x4e }, "urecpe v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x04, 0xc8, 0xa1, 0x0e }, "urecpe v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x06, 0xc9, 0xa1, 0x6e }, "ursqrte v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x04, 0xc8, 0xa1, 0x2e }, "ursqrte v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xd8, 0x79, 0x0e }, "scvtf v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x79, 0x4e }, "scvtf v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x21, 0x4e }, "scvtf v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x61, 0x4e }, "scvtf v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xd8, 0x21, 0x0e }, "scvtf v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xd8, 0x79, 0x2e }, "ucvtf v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x79, 0x6e }, "ucvtf v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x21, 0x6e }, "ucvtf v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xd9, 0x61, 0x6e }, "ucvtf v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xd8, 0x21, 0x2e }, "ucvtf v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xd8, 0xf9, 0x0e }, "frecpe v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xf9, 0x4e }, "frecpe v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xa1, 0x4e }, "frecpe v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xe1, 0x4e }, "frecpe v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xd8, 0xa1, 0x0e }, "frecpe v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xd8, 0xf9, 0x2e }, "frsqrte v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xf9, 0x6e }, "frsqrte v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xa1, 0x6e }, "frsqrte v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xd9, 0xe1, 0x6e }, "frsqrte v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xd8, 0xa1, 0x2e }, "frsqrte v4.2s, v0.2s")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xf9, 0x2e }, "fsqrt v4.4h, v0.4h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xf9, 0x6e }, "fsqrt v6.8h, v8.8h")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xa1, 0x6e }, "fsqrt v6.4s, v8.4s")]
    [DataRow(new byte[] { 0x06, 0xf9, 0xe1, 0x6e }, "fsqrt v6.2d, v8.2d")]
    [DataRow(new byte[] { 0x04, 0xf8, 0xa1, 0x2e }, "fsqrt v4.2s, v0.2s")]
    public void neon_simd_misc_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
