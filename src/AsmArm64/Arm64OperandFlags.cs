// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

[Flags]
public enum Arm64OperandFlags : byte
{
    None = 0,
    Read = 1,
    Write = 2,
    ReadWrite = Read | Write,
    Optional = 8,
}