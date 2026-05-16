// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Provides helpers for ARM64 address expressions.
/// </summary>
public static class Arm64Address
{
    /// <summary>
    /// The ARM64 page size used by <c>ADRP</c> page-relative addressing.
    /// </summary>
    public const long PageSize = 4096;

    /// <summary>
    /// Creates an expression that evaluates to the 4KB-aligned page containing <paramref name="expression"/>.
    /// </summary>
    /// <param name="expression">The address expression.</param>
    /// <returns>An address expression for the containing page.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="expression"/> is <c>null</c>.</exception>
    public static Arm64AddressExpression Page(this Arm64AddressExpression expression)
    {
        ArgumentNullException.ThrowIfNull(expression);
        return new Arm64AddressPageExpression(expression);
    }

    /// <summary>
    /// Creates an expression that evaluates to the byte offset within the 4KB page containing <paramref name="expression"/>.
    /// </summary>
    /// <param name="expression">The address expression.</param>
    /// <returns>An expression for the page offset.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="expression"/> is <c>null</c>.</exception>
    public static Arm64Expression PageOffset(this Arm64AddressExpression expression)
    {
        ArgumentNullException.ThrowIfNull(expression);
        return new Arm64AddressPageOffsetExpression(expression);
    }
}
