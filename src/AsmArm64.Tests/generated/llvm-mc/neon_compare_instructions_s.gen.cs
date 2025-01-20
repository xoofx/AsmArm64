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
    [DataRow(new byte[] { 0xe0, 0x8d, 0x31, 0x2e }, "cmeq v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x8f, 0x28, 0x6e }, "cmeq v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x8e, 0x71, 0x2e }, "cmeq v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x8c, 0x67, 0x6e }, "cmeq v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x8f, 0xbc, 0x2e }, "cmeq v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x8c, 0xa8, 0x6e }, "cmeq v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x8f, 0xf5, 0x6e }, "cmeq v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x3d, 0x31, 0x2e }, "cmhs v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x3f, 0x28, 0x6e }, "cmhs v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x3e, 0x71, 0x2e }, "cmhs v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x3c, 0x67, 0x6e }, "cmhs v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x3f, 0xbc, 0x2e }, "cmhs v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x3c, 0xa8, 0x6e }, "cmhs v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x3f, 0xf5, 0x6e }, "cmhs v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x3d, 0x31, 0x2e }, "cmhs v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x3f, 0x28, 0x6e }, "cmhs v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x3e, 0x71, 0x2e }, "cmhs v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x3c, 0x67, 0x6e }, "cmhs v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x3f, 0xbc, 0x2e }, "cmhs v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x3c, 0xa8, 0x6e }, "cmhs v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x3f, 0xf5, 0x6e }, "cmhs v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x3d, 0x31, 0x0e }, "cmge v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x3f, 0x28, 0x4e }, "cmge v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x3e, 0x71, 0x0e }, "cmge v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x3c, 0x67, 0x4e }, "cmge v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x3f, 0xbc, 0x0e }, "cmge v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x3c, 0xa8, 0x4e }, "cmge v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x3f, 0xf5, 0x4e }, "cmge v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x3d, 0x31, 0x0e }, "cmge v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x3f, 0x28, 0x4e }, "cmge v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x3e, 0x71, 0x0e }, "cmge v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x3c, 0x67, 0x4e }, "cmge v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x3f, 0xbc, 0x0e }, "cmge v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x3c, 0xa8, 0x4e }, "cmge v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x3f, 0xf5, 0x4e }, "cmge v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x35, 0x31, 0x2e }, "cmhi v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x37, 0x28, 0x6e }, "cmhi v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x36, 0x71, 0x2e }, "cmhi v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x34, 0x67, 0x6e }, "cmhi v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x37, 0xbc, 0x2e }, "cmhi v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x34, 0xa8, 0x6e }, "cmhi v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x37, 0xf5, 0x6e }, "cmhi v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x35, 0x31, 0x2e }, "cmhi v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x37, 0x28, 0x6e }, "cmhi v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x36, 0x71, 0x2e }, "cmhi v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x34, 0x67, 0x6e }, "cmhi v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x37, 0xbc, 0x2e }, "cmhi v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x34, 0xa8, 0x6e }, "cmhi v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x37, 0xf5, 0x6e }, "cmhi v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x35, 0x31, 0x0e }, "cmgt v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x37, 0x28, 0x4e }, "cmgt v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x36, 0x71, 0x0e }, "cmgt v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x34, 0x67, 0x4e }, "cmgt v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x37, 0xbc, 0x0e }, "cmgt v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x34, 0xa8, 0x4e }, "cmgt v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x37, 0xf5, 0x4e }, "cmgt v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x35, 0x31, 0x0e }, "cmgt v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x37, 0x28, 0x4e }, "cmgt v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x36, 0x71, 0x0e }, "cmgt v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x34, 0x67, 0x4e }, "cmgt v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x37, 0xbc, 0x0e }, "cmgt v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x34, 0xa8, 0x4e }, "cmgt v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x37, 0xf5, 0x4e }, "cmgt v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x8d, 0x31, 0x0e }, "cmtst v0.8b, v15.8b, v17.8b")]
    [DataRow(new byte[] { 0xe1, 0x8f, 0x28, 0x4e }, "cmtst v1.16b, v31.16b, v8.16b")]
    [DataRow(new byte[] { 0x0f, 0x8e, 0x71, 0x0e }, "cmtst v15.4h, v16.4h, v17.4h")]
    [DataRow(new byte[] { 0xc5, 0x8c, 0x67, 0x4e }, "cmtst v5.8h, v6.8h, v7.8h")]
    [DataRow(new byte[] { 0x7d, 0x8f, 0xbc, 0x0e }, "cmtst v29.2s, v27.2s, v28.2s")]
    [DataRow(new byte[] { 0xe9, 0x8c, 0xa8, 0x4e }, "cmtst v9.4s, v7.4s, v8.4s")]
    [DataRow(new byte[] { 0xe3, 0x8f, 0xf5, 0x4e }, "cmtst v3.2d, v31.2d, v21.2d")]
    [DataRow(new byte[] { 0xe0, 0x27, 0x50, 0x0e }, "fcmeq v0.4h, v31.4h, v16.4h")]
    [DataRow(new byte[] { 0xe4, 0x24, 0x4f, 0x4e }, "fcmeq v4.8h, v7.8h, v15.8h")]
    [DataRow(new byte[] { 0xe0, 0xe7, 0x30, 0x0e }, "fcmeq v0.2s, v31.2s, v16.2s")]
    [DataRow(new byte[] { 0xe4, 0xe4, 0x2f, 0x4e }, "fcmeq v4.4s, v7.4s, v15.4s")]
    [DataRow(new byte[] { 0x5d, 0xe4, 0x65, 0x4e }, "fcmeq v29.2d, v2.2d, v5.2d")]
    [DataRow(new byte[] { 0x03, 0x25, 0x4c, 0x2e }, "fcmge v3.4h, v8.4h, v12.4h")]
    [DataRow(new byte[] { 0xbf, 0x27, 0x5c, 0x6e }, "fcmge v31.8h, v29.8h, v28.8h")]
    [DataRow(new byte[] { 0x03, 0x25, 0x4c, 0x2e }, "fcmge v3.4h, v8.4h, v12.4h")]
    [DataRow(new byte[] { 0xbf, 0x27, 0x5c, 0x6e }, "fcmge v31.8h, v29.8h, v28.8h")]
    [DataRow(new byte[] { 0xbf, 0xe7, 0x3c, 0x6e }, "fcmge v31.4s, v29.4s, v28.4s")]
    [DataRow(new byte[] { 0x03, 0xe5, 0x2c, 0x2e }, "fcmge v3.2s, v8.2s, v12.2s")]
    [DataRow(new byte[] { 0xf1, 0xe5, 0x6d, 0x6e }, "fcmge v17.2d, v15.2d, v13.2d")]
    [DataRow(new byte[] { 0xbf, 0xe7, 0x3c, 0x6e }, "fcmge v31.4s, v29.4s, v28.4s")]
    [DataRow(new byte[] { 0x03, 0xe5, 0x2c, 0x2e }, "fcmge v3.2s, v8.2s, v12.2s")]
    [DataRow(new byte[] { 0xf1, 0xe5, 0x6d, 0x6e }, "fcmge v17.2d, v15.2d, v13.2d")]
    [DataRow(new byte[] { 0xe0, 0x27, 0xd0, 0x2e }, "fcmgt v0.4h, v31.4h, v16.4h")]
    [DataRow(new byte[] { 0xe4, 0x24, 0xcf, 0x6e }, "fcmgt v4.8h, v7.8h, v15.8h")]
    [DataRow(new byte[] { 0xe0, 0x27, 0xd0, 0x2e }, "fcmgt v0.4h, v31.4h, v16.4h")]
    [DataRow(new byte[] { 0xe4, 0x24, 0xcf, 0x6e }, "fcmgt v4.8h, v7.8h, v15.8h")]
    [DataRow(new byte[] { 0xe0, 0xe7, 0xb0, 0x2e }, "fcmgt v0.2s, v31.2s, v16.2s")]
    [DataRow(new byte[] { 0xe4, 0xe4, 0xaf, 0x6e }, "fcmgt v4.4s, v7.4s, v15.4s")]
    [DataRow(new byte[] { 0x5d, 0xe4, 0xe5, 0x6e }, "fcmgt v29.2d, v2.2d, v5.2d")]
    [DataRow(new byte[] { 0xe0, 0xe7, 0xb0, 0x2e }, "fcmgt v0.2s, v31.2s, v16.2s")]
    [DataRow(new byte[] { 0xe4, 0xe4, 0xaf, 0x6e }, "fcmgt v4.4s, v7.4s, v15.4s")]
    [DataRow(new byte[] { 0x5d, 0xe4, 0xe5, 0x6e }, "fcmgt v29.2d, v2.2d, v5.2d")]
    [DataRow(new byte[] { 0xe0, 0x99, 0x20, 0x0e }, "cmeq v0.8b, v15.8b, #0")]
    [DataRow(new byte[] { 0xe1, 0x9b, 0x20, 0x4e }, "cmeq v1.16b, v31.16b, #0")]
    [DataRow(new byte[] { 0x0f, 0x9a, 0x60, 0x0e }, "cmeq v15.4h, v16.4h, #0")]
    [DataRow(new byte[] { 0xc5, 0x98, 0x60, 0x4e }, "cmeq v5.8h, v6.8h, #0")]
    [DataRow(new byte[] { 0x7d, 0x9b, 0xa0, 0x0e }, "cmeq v29.2s, v27.2s, #0")]
    [DataRow(new byte[] { 0xe9, 0x98, 0xa0, 0x4e }, "cmeq v9.4s, v7.4s, #0")]
    [DataRow(new byte[] { 0xe3, 0x9b, 0xe0, 0x4e }, "cmeq v3.2d, v31.2d, #0")]
    [DataRow(new byte[] { 0xe0, 0x89, 0x20, 0x2e }, "cmge v0.8b, v15.8b, #0")]
    [DataRow(new byte[] { 0xe1, 0x8b, 0x20, 0x6e }, "cmge v1.16b, v31.16b, #0")]
    [DataRow(new byte[] { 0x0f, 0x8a, 0x60, 0x2e }, "cmge v15.4h, v16.4h, #0")]
    [DataRow(new byte[] { 0xc5, 0x88, 0x60, 0x6e }, "cmge v5.8h, v6.8h, #0")]
    [DataRow(new byte[] { 0x7d, 0x8b, 0xa0, 0x2e }, "cmge v29.2s, v27.2s, #0")]
    [DataRow(new byte[] { 0x91, 0x8a, 0xa0, 0x6e }, "cmge v17.4s, v20.4s, #0")]
    [DataRow(new byte[] { 0xe3, 0x8b, 0xe0, 0x6e }, "cmge v3.2d, v31.2d, #0")]
    [DataRow(new byte[] { 0xe0, 0x89, 0x20, 0x0e }, "cmgt v0.8b, v15.8b, #0")]
    [DataRow(new byte[] { 0xe1, 0x8b, 0x20, 0x4e }, "cmgt v1.16b, v31.16b, #0")]
    [DataRow(new byte[] { 0x0f, 0x8a, 0x60, 0x0e }, "cmgt v15.4h, v16.4h, #0")]
    [DataRow(new byte[] { 0xc5, 0x88, 0x60, 0x4e }, "cmgt v5.8h, v6.8h, #0")]
    [DataRow(new byte[] { 0x7d, 0x8b, 0xa0, 0x0e }, "cmgt v29.2s, v27.2s, #0")]
    [DataRow(new byte[] { 0xe9, 0x88, 0xa0, 0x4e }, "cmgt v9.4s, v7.4s, #0")]
    [DataRow(new byte[] { 0xe3, 0x8b, 0xe0, 0x4e }, "cmgt v3.2d, v31.2d, #0")]
    [DataRow(new byte[] { 0xe0, 0x99, 0x20, 0x2e }, "cmle v0.8b, v15.8b, #0")]
    [DataRow(new byte[] { 0xe1, 0x9b, 0x20, 0x6e }, "cmle v1.16b, v31.16b, #0")]
    [DataRow(new byte[] { 0x0f, 0x9a, 0x60, 0x2e }, "cmle v15.4h, v16.4h, #0")]
    [DataRow(new byte[] { 0xc5, 0x98, 0x60, 0x6e }, "cmle v5.8h, v6.8h, #0")]
    [DataRow(new byte[] { 0x7d, 0x9b, 0xa0, 0x2e }, "cmle v29.2s, v27.2s, #0")]
    [DataRow(new byte[] { 0xe9, 0x98, 0xa0, 0x6e }, "cmle v9.4s, v7.4s, #0")]
    [DataRow(new byte[] { 0xe3, 0x9b, 0xe0, 0x6e }, "cmle v3.2d, v31.2d, #0")]
    [DataRow(new byte[] { 0xe0, 0xa9, 0x20, 0x0e }, "cmlt v0.8b, v15.8b, #0")]
    [DataRow(new byte[] { 0xe1, 0xab, 0x20, 0x4e }, "cmlt v1.16b, v31.16b, #0")]
    [DataRow(new byte[] { 0x0f, 0xaa, 0x60, 0x0e }, "cmlt v15.4h, v16.4h, #0")]
    [DataRow(new byte[] { 0xc5, 0xa8, 0x60, 0x4e }, "cmlt v5.8h, v6.8h, #0")]
    [DataRow(new byte[] { 0x7d, 0xab, 0xa0, 0x0e }, "cmlt v29.2s, v27.2s, #0")]
    [DataRow(new byte[] { 0xe9, 0xa8, 0xa0, 0x4e }, "cmlt v9.4s, v7.4s, #0")]
    [DataRow(new byte[] { 0xe3, 0xab, 0xe0, 0x4e }, "cmlt v3.2d, v31.2d, #0")]
    [DataRow(new byte[] { 0xe0, 0xdb, 0xf8, 0x0e }, "fcmeq v0.4h, v31.4h, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xd8, 0xf8, 0x4e }, "fcmeq v4.8h, v7.8h, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xdb, 0xa0, 0x0e }, "fcmeq v0.2s, v31.2s, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xd8, 0xa0, 0x4e }, "fcmeq v4.4s, v7.4s, #0.0")]
    [DataRow(new byte[] { 0x5d, 0xd8, 0xe0, 0x4e }, "fcmeq v29.2d, v2.2d, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xdb, 0xf8, 0x0e }, "fcmeq v0.4h, v31.4h, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xd8, 0xf8, 0x4e }, "fcmeq v4.8h, v7.8h, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xdb, 0xa0, 0x0e }, "fcmeq v0.2s, v31.2s, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xd8, 0xa0, 0x4e }, "fcmeq v4.4s, v7.4s, #0.0")]
    [DataRow(new byte[] { 0x5d, 0xd8, 0xe0, 0x4e }, "fcmeq v29.2d, v2.2d, #0.0")]
    [DataRow(new byte[] { 0x03, 0xc9, 0xf8, 0x2e }, "fcmge v3.4h, v8.4h, #0.0")]
    [DataRow(new byte[] { 0xbf, 0xcb, 0xf8, 0x6e }, "fcmge v31.8h, v29.8h, #0.0")]
    [DataRow(new byte[] { 0xbf, 0xcb, 0xa0, 0x6e }, "fcmge v31.4s, v29.4s, #0.0")]
    [DataRow(new byte[] { 0x03, 0xc9, 0xa0, 0x2e }, "fcmge v3.2s, v8.2s, #0.0")]
    [DataRow(new byte[] { 0xf1, 0xc9, 0xe0, 0x6e }, "fcmge v17.2d, v15.2d, #0.0")]
    [DataRow(new byte[] { 0x03, 0xc9, 0xf8, 0x2e }, "fcmge v3.4h, v8.4h, #0.0")]
    [DataRow(new byte[] { 0xbf, 0xcb, 0xf8, 0x6e }, "fcmge v31.8h, v29.8h, #0.0")]
    [DataRow(new byte[] { 0xbf, 0xcb, 0xa0, 0x6e }, "fcmge v31.4s, v29.4s, #0.0")]
    [DataRow(new byte[] { 0x03, 0xc9, 0xa0, 0x2e }, "fcmge v3.2s, v8.2s, #0.0")]
    [DataRow(new byte[] { 0xf1, 0xc9, 0xe0, 0x6e }, "fcmge v17.2d, v15.2d, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xcb, 0xf8, 0x0e }, "fcmgt v0.4h, v31.4h, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xc8, 0xf8, 0x4e }, "fcmgt v4.8h, v7.8h, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xcb, 0xa0, 0x0e }, "fcmgt v0.2s, v31.2s, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xc8, 0xa0, 0x4e }, "fcmgt v4.4s, v7.4s, #0.0")]
    [DataRow(new byte[] { 0x5d, 0xc8, 0xe0, 0x4e }, "fcmgt v29.2d, v2.2d, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xcb, 0xf8, 0x0e }, "fcmgt v0.4h, v31.4h, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xc8, 0xf8, 0x4e }, "fcmgt v4.8h, v7.8h, #0.0")]
    [DataRow(new byte[] { 0xe0, 0xcb, 0xa0, 0x0e }, "fcmgt v0.2s, v31.2s, #0.0")]
    [DataRow(new byte[] { 0xe4, 0xc8, 0xa0, 0x4e }, "fcmgt v4.4s, v7.4s, #0.0")]
    [DataRow(new byte[] { 0x5d, 0xc8, 0xe0, 0x4e }, "fcmgt v29.2d, v2.2d, #0.0")]
    [DataRow(new byte[] { 0x83, 0xda, 0xf8, 0x2e }, "fcmle v3.4h, v20.4h, #0.0")]
    [DataRow(new byte[] { 0x01, 0xd9, 0xf8, 0x6e }, "fcmle v1.8h, v8.8h, #0.0")]
    [DataRow(new byte[] { 0x01, 0xd9, 0xa0, 0x6e }, "fcmle v1.4s, v8.4s, #0.0")]
    [DataRow(new byte[] { 0x83, 0xda, 0xa0, 0x2e }, "fcmle v3.2s, v20.2s, #0.0")]
    [DataRow(new byte[] { 0xa7, 0xd9, 0xe0, 0x6e }, "fcmle v7.2d, v13.2d, #0.0")]
    [DataRow(new byte[] { 0x83, 0xda, 0xf8, 0x2e }, "fcmle v3.4h, v20.4h, #0.0")]
    [DataRow(new byte[] { 0x01, 0xd9, 0xf8, 0x6e }, "fcmle v1.8h, v8.8h, #0.0")]
    [DataRow(new byte[] { 0x01, 0xd9, 0xa0, 0x6e }, "fcmle v1.4s, v8.4s, #0.0")]
    [DataRow(new byte[] { 0x83, 0xda, 0xa0, 0x2e }, "fcmle v3.2s, v20.2s, #0.0")]
    [DataRow(new byte[] { 0xa7, 0xd9, 0xe0, 0x6e }, "fcmle v7.2d, v13.2d, #0.0")]
    [DataRow(new byte[] { 0x50, 0xe8, 0xf8, 0x0e }, "fcmlt v16.4h, v2.4h, #0.0")]
    [DataRow(new byte[] { 0x8f, 0xe8, 0xf8, 0x4e }, "fcmlt v15.8h, v4.8h, #0.0")]
    [DataRow(new byte[] { 0x50, 0xe8, 0xa0, 0x0e }, "fcmlt v16.2s, v2.2s, #0.0")]
    [DataRow(new byte[] { 0x8f, 0xe8, 0xa0, 0x4e }, "fcmlt v15.4s, v4.4s, #0.0")]
    [DataRow(new byte[] { 0xa5, 0xeb, 0xe0, 0x4e }, "fcmlt v5.2d, v29.2d, #0.0")]
    [DataRow(new byte[] { 0x50, 0xe8, 0xf8, 0x0e }, "fcmlt v16.4h, v2.4h, #0.0")]
    [DataRow(new byte[] { 0x8f, 0xe8, 0xf8, 0x4e }, "fcmlt v15.8h, v4.8h, #0.0")]
    [DataRow(new byte[] { 0x50, 0xe8, 0xa0, 0x0e }, "fcmlt v16.2s, v2.2s, #0.0")]
    [DataRow(new byte[] { 0x8f, 0xe8, 0xa0, 0x4e }, "fcmlt v15.4s, v4.4s, #0.0")]
    [DataRow(new byte[] { 0xa5, 0xeb, 0xe0, 0x4e }, "fcmlt v5.2d, v29.2d, #0.0")]
    public void neon_compare_instructions_s(byte[] code, string expectedAsm) => VerifyAsm(code, expectedAsm);
}
