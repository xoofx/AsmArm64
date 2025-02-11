// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public readonly record struct Arm64ExtendXKind : IArm64ExtendKind
{
    private Arm64ExtendXKind(Arm64ExtendKind extendKind)
    {
        ExtendKind = extendKind;
    }

    public Arm64ExtendKind ExtendKind { get; }

    public override string ToString() => this.ExtendToText();

    public static implicit operator Arm64ExtendXKind(LSLShiftKind shiftKindAsExtendKind) => new(Arm64ExtendKind.LSL);

    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.LSL extendKind) => new(Arm64ExtendKind.LSL);

    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.UXTX extendKind) => new(Arm64ExtendKind.UXTX);

    public static implicit operator Arm64ExtendXKind(IArm64ExtendKind.SXTX extendKind) => new(Arm64ExtendKind.SXTX);
}
