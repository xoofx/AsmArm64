// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace AsmArm64;

public readonly struct Arm64EnumOperand : IArm64Operand
{
    internal Arm64EnumOperand(Arm64Operand operand)
    {
        var descriptor = operand.Descriptor;
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
                Value = Arm64DecodingHelper.GetBitRange2(rawValue, 12, 4, 0, 5, 0);
                break;
            case Arm64EnumKind.ProcessStateField:
                Arm64ProcessStateFieldHelper.TryDecode(rawValue, (byte)(descriptor >> 16), out var processStateField);
                Value = (int)processStateField;
                break;
            default:
                // Regular encoding
                Value = Arm64DecodingHelper.GetBitRange1(rawValue, (byte)(descriptor >> 16), (byte)(descriptor >> 24), 0);
                break;
        }
    }

    public Arm64OperandKind Kind => Arm64OperandKind.Enum;

    public Arm64EnumKind EnumKind { get; }

    public int Value { get; }

    public Arm64ConditionalKind AsConditional => EnumKind == Arm64EnumKind.Conditional ? (Arm64ConditionalKind)(Value + 1) : Arm64ConditionalKind.None;

    public Arm64DataSynchronizationKind AsDataSynchronization => EnumKind == Arm64EnumKind.DataSynchronizationOption ? (Arm64DataSynchronizationKind)(Value + 1) : Arm64DataSynchronizationKind.None;

    public Arm64StoredSharedHintPolicyKind AsStoredSharedHintPolicy => EnumKind == Arm64EnumKind.StoredSharedHintPolicy ? (Arm64StoredSharedHintPolicyKind)(Value + 1) : Arm64StoredSharedHintPolicyKind.None;
    
    public Arm64BranchTargetIdentificationKind AsBranchTargetIdentification => EnumKind == Arm64EnumKind.BranchTargetIdentification ? (Arm64BranchTargetIdentificationKind)(Value + 1) : Arm64BranchTargetIdentificationKind.None;

    public Arm64BarrierOperationLimitKind AsBarrierOperationLimit => EnumKind == Arm64EnumKind.BarrierOperationLimit ? (Arm64BarrierOperationLimitKind)(Value + 1) : Arm64BarrierOperationLimitKind.None;

    public Arm64PrefetchOperationKind AsPrefetchOperation => EnumKind == Arm64EnumKind.PrefetchOperation ? (Arm64PrefetchOperationKind)(Value + 1) : Arm64PrefetchOperationKind.None;

    public Arm64RangePrefetchOperationKind AsRangePrefetchOperation => EnumKind == Arm64EnumKind.RangePrefetchOperation ? (Arm64RangePrefetchOperationKind)(Value + 1) : Arm64RangePrefetchOperationKind.None;

    public Arm64ProcessStateField AsProcessStateField => EnumKind == Arm64EnumKind.ProcessStateField ? (Arm64ProcessStateField)(Value + 1) : Arm64ProcessStateField.None;

    public Arm64CodeSyncKind AsCodeSync => EnumKind == Arm64EnumKind.CodeSync ? Arm64CodeSyncKind.CSYNC : Arm64CodeSyncKind.None;

    public Arm64DataSyncKind AsDataSync => EnumKind == Arm64EnumKind.DataSync ? Arm64DataSyncKind.DSYNC : Arm64DataSyncKind.None;

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
        => TryFormat(destination, out charsWritten, out _, format, provider);
    
    public bool TryFormat(Span<char> destination, out int charsWritten, out bool isDefaultValue, ReadOnlySpan<char> format, IFormatProvider? provider, TryResolveLabelDelegate? tryResolveLabel = null)
    {
        isDefaultValue = false;

        var isUpperCase = format.Length == 1 && format[0] == 'H';
        charsWritten = 0;
        if (EnumKind switch
            {
                Arm64EnumKind.Conditional => Enum.TryFormat(AsConditional, destination, out charsWritten),
                Arm64EnumKind.DataSynchronizationOption => Enum.TryFormat(AsDataSynchronization, destination, out charsWritten),
                Arm64EnumKind.StoredSharedHintPolicy => Enum.TryFormat(AsStoredSharedHintPolicy, destination, out charsWritten),
                Arm64EnumKind.BranchTargetIdentification => Enum.TryFormat(AsBranchTargetIdentification, destination, out charsWritten),
                Arm64EnumKind.BarrierOperationLimit => Enum.TryFormat(AsBarrierOperationLimit, destination, out charsWritten),
                Arm64EnumKind.PrefetchOperation => Enum.TryFormat(AsPrefetchOperation, destination, out charsWritten),
                Arm64EnumKind.RangePrefetchOperation => Enum.TryFormat(AsRangePrefetchOperation, destination, out charsWritten),
                Arm64EnumKind.ProcessStateField => Enum.TryFormat(AsProcessStateField, destination, out charsWritten),
                Arm64EnumKind.CodeSync => Enum.TryFormat(AsCodeSync, destination, out charsWritten),
                Arm64EnumKind.DataSync => Enum.TryFormat(AsDataSync, destination, out charsWritten),
                _ => false
            })
        {
            // TODO: Optimize with precalculated string
            var span = destination.Slice(0, charsWritten);
            if (isUpperCase)
            {
                for (var i = 0; i < span.Length; i++)
                {
                    span[i] = char.ToUpperInvariant(span[i]);
                }
            }
            else
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

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static explicit operator Arm64EnumOperand(Arm64Operand operand)
    {
        if (operand.Kind != Arm64OperandKind.Enum) ThrowInvalidCast(operand.Kind);
        return new Arm64EnumOperand(operand);
    }
    
    [DoesNotReturn, MethodImpl(MethodImplOptions.NoInlining)]
    private static void ThrowInvalidCast(Arm64OperandKind kind) => throw new InvalidCastException($"Cannot cast Operand `{kind}` to {nameof(Arm64EnumOperand)}");
}