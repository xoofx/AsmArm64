// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Extensions for ARM64 classes and enums.
/// </summary>
public static partial class Arm64Extensions
{
    /// <summary>
    /// Gets the upper text representation of the specified <see cref="Arm64Mnemonic"/>.
    /// </summary>
    /// <param name="mnemonic">The mnemonic.</param>
    /// <returns>The upper text representation of the specified <see cref="Arm64Mnemonic"/>.</returns>
    public static string ToUpperText(this Arm64Mnemonic mnemonic) => MnemonicUpperTable[(int)mnemonic];

    /// <summary>
    /// Gets the lower text representation of the specified <see cref="Arm64Mnemonic"/>.
    /// </summary>
    /// <param name="mnemonic">The mnemonic.</param>
    /// <returns>The lower text representation of the specified <see cref="Arm64Mnemonic"/>.</returns>
    public static string ToLowerText(this Arm64Mnemonic mnemonic) => MnemonicLowerTable[(int)mnemonic];
}