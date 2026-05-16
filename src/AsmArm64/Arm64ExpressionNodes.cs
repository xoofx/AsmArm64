// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

internal sealed class Arm64AddExpression : Arm64Expression
{
    public Arm64AddExpression(Arm64Expression expression, long addend)
    {
        ArgumentNullException.ThrowIfNull(expression);
        Expression = expression;
        Addend = addend;
    }

    public Arm64Expression Expression { get; }

    public long Addend { get; }

    public override long Evaluate() => checked(Expression.Evaluate() + Addend);

    public override void CollectLabels(ISet<Arm64Label> labels) => Expression.CollectLabels(labels);

    public override string ToString() => Addend < 0 ? $"{Expression} - {-Addend}" : $"{Expression} + {Addend}";
}

internal sealed class Arm64AddressAddExpression : Arm64AddressExpression
{
    public Arm64AddressAddExpression(Arm64AddressExpression expression, long addend)
    {
        ArgumentNullException.ThrowIfNull(expression);
        Expression = expression;
        Addend = addend;
    }

    public Arm64AddressExpression Expression { get; }

    public long Addend { get; }

    public override long Evaluate() => checked(Expression.Evaluate() + Addend);

    public override void CollectLabels(ISet<Arm64Label> labels) => Expression.CollectLabels(labels);

    public override string ToString() => Addend < 0 ? $"{Expression} - {-Addend}" : $"{Expression} + {Addend}";
}

internal sealed class Arm64SubtractExpression : Arm64Expression
{
    public Arm64SubtractExpression(Arm64Expression left, Arm64Expression right)
    {
        ArgumentNullException.ThrowIfNull(left);
        ArgumentNullException.ThrowIfNull(right);
        Left = left;
        Right = right;
    }

    public Arm64Expression Left { get; }

    public Arm64Expression Right { get; }

    public override long Evaluate() => checked(Left.Evaluate() - Right.Evaluate());

    public override void CollectLabels(ISet<Arm64Label> labels)
    {
        Left.CollectLabels(labels);
        Right.CollectLabels(labels);
    }

    public override string ToString() => $"{Left} - {Right}";
}

internal sealed class Arm64AddressPageExpression : Arm64AddressExpression
{
    public Arm64AddressPageExpression(Arm64AddressExpression expression)
    {
        ArgumentNullException.ThrowIfNull(expression);
        Expression = expression;
    }

    public Arm64AddressExpression Expression { get; }

    public override long Evaluate()
    {
        var address = Expression.Evaluate();
        if (address < 0) throw new ArgumentOutOfRangeException(nameof(Expression), address, "The expression evaluated to a negative address.");
        return address & ~(Arm64Address.PageSize - 1);
    }

    public override void CollectLabels(ISet<Arm64Label> labels) => Expression.CollectLabels(labels);

    public override string ToString() => $"Page({Expression})";
}

internal sealed class Arm64AddressPageOffsetExpression : Arm64Expression
{
    public Arm64AddressPageOffsetExpression(Arm64AddressExpression expression)
    {
        ArgumentNullException.ThrowIfNull(expression);
        Expression = expression;
    }

    public Arm64AddressExpression Expression { get; }

    public override long Evaluate()
    {
        var address = Expression.Evaluate();
        if (address < 0) throw new ArgumentOutOfRangeException(nameof(Expression), address, "The expression evaluated to a negative address.");
        return address & (Arm64Address.PageSize - 1);
    }

    public override void CollectLabels(ISet<Arm64Label> labels) => Expression.CollectLabels(labels);

    public override string ToString() => $"PageOffset({Expression})";
}
