// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Describes a relocation that could not be resolved to an internal label address.
/// </summary>
/// <param name="Kind">The relocation kind.</param>
/// <param name="Offset">The byte offset of the instruction or data requiring relocation.</param>
/// <param name="Label">The external label associated with the relocation.</param>
/// <param name="Addend">The relocation addend.</param>
public readonly record struct Arm64Relocation(Arm64RelocationKind Kind, uint Offset, Arm64Label Label, long Addend);
