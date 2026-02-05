// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

/// <summary>
/// Internal enum used to encode the kind of memory addressing for ARM64.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<Arm64MemoryEncodingKind>))]
enum Arm64MemoryEncodingKind : byte
{
    None,
    /// <summary>
    /// [Xd]!
    /// </summary>
    BaseRegisterXn,
    /// <summary>
    /// [Xn|SP]
    /// </summary>
    BaseRegister,
    /// <summary>
    /// [Xn|SP,#-16]!
    /// [Xn|SP,#-4]!
    /// [Xn|SP,#-8]!
    /// </summary>
    BaseRegisterAndFixedImmediate,
    /// <summary>
    /// [Xn|SP,#imm]!
    /// [Xn|SP,#simm]!
    /// </summary>
    BaseRegisterAndImmediate,
    /// <summary>
    /// [Xn|SP{,#0}]
    /// </summary>
    BaseRegisterAndFixedImmediateOptional,
    /// <summary>
    /// [Xn|SP{,#imm}]
    /// [Xn|SP{,#pimm}]
    /// [Xn|SP{,#simm}]
    /// [Xn|SP{,#simm}]!
    /// </summary>
    BaseRegisterAndImmediateOptional,
    /// <summary>
    /// [Xn|SP,(Wm|Xm){,extend,{amount}}]
    /// </summary>
    BaseRegisterAndIndexWmOrXmAndExtendOptional,
    /// <summary>
    /// [Xn|SP,Xm{,LSL amount}]
    /// </summary>
    BaseRegisterAndIndexXmAndLslAmount,
    /// <summary>
    /// [Xn|SP,(Wm|Xm),extend,{amount}]
    /// </summary>
    BaseRegisterAndIndexWmOrXmAndExtend,
}