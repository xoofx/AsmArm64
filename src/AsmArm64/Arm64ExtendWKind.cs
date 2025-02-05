// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly record struct Arm64ExtendWKind : IArm64ExtendKind
{
    private Arm64ExtendWKind(Arm64ExtendKind extendKind)
    {
        ExtendKind = extendKind;
    }

    public Arm64ExtendKind ExtendKind { get; }

    public override string ToString() => this.ExtendToText();
    
    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.UXTW extendKind) => new(Arm64ExtendKind.UXTW);

    public static implicit operator Arm64ExtendWKind(IArm64ExtendKind.SXTW extendKind) => new(Arm64ExtendKind.SXTW);
}