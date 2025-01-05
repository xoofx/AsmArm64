// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Extensions for ARM64 classes and enums.
/// </summary>
public static partial class Arm64Extensions
{
    /// <summary>
    /// Gets the text representation of the specified <see cref="Arm64Mnemonic"/>.
    /// </summary>
    /// <param name="mnemonic">The mnemonic.</param>
    /// <param name="upperCase">A flag indicating whether to format the mnemonic in upper case or lower case.</param>
    /// <returns>The upper text representation of the specified <see cref="Arm64Mnemonic"/>.</returns>
    public static string ToText(this Arm64Mnemonic mnemonic, bool upperCase = false) => upperCase ? MnemonicUpperTable[(int)mnemonic] : MnemonicLowerTable[(int)mnemonic];

    /// <summary>
    /// Validates the range of a register index.
    /// </summary>
    /// <param name="index">The register index.</param>
    /// <returns>The register index if it is valid.</returns>
    private static int ValidateRegisterIndex(int index) => index is >= 0 and < 32 ? index : ThrowRegisterIndexOutOfRange(index);
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static int ThrowRegisterIndexOutOfRange(int index)
    {
        throw new InvalidOperationException($"Invalid register index {index}. The index must be in the range [0, 31]");
    }
}