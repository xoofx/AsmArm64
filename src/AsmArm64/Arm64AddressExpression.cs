// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents an assembler expression that evaluates to an absolute address.
/// </summary>
public abstract class Arm64AddressExpression : Arm64Expression
{
    /// <summary>
    /// Adds a signed constant to an address expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <param name="right">The value to add.</param>
    /// <returns>The resulting address expression.</returns>
    public static Arm64AddressExpression operator +(Arm64AddressExpression expression, long right) => new Arm64AddressAddExpression(expression, right);

    /// <summary>
    /// Subtracts a signed constant from an address expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <param name="right">The value to subtract.</param>
    /// <returns>The resulting address expression.</returns>
    public static Arm64AddressExpression operator -(Arm64AddressExpression expression, long right) => new Arm64AddressAddExpression(expression, checked(-right));
}
