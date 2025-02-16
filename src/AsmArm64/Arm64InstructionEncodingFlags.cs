// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

[Flags]
internal enum Arm64InstructionEncodingFlags : byte
{
    None = Arm64InstructionFlags.None,
    HasLabel = Arm64InstructionFlags.HasLabel,
    HasSetFlags = Arm64InstructionFlags.HasSetFlags,
    Encoding8Bytes = 1 << 7,
}

[Flags]
public enum Arm64InstructionFlags : byte
{
    None = 0,
    HasLabel = 1,
    HasSetFlags = 2,
}
