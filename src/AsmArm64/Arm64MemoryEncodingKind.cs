// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Text.Json.Serialization;

namespace AsmArm64;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Arm64MemoryEncodingKind : byte
{
    None,
    // 1 [Xd]!
    // 1 [Xs]!
    BaseRegisterXn,
    // 1 [Xn|SP]
    BaseRegister,
    // 2 [Xn|SP,#-16]!
    // 2 [Xn|SP,#-4]!
    // 2 [Xn|SP,#-8]!
    BaseRegisterAndFixedImmediate,
    // 2 [Xn|SP,#imm]!
    // 2 [Xn|SP,#simm]!
    BaseRegisterXnOrSPAndImmediate,
    // 2 [Xn|SP{,#imm}]
    // 2 [Xn|SP{,#pimm}]
    // 2 [Xn|SP{,#simm}]
    // 2 [Xn|SP{,#simm}]!
    BaseRegisterAndImmediateOptional,
    // 3 [Xn|SP,(Wm|Xm){,extend,{amount}}]
    BaseRegisterAndIndexWmOrXmAndExtendOptional,
    // 3 [Xn|SP,Xm{,LSLamount}]
    BaseRegisterAndIndexXmAndLslAmount,
    // 4 [Xn|SP,(Wm|Xm),extend,{amount}]
    BaseRegisterAndIndexWmOrXmAndExtend,
}