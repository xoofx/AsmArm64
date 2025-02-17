// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 enum operand.
/// </summary>
public readonly struct Arm64EnumOperand : IArm64Operand
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64EnumOperand"/> struct.
    /// </summary>
    /// <param name="operand">The operand to initialize from.</param>
    internal Arm64EnumOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
        Flags = operand.Flags;
        var rawValue = operand.RawValue;

        // buffer[1] = (byte)EnumKind;
        // if (EnumKind == Arm64EnumKind.ProcessStateField)
        // {
        //     buffer[2] = (byte)ExtractIndex;
        // }
        // else if (EnumKind != Arm64EnumKind.RangePrefetchOperation)
        // {
        //     buffer[2] = (byte)EnumEncoding.LowBit;
        //     buffer[3] = (byte)EnumEncoding.Width;
        // }
        EnumKind = (Arm64EnumKind)(descriptor >> 8);

        switch (EnumKind)
        {
            case Arm64EnumKind.RangePrefetchOperation:
                // (12:4),(0:5)
                // option: 13-15
                // S: 12
                // Rt: 0-4
                // imm6 option<2>:option<0>:S:Rt<2:0>
                var value = (rawValue & 0x7) | ((rawValue >> 9) & 0x18) | ((rawValue >> 10) & 0x20);
                switch ((Arm64RangePrefetchOperationKind)value)
                {
                    case Arm64RangePrefetchOperationKind.PLDKEEP:
                    case Arm64RangePrefetchOperationKind.PSTKEEP:
                    case Arm64RangePrefetchOperationKind.PLDSTRM:
                    case Arm64RangePrefetchOperationKind.PSTSTRM:
                        break;
                    default:
                        IsImmediate = true;
                        break;
                }
                Value = (int)value;
                break;
            case Arm64EnumKind.ProcessStateField:
                Arm64ProcessStateFieldHelper.TryDecode(rawValue, (byte)(descriptor >> 16), out var processStateField);
                Value = (int)processStateField;
                break;
            case Arm64EnumKind.BarrierOperationLimit:
                Value = Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 16), (byte)(descriptor >> 24), 0);

                if (Value == 0 || !Enum.IsDefined((Arm64BarrierOperationLimitKind)Value))
                {
                    IsImmediate = true;
                }
                break;
            default:
                // Regular encoding
                Value = Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 16), (byte)(descriptor >> 24), 0);
                break;
        }
    }

    /// <summary>
    /// Gets the kind of the operand.
    /// </summary>
    public Arm64OperandKind Kind => Arm64OperandKind.Enum;

    /// <summary>
    /// Gets the kind of the enum.
    /// </summary>
    public Arm64EnumKind EnumKind { get; }

    /// <summary>
    /// Gets the value of the operand.
    /// </summary>
    public int Value { get; }

    /// <summary>
    /// Gets a value indicating whether the operand is optional.
    /// </summary>
    public bool IsOptional => (Flags & Arm64OperandFlags.Optional) != 0;

    /// <summary>
    /// Gets the flags of the operand.
    /// </summary>
    public Arm64OperandFlags Flags { get; }

    /// <summary>
    /// Gets a value indicating whether the operand is immediate.
    /// </summary>
    public bool IsImmediate { get; }

    /// <summary>
    /// Gets the conditional kind of the operand.
    /// </summary>
    public Arm64ConditionalKind AsConditional
    {
        get
        {
            if (EnumKind == Arm64EnumKind.Conditional)
            {
                return (Arm64ConditionalKind)Value;
            }
            else if (EnumKind == Arm64EnumKind.InvertedConditional)
            {
                return ((Arm64ConditionalKind)Value).Invert();
            }
            return Arm64ConditionalKind.Undefined;
        }
    }

    /// <summary>
    /// Gets the data synchronization kind of the operand.
    /// </summary>
    public Arm64DataSynchronizationKind AsDataSynchronization => EnumKind == Arm64EnumKind.DataSynchronizationOption ? (Arm64DataSynchronizationKind)(Value) : Arm64DataSynchronizationKind.Undefined;

    /// <summary>
    /// Gets the stored shared hint policy kind of the operand.
    /// </summary>
    public Arm64StoredSharedHintPolicyKind AsStoredSharedHintPolicy => EnumKind == Arm64EnumKind.StoredSharedHintPolicy ? (Arm64StoredSharedHintPolicyKind)(Value) : Arm64StoredSharedHintPolicyKind.Undefined;

    /// <summary>
    /// Gets the branch target identification kind of the operand.
    /// </summary>
    public Arm64BranchTargetIdentificationKind AsBranchTargetIdentification => EnumKind == Arm64EnumKind.BranchTargetIdentification ? (Arm64BranchTargetIdentificationKind)(Value) : Arm64BranchTargetIdentificationKind.Undefined;

    /// <summary>
    /// Gets the barrier operation limit kind of the operand.
    /// </summary>
    public Arm64BarrierOperationLimitKind AsBarrierOperationLimit => EnumKind == Arm64EnumKind.BarrierOperationLimit ? (Arm64BarrierOperationLimitKind)(Value) : Arm64BarrierOperationLimitKind.Undefined;

    /// <summary>
    /// Gets the prefetch operation kind of the operand.
    /// </summary>
    public Arm64PrefetchOperationKind AsPrefetchOperation => EnumKind == Arm64EnumKind.PrefetchOperation ? (Arm64PrefetchOperationKind)(Value) : Arm64PrefetchOperationKind.Undefined;

    /// <summary>
    /// Gets the range prefetch operation kind of the operand.
    /// </summary>
    public Arm64RangePrefetchOperationKind AsRangePrefetchOperation => !IsImmediate && EnumKind == Arm64EnumKind.RangePrefetchOperation ? (Arm64RangePrefetchOperationKind)(Value) : Arm64RangePrefetchOperationKind.Undefined;

    /// <summary>
    /// Gets the process state field kind of the operand.
    /// </summary>
    public Arm64ProcessStateField AsProcessStateField => EnumKind == Arm64EnumKind.ProcessStateField ? (Arm64ProcessStateField)Value : Arm64ProcessStateField.Undefined;

    /// <summary>
    /// Gets the code synchronization kind of the operand.
    /// </summary>
    public Arm64CodeSyncKind AsCodeSync => EnumKind == Arm64EnumKind.CodeSync ? Arm64CodeSyncKind.CSYNC : Arm64CodeSyncKind.Undefined;

    /// <summary>
    /// Gets the data synchronization kind of the operand.
    /// </summary>
    public Arm64DataSyncKind AsDataSync => EnumKind == Arm64EnumKind.DataSync ? Arm64DataSyncKind.DSYNC : Arm64DataSyncKind.Undefined;

    /// <summary>
    /// Gets the restriction by context kind of the operand.
    /// </summary>
    public Arm64RestrictionByContextKind AsRestrictionByContext => EnumKind == Arm64EnumKind.RestrictionByContext ? Arm64RestrictionByContextKind.RCTX : Arm64RestrictionByContextKind.Undefined;

    /// <summary>
    /// Gets the streaming mode kind of the operand.
    /// </summary>
    public Arm64StreamingMode AsStreamingMode => EnumKind == Arm64EnumKind.StreamingMode ? (Arm64StreamingMode)Value : Arm64StreamingMode.Reserved;

    /// <inheritdoc />
    public override string ToString() => ToString(null, null);

    /// <inheritdoc />
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        // 8 ~= Shift max 3, amount maximum 2 digits, 1 space, 1 #
        Span<char> span = stackalloc char[8];
        var result = TryFormat(span, out var written, format, formatProvider);
        Debug.Assert(result);
        return span.Slice(0, written).ToString();
    }

    /// <inheritdoc />
    public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format,
        IFormatProvider? provider)
        => TryFormat(default, destination, out charsWritten, out _, format, provider, null);

    /// <summary>
    /// Tries to format the operand.
    /// </summary>
    /// <param name="instruction">The instruction.</param>
    /// <param name="destination">The destination span.</param>
    /// <param name="charsWritten">The number of characters written.</param>
    /// <param name="isDefaultValue">Indicates if the value is default.</param>
    /// <param name="format">The format.</param>
    /// <param name="provider">The format provider.</param>
    /// <param name="tryFormatLabel">The try format label delegate.</param>
    /// <returns>True if formatting was successful; otherwise, false.</returns>
    public bool TryFormat(Arm64Instruction instruction, Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, Arm64TryFormatDelegate? tryFormatLabel)
    {
        isDefaultValue = false;

        // keepCasing is used to keep the casing of the format
        var forceLowerCase = format.Length == 0 || format[0] != 'H';
        charsWritten = 0;
        if (IsImmediate)
        {
            return destination.TryWrite($"#{Value}", out charsWritten);
        }

        bool result;
        switch (EnumKind)
        {
            case Arm64EnumKind.Conditional:
            case Arm64EnumKind.InvertedConditional:
                result = Enum.TryFormat(AsConditional, destination, out charsWritten);
                break;
            case Arm64EnumKind.DataSynchronizationOption:
                result = Enum.TryFormat(AsDataSynchronization, destination, out charsWritten);
                break;
            case Arm64EnumKind.StoredSharedHintPolicy:
                result = Enum.TryFormat(AsStoredSharedHintPolicy, destination, out charsWritten);
                break;
            case Arm64EnumKind.BranchTargetIdentification:
                isDefaultValue = AsBranchTargetIdentification == Arm64BranchTargetIdentificationKind.Absent;
                result = Enum.TryFormat(AsBranchTargetIdentification, destination, out charsWritten);
                break;
            case Arm64EnumKind.BarrierOperationLimit:
                result = Enum.TryFormat(AsBarrierOperationLimit, destination, out charsWritten);
                break;
            case Arm64EnumKind.PrefetchOperation:
                result = Enum.TryFormat(AsPrefetchOperation, destination, out charsWritten);
                break;
            case Arm64EnumKind.RangePrefetchOperation:
                result = Enum.TryFormat(AsRangePrefetchOperation, destination, out charsWritten);
                break;
            case Arm64EnumKind.ProcessStateField:
                result = Enum.TryFormat(AsProcessStateField, destination, out charsWritten);
                forceLowerCase = false;
                break;
            case Arm64EnumKind.CodeSync:
                result = Enum.TryFormat(AsCodeSync, destination, out charsWritten);
                break;
            case Arm64EnumKind.DataSync:
                result = Enum.TryFormat(AsDataSync, destination, out charsWritten);
                break;
            case Arm64EnumKind.RestrictionByContext:
                result = Enum.TryFormat(AsRestrictionByContext, destination, out charsWritten);
                break;
            case Arm64EnumKind.StreamingMode:
                result = Enum.TryFormat(AsStreamingMode, destination, out charsWritten);
                break;
            default:
                result = false;
                break;
        }

        if (result)
        {
            // TODO: Optimize with precalculated string
            var span = destination.Slice(0, charsWritten);
            if (forceLowerCase)
            {
                for (var i = 0; i < span.Length; i++)
                {
                    span[i] = char.ToLowerInvariant(span[i]);
                }
            }
        }
        else
        {
            if (destination.Length < "???".Length)
            {
                charsWritten = 0;
                return false;
            }
            "???".AsSpan().CopyTo(destination);
            charsWritten = 3;
        }

        return true;
    }

    /// <summary>
    /// Explicitly converts an <see cref="Arm64Operand"/> to an <see cref="Arm64EnumOperand"/>.
    /// </summary>
    /// <param name="operand">The operand to convert.</param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64EnumOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Enum) ThrowInvalidCast(operand.Kind);
        return new Arm64EnumOperand(operand);
    }

    /// <summary>
    /// Throws an <see cref="InvalidCastException"/> when an invalid cast is attempted.
    /// </summary>
    /// <param name="kind">The kind of the operand.</param>
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64EnumOperand)}");
}
