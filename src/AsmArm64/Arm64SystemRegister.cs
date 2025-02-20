// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Defines a system register for ARM64.
/// </summary>
public readonly struct Arm64SystemRegister : IEquatable<Arm64SystemRegister>, ISpanFormattable
{
    // 16-bit value for the Arm64SystemRegisterId enum index
    // 16-bit value for the system register
    // 32-bit value for the Arm64SystemRegisterKind
    private readonly ulong _value;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64SystemRegister"/> struct.
    /// </summary>
    /// <param name="id">The known ID of the system register.</param>
    /// <param name="value">The value of the system register.</param>
    /// <param name="kind">The kind of the system register.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal Arm64SystemRegister(Arm64SystemRegisterKnownId id, ushort value, Arm64SystemRegisterKind kind)
    {
        _value = (ulong)id | ((ulong)value << 16) | ((ulong)kind << 32);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64SystemRegister"/> struct.
    /// </summary>
    /// <param name="id">The known ID of the system register.</param>
    public Arm64SystemRegister(Arm64SystemRegisterKnownId id)
    {
        var value = Arm64SystemRegisterTable.GetValueById(id);
        var kind = Arm64SystemRegisterTable.GetKindById(id);
        _value = (ulong)id | ((ulong)value << 16) | ((ulong)kind << 32);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64SystemRegister"/> struct.
    /// </summary>
    /// <param name="value">The value of the system register.</param>
    public Arm64SystemRegister(ushort value)
    {
        Arm64SystemRegisterTable.TryFindIdByValue(value, out var id);
        var kind = Arm64SystemRegisterTable.GetKindById(id);
        _value = (ulong)id | ((ulong)value << 16) | ((ulong)kind << 32);
    }

    /// <summary>
    /// Gets the known ID of the system register.
    /// </summary>
    public Arm64SystemRegisterKnownId Id => (Arm64SystemRegisterKnownId)_value;

    /// <summary>
    /// Gets the value of the system register.
    /// </summary>
    public ushort Value => (ushort)(_value >> 16);

    /// <summary>
    /// Gets the kind of the system register.
    /// </summary>
    public Arm64SystemRegisterKind Kind => (Arm64SystemRegisterKind)(_value >> 32);

    /// <inheritdoc />
    public bool Equals(Arm64SystemRegister other) => _value == other._value;

    /// <inheritdoc />
    public override bool Equals(object? obj) => obj is Arm64SystemRegister other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => _value.GetHashCode();

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider = null)
    {
        Span<char> buffer = stackalloc char[64];
        var result = TryFormat(buffer, out var charsWritten, format, formatProvider);
        Debug.Assert(result);
        return buffer.Slice(0, charsWritten).ToString();
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
    {
        var id = Id;
        if (id != Arm64SystemRegisterKnownId.None && (format.Length == 0 || (format.Length != 1 || format[0] != 'G')))
        {
            var text = Arm64SystemRegisterTable.GetNameById(id);

            if ((Kind & (Arm64SystemRegisterKind.AT | Arm64SystemRegisterKind.TLBI | Arm64SystemRegisterKind.DC | Arm64SystemRegisterKind.IC)) != 0)
            {
                int lowerWritten = text.AsSpan().ToLowerInvariant(destination);
                if (lowerWritten < 0)
                {
                    charsWritten = 0;
                    return false;
                }

                charsWritten = lowerWritten;
                return true;
            }
            else
            {
                if (text.AsSpan().TryCopyTo(destination))
                {
                    charsWritten = text.Length;
                    return true;
                }
            }

            charsWritten = 0;
            return false;
        }

        var sysValue = Value;

        // Extract fields from the ushort value
        // S<op0>_<op1>_<Cn>_<Cm>_<op2>
        var op0 = (sysValue >> 14) & 0b11;
        var op1 = (sysValue >> 11) & 0b111;
        var crn = (sysValue >> 7) & 0b1111;
        var crm = (sysValue >> 3) & 0b1111;
        var op2 = (sysValue) & 0b111;

        return destination.TryWrite(provider, $"S{op0}_{op1}_C{crn}_C{crm}_{op2}", out charsWritten);
    }

    /// <summary>
    /// Implicitly converts a known ID to an <see cref="Arm64SystemRegister"/>.
    /// </summary>
    /// <param name="id">The known ID of the system register.</param>
    public static implicit operator Arm64SystemRegister(Arm64SystemRegisterKnownId id) => new(id);

    /// <summary>
    /// Implicitly converts a value to an <see cref="Arm64SystemRegister"/>.
    /// </summary>
    /// <param name="value">The value of the system register.</param>
    public static implicit operator Arm64SystemRegister(ushort value) => new(value);

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64SystemRegister"/> are equal.
    /// </summary>
    /// <param name="left">The first instance to compare.</param>
    /// <param name="right">The second instance to compare.</param>
    /// <returns>true if the instances are equal; otherwise, false.</returns>
    public static bool operator ==(Arm64SystemRegister left, Arm64SystemRegister right) => left.Equals(right);

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64SystemRegister"/> are not equal.
    /// </summary>
    /// <param name="left">The first instance to compare.</param>
    /// <param name="right">The second instance to compare.</param>
    /// <returns>true if the instances are not equal; otherwise, false.</returns>
    public static bool operator !=(Arm64SystemRegister left, Arm64SystemRegister right) => !left.Equals(right);
}
