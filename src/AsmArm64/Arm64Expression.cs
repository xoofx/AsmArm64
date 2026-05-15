// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents an assembler expression that can be evaluated after labels are bound.
/// </summary>
public abstract class Arm64Expression
{
    /// <summary>
    /// Evaluates the expression.
    /// </summary>
    /// <returns>The evaluated expression value.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the expression references an unbound label.</exception>
    /// <exception cref="OverflowException">Thrown when expression arithmetic overflows.</exception>
    public abstract long Evaluate();

    /// <summary>
    /// Collects labels referenced by this expression.
    /// </summary>
    /// <param name="labels">The destination set that receives referenced labels.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="labels"/> is <c>null</c>.</exception>
    public abstract void CollectLabels(ISet<Arm64Label> labels);

    /// <summary>
    /// Adds a signed constant to an expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <param name="right">The value to add.</param>
    /// <returns>The resulting expression.</returns>
    public static Arm64Expression operator +(Arm64Expression expression, long right) => new Arm64AddExpression(expression, right);

    /// <summary>
    /// Subtracts a signed constant from an expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <param name="right">The value to subtract.</param>
    /// <returns>The resulting expression.</returns>
    public static Arm64Expression operator -(Arm64Expression expression, long right) => new Arm64AddExpression(expression, checked(-right));

    /// <summary>
    /// Subtracts one expression from another.
    /// </summary>
    /// <param name="left">The left expression.</param>
    /// <param name="right">The right expression.</param>
    /// <returns>The resulting expression.</returns>
    public static Arm64Expression operator -(Arm64Expression left, Arm64Expression right) => new Arm64SubtractExpression(left, right);
}
