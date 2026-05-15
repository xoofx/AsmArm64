// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a label in ARM64 assembler output.
/// </summary>
public sealed class Arm64Label
{
    internal static readonly Arm64Label Empty = new(isEmpty: true);

    private readonly bool _isEmpty;

    private Arm64Label(bool isEmpty)
    {
        _isEmpty = isEmpty;
        Address = 0;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Label"/> class.
    /// </summary>
    /// <param name="address">The address of this label, or <see cref="ulong.MaxValue"/> for an unbound label.</param>
    /// <param name="name">The optional name associated with this label.</param>
    public Arm64Label(ulong address = ulong.MaxValue, string? name = null)
    {
        Address = address;
        Name = name;
    }

    /// <summary>
    /// Initializes a new unbound instance of the <see cref="Arm64Label"/> class.
    /// </summary>
    /// <param name="name">The optional name associated with this label.</param>
    public Arm64Label(string? name) : this(ulong.MaxValue, name)
    {
    }

    /// <summary>
    /// Gets the address of this label.
    /// </summary>
    public ulong Address { get; internal set; }

    /// <summary>
    /// Gets the optional name associated with this label.
    /// </summary>
    public string? Name { get; }

    /// <summary>
    /// Gets a value indicating whether the label is bound.
    /// </summary>
    public bool IsBound => !_isEmpty && Address != ulong.MaxValue;

    /// <summary>
    /// Gets a value indicating whether the label is empty.
    /// </summary>
    public bool IsEmpty => _isEmpty;

    internal Arm64LabelId Id { get; set; }

    /// <inheritdoc />
    public override string ToString() => Name ?? (IsBound ? $"0x{Address:X16}" : "0x????");

    internal static string? ParseCSharpExpression(string? expression)
    {
        if (string.IsNullOrWhiteSpace(expression)) return null;

        var span = expression.AsSpan().Trim();
        const string varPrefix = "var ";
        if (span.StartsWith(varPrefix, StringComparison.Ordinal))
        {
            span = span[varPrefix.Length..].Trim();
        }

        var equalsIndex = span.IndexOf('=');
        if (equalsIndex >= 0)
        {
            span = span[..equalsIndex].Trim();
        }

        if (span.Length == 0) return null;

        var lastDotIndex = span.LastIndexOf('.');
        if (lastDotIndex >= 0 && lastDotIndex + 1 < span.Length)
        {
            span = span[(lastDotIndex + 1)..];
        }

        return span.ToString();
    }
}
