// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Defines the interface for a register.
/// </summary>
public interface IArm64Register : ISpanFormattable
{
    /// <summary>
    /// Gets the kind of register.
    /// </summary>
    Arm64RegisterKind Kind { get; }

    /// <summary>
    /// Gets the index of the register.
    /// </summary>
    int Index { get; }
}

public interface IArm64RegisterV : IArm64Register
{
    Arm64RegisterVKind VKind { get; }
}


public interface IArm64RegisterVTyped : IArm64RegisterV
{
    int ElementCount { get; }
}

public interface IArm64RegisterVScalar : IArm64RegisterV
{
}