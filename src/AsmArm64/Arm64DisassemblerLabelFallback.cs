// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>Controls numeric PC-relative operands when neither a symbol nor an eligible local label is available.</summary>
public enum Arm64DisassemblerLabelFallback
{
    /// <summary>Prints the encoded relative displacement using the instruction's label-offset formatting options. This is the default.</summary>
    RelativeOffset,
    /// <summary>Prints the absolute target as a 16-digit hexadecimal address using the listing's address prefix and hex casing.</summary>
    AbsoluteAddress,
}
