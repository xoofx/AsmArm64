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
    [DataRow(new byte[] { 0x00, 0x70, 0xc1, 0x4c }, "ld1 { v0.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x75, 0xc2, 0x4c }, "ld1 { v15.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x7b, 0xdf, 0x4c }, "ld1 { v31.4s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0x7c, 0xdf, 0x4c }, "ld1 { v0.2d }, [x0], #16")]
    [DataRow(new byte[] { 0x00, 0x70, 0xc2, 0x0c }, "ld1 { v0.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x75, 0xc3, 0x0c }, "ld1 { v15.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x7b, 0xdf, 0x0c }, "ld1 { v31.2s }, [sp], #8")]
    [DataRow(new byte[] { 0x00, 0x7c, 0xdf, 0x0c }, "ld1 { v0.1d }, [x0], #8")]
    [DataRow(new byte[] { 0x00, 0xa0, 0xc1, 0x4c }, "ld1 { v0.16b, v1.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0xa5, 0xc2, 0x4c }, "ld1 { v15.8h, v16.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0xab, 0xdf, 0x4c }, "ld1 { v31.4s, v0.4s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0xac, 0xdf, 0x4c }, "ld1 { v0.2d, v1.2d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0xa0, 0xc2, 0x0c }, "ld1 { v0.8b, v1.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0xa5, 0xc3, 0x0c }, "ld1 { v15.4h, v16.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0xab, 0xdf, 0x0c }, "ld1 { v31.2s, v0.2s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0xac, 0xdf, 0x0c }, "ld1 { v0.1d, v1.1d }, [x0], #16")]
    [DataRow(new byte[] { 0x00, 0x60, 0xc1, 0x4c }, "ld1 { v0.16b, v1.16b, v2.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x65, 0xc2, 0x4c }, "ld1 { v15.8h, v16.8h, v17.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x6b, 0xdf, 0x4c }, "ld1 { v31.4s, v0.4s, v1.4s }, [sp], #48")]
    [DataRow(new byte[] { 0x00, 0x6c, 0xdf, 0x4c }, "ld1 { v0.2d, v1.2d, v2.2d }, [x0], #48")]
    [DataRow(new byte[] { 0x00, 0x60, 0xc2, 0x0c }, "ld1 { v0.8b, v1.8b, v2.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x65, 0xc3, 0x0c }, "ld1 { v15.4h, v16.4h, v17.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x6b, 0xdf, 0x0c }, "ld1 { v31.2s, v0.2s, v1.2s }, [sp], #24")]
    [DataRow(new byte[] { 0x00, 0x6c, 0xdf, 0x0c }, "ld1 { v0.1d, v1.1d, v2.1d }, [x0], #24")]
    [DataRow(new byte[] { 0x00, 0x20, 0xc1, 0x4c }, "ld1 { v0.16b, v1.16b, v2.16b, v3.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x25, 0xc2, 0x4c }, "ld1 { v15.8h, v16.8h, v17.8h, v18.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x2b, 0xdf, 0x4c }, "ld1 { v31.4s, v0.4s, v1.4s, v2.4s }, [sp], #64")]
    [DataRow(new byte[] { 0x00, 0x2c, 0xdf, 0x4c }, "ld1 { v0.2d, v1.2d, v2.2d, v3.2d }, [x0], #64")]
    [DataRow(new byte[] { 0x00, 0x20, 0xc3, 0x0c }, "ld1 { v0.8b, v1.8b, v2.8b, v3.8b }, [x0], x3")]
    [DataRow(new byte[] { 0xef, 0x25, 0xc4, 0x0c }, "ld1 { v15.4h, v16.4h, v17.4h, v18.4h }, [x15], x4")]
    [DataRow(new byte[] { 0xff, 0x2b, 0xdf, 0x0c }, "ld1 { v31.2s, v0.2s, v1.2s, v2.2s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0x2c, 0xdf, 0x0c }, "ld1 { v0.1d, v1.1d, v2.1d, v3.1d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0x80, 0xc1, 0x4c }, "ld2 { v0.16b, v1.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x85, 0xc2, 0x4c }, "ld2 { v15.8h, v16.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x8b, 0xdf, 0x4c }, "ld2 { v31.4s, v0.4s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0x8c, 0xdf, 0x4c }, "ld2 { v0.2d, v1.2d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0x80, 0xc2, 0x0c }, "ld2 { v0.8b, v1.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x85, 0xc3, 0x0c }, "ld2 { v15.4h, v16.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x8b, 0xdf, 0x0c }, "ld2 { v31.2s, v0.2s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0x40, 0xc1, 0x4c }, "ld3 { v0.16b, v1.16b, v2.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x45, 0xc2, 0x4c }, "ld3 { v15.8h, v16.8h, v17.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x4b, 0xdf, 0x4c }, "ld3 { v31.4s, v0.4s, v1.4s }, [sp], #48")]
    [DataRow(new byte[] { 0x00, 0x4c, 0xdf, 0x4c }, "ld3 { v0.2d, v1.2d, v2.2d }, [x0], #48")]
    [DataRow(new byte[] { 0x00, 0x40, 0xc2, 0x0c }, "ld3 { v0.8b, v1.8b, v2.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x45, 0xc3, 0x0c }, "ld3 { v15.4h, v16.4h, v17.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x4b, 0xdf, 0x0c }, "ld3 { v31.2s, v0.2s, v1.2s }, [sp], #24")]
    [DataRow(new byte[] { 0x00, 0x00, 0xc1, 0x4c }, "ld4 { v0.16b, v1.16b, v2.16b, v3.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x05, 0xc2, 0x4c }, "ld4 { v15.8h, v16.8h, v17.8h, v18.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x0b, 0xdf, 0x4c }, "ld4 { v31.4s, v0.4s, v1.4s, v2.4s }, [sp], #64")]
    [DataRow(new byte[] { 0x00, 0x0c, 0xdf, 0x4c }, "ld4 { v0.2d, v1.2d, v2.2d, v3.2d }, [x0], #64")]
    [DataRow(new byte[] { 0x00, 0x00, 0xc3, 0x0c }, "ld4 { v0.8b, v1.8b, v2.8b, v3.8b }, [x0], x3")]
    [DataRow(new byte[] { 0xef, 0x05, 0xc4, 0x0c }, "ld4 { v15.4h, v16.4h, v17.4h, v18.4h }, [x15], x4")]
    [DataRow(new byte[] { 0xff, 0x0b, 0xdf, 0x0c }, "ld4 { v31.2s, v0.2s, v1.2s, v2.2s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0x70, 0x81, 0x4c }, "st1 { v0.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x75, 0x82, 0x4c }, "st1 { v15.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x7b, 0x9f, 0x4c }, "st1 { v31.4s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0x7c, 0x9f, 0x4c }, "st1 { v0.2d }, [x0], #16")]
    [DataRow(new byte[] { 0x00, 0x70, 0x82, 0x0c }, "st1 { v0.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x75, 0x83, 0x0c }, "st1 { v15.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x7b, 0x9f, 0x0c }, "st1 { v31.2s }, [sp], #8")]
    [DataRow(new byte[] { 0x00, 0x7c, 0x9f, 0x0c }, "st1 { v0.1d }, [x0], #8")]
    [DataRow(new byte[] { 0x00, 0xa0, 0x81, 0x4c }, "st1 { v0.16b, v1.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0xa5, 0x82, 0x4c }, "st1 { v15.8h, v16.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0xab, 0x9f, 0x4c }, "st1 { v31.4s, v0.4s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0xac, 0x9f, 0x4c }, "st1 { v0.2d, v1.2d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0xa0, 0x82, 0x0c }, "st1 { v0.8b, v1.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0xa5, 0x83, 0x0c }, "st1 { v15.4h, v16.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0xab, 0x9f, 0x0c }, "st1 { v31.2s, v0.2s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0xac, 0x9f, 0x0c }, "st1 { v0.1d, v1.1d }, [x0], #16")]
    [DataRow(new byte[] { 0x00, 0x60, 0x81, 0x4c }, "st1 { v0.16b, v1.16b, v2.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x65, 0x82, 0x4c }, "st1 { v15.8h, v16.8h, v17.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x6b, 0x9f, 0x4c }, "st1 { v31.4s, v0.4s, v1.4s }, [sp], #48")]
    [DataRow(new byte[] { 0x00, 0x6c, 0x9f, 0x4c }, "st1 { v0.2d, v1.2d, v2.2d }, [x0], #48")]
    [DataRow(new byte[] { 0x00, 0x60, 0x82, 0x0c }, "st1 { v0.8b, v1.8b, v2.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x65, 0x83, 0x0c }, "st1 { v15.4h, v16.4h, v17.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x6b, 0x9f, 0x0c }, "st1 { v31.2s, v0.2s, v1.2s }, [sp], #24")]
    [DataRow(new byte[] { 0x00, 0x6c, 0x9f, 0x0c }, "st1 { v0.1d, v1.1d, v2.1d }, [x0], #24")]
    [DataRow(new byte[] { 0x00, 0x20, 0x81, 0x4c }, "st1 { v0.16b, v1.16b, v2.16b, v3.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x25, 0x82, 0x4c }, "st1 { v15.8h, v16.8h, v17.8h, v18.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x2b, 0x9f, 0x4c }, "st1 { v31.4s, v0.4s, v1.4s, v2.4s }, [sp], #64")]
    [DataRow(new byte[] { 0x00, 0x2c, 0x9f, 0x4c }, "st1 { v0.2d, v1.2d, v2.2d, v3.2d }, [x0], #64")]
    [DataRow(new byte[] { 0x00, 0x20, 0x83, 0x0c }, "st1 { v0.8b, v1.8b, v2.8b, v3.8b }, [x0], x3")]
    [DataRow(new byte[] { 0xef, 0x25, 0x84, 0x0c }, "st1 { v15.4h, v16.4h, v17.4h, v18.4h }, [x15], x4")]
    [DataRow(new byte[] { 0xff, 0x2b, 0x9f, 0x0c }, "st1 { v31.2s, v0.2s, v1.2s, v2.2s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0x2c, 0x9f, 0x0c }, "st1 { v0.1d, v1.1d, v2.1d, v3.1d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0x80, 0x81, 0x4c }, "st2 { v0.16b, v1.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x85, 0x82, 0x4c }, "st2 { v15.8h, v16.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x8b, 0x9f, 0x4c }, "st2 { v31.4s, v0.4s }, [sp], #32")]
    [DataRow(new byte[] { 0x00, 0x8c, 0x9f, 0x4c }, "st2 { v0.2d, v1.2d }, [x0], #32")]
    [DataRow(new byte[] { 0x00, 0x80, 0x82, 0x0c }, "st2 { v0.8b, v1.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x85, 0x83, 0x0c }, "st2 { v15.4h, v16.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x8b, 0x9f, 0x0c }, "st2 { v31.2s, v0.2s }, [sp], #16")]
    [DataRow(new byte[] { 0x00, 0x40, 0x81, 0x4c }, "st3 { v0.16b, v1.16b, v2.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x45, 0x82, 0x4c }, "st3 { v15.8h, v16.8h, v17.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x4b, 0x9f, 0x4c }, "st3 { v31.4s, v0.4s, v1.4s }, [sp], #48")]
    [DataRow(new byte[] { 0x00, 0x4c, 0x9f, 0x4c }, "st3 { v0.2d, v1.2d, v2.2d }, [x0], #48")]
    [DataRow(new byte[] { 0x00, 0x40, 0x82, 0x0c }, "st3 { v0.8b, v1.8b, v2.8b }, [x0], x2")]
    [DataRow(new byte[] { 0xef, 0x45, 0x83, 0x0c }, "st3 { v15.4h, v16.4h, v17.4h }, [x15], x3")]
    [DataRow(new byte[] { 0xff, 0x4b, 0x9f, 0x0c }, "st3 { v31.2s, v0.2s, v1.2s }, [sp], #24")]
    [DataRow(new byte[] { 0x00, 0x00, 0x81, 0x4c }, "st4 { v0.16b, v1.16b, v2.16b, v3.16b }, [x0], x1")]
    [DataRow(new byte[] { 0xef, 0x05, 0x82, 0x4c }, "st4 { v15.8h, v16.8h, v17.8h, v18.8h }, [x15], x2")]
    [DataRow(new byte[] { 0xff, 0x0b, 0x9f, 0x4c }, "st4 { v31.4s, v0.4s, v1.4s, v2.4s }, [sp], #64")]
    [DataRow(new byte[] { 0x00, 0x0c, 0x9f, 0x4c }, "st4 { v0.2d, v1.2d, v2.2d, v3.2d }, [x0], #64")]
    [DataRow(new byte[] { 0x00, 0x00, 0x83, 0x0c }, "st4 { v0.8b, v1.8b, v2.8b, v3.8b }, [x0], x3")]
    [DataRow(new byte[] { 0xef, 0x05, 0x84, 0x0c }, "st4 { v15.4h, v16.4h, v17.4h, v18.4h }, [x15], x4")]
    [DataRow(new byte[] { 0xff, 0x0b, 0x9f, 0x0c }, "st4 { v31.2s, v0.2s, v1.2s, v2.2s }, [sp], #32")]
    public void neon_simd_post_ldst_multi_elem_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
