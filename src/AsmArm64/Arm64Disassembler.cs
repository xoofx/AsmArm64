// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Disassembles ARM64 instructions from a byte buffer.
/// </summary>
/// <remarks>Instances are not thread-safe. Do not change options or reenter disassembly from formatting callbacks.</remarks>
public class Arm64Disassembler
{
    private readonly Dictionary<int, int> _internalLabels;
    private int _currentOffset;
    private Arm64InstructionId _currentInstructionId;
    private readonly Arm64TryFormatDelegate _tryFormatLabelDelegate;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Disassembler"/> class with default options.
    /// </summary>
    public Arm64Disassembler() : this(new Arm64DisassemblerOptions())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Disassembler"/> class with the specified options.
    /// </summary>
    /// <param name="options">The options to use for disassembling.</param>
    /// <exception cref="ArgumentNullException">The options are null.</exception>
    public Arm64Disassembler(Arm64DisassemblerOptions options)
    {
        ArgumentNullException.ThrowIfNull(options);
        _internalLabels = new();
        Options = options;
        _tryFormatLabelDelegate = TryFormatLabel;
    }

    /// <summary>
    /// Disassembles the specified byte buffer using default options and returns the text.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <param name="baseAddress">The base address used for address and label formatting.</param>
    /// <returns>A string containing the disassembled instructions.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="baseAddress"/> cannot be represented as a signed 64-bit value.</exception>
    /// <exception cref="InvalidOperationException">A formatted line exceeds the configured line buffer capacity.</exception>
    public static string DisassembleToString(ReadOnlySpan<byte> buffer, ulong baseAddress = 0x1_0000UL)
    {
        if (baseAddress > long.MaxValue) throw new ArgumentOutOfRangeException(nameof(baseAddress), "The base address must fit in a signed 64-bit value for disassembler options.");
        var disassembler = new Arm64Disassembler
        {
            Options =
            {
                BaseAddress = (long)baseAddress
            }
        };
        return disassembler.Disassemble(buffer);
    }

    /// <summary>
    /// Gets the options used for disassembling.
    /// </summary>
    public Arm64DisassemblerOptions Options { get; }

    /// <summary>
    /// Disassembles the specified byte buffer and returns the disassembled instructions as a string.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="buffer"/> is <c>null</c>.</exception>
    /// <returns>A string containing the disassembled instructions.</returns>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count.</exception>
    public string Disassemble(byte[] buffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        return Disassemble((ReadOnlySpan<byte>)buffer);
    }

    /// <summary>
    /// Disassembles the specified byte buffer and returns the disassembled instructions as a string.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <returns>A string containing the disassembled instructions.</returns>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count.</exception>
    public string Disassemble(Span<byte> buffer)
        => Disassemble((ReadOnlySpan<byte>)buffer);

    /// <summary>
    /// Disassembles the specified byte buffer and returns the disassembled instructions as a string.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <returns>A string containing the disassembled instructions.</returns>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count.</exception>
    public string Disassemble(ReadOnlySpan<byte> buffer)
    {
        var writer = new StringWriter();
        Disassemble(buffer, writer);
        return writer.ToString();
    }

    /// <summary>
    /// Disassembles the specified byte buffer and writes the disassembled instructions to the specified <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <param name="writer">The <see cref="TextWriter"/> to write the disassembled instructions to.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="buffer"/> or <paramref name="writer"/> is <c>null</c>.</exception>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count.</exception>
    public void Disassemble(byte[] buffer, TextWriter writer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        Disassemble((ReadOnlySpan<byte>)buffer, writer);
    }

    /// <summary>
    /// Disassembles the specified byte buffer and writes the disassembled instructions to the specified <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <param name="writer">The <see cref="TextWriter"/> to write the disassembled instructions to.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="writer"/> is <c>null</c>.</exception>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count.</exception>
    public void Disassemble(Span<byte> buffer, TextWriter writer)
        => Disassemble((ReadOnlySpan<byte>)buffer, writer);

    /// <summary>
    /// Disassembles the specified byte buffer and writes the disassembled instructions to the specified <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <param name="writer">The <see cref="TextWriter"/> to write the disassembled instructions to.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="writer"/> is <c>null</c>.</exception>
    /// <exception cref="InvalidOperationException">A formatted line exceeds <see cref="Arm64DisassemblerOptions.FormatLineBufferLength"/> or a callback returns an invalid character count. Earlier lines may already have been written.</exception>
    public void Disassemble(ReadOnlySpan<byte> buffer, TextWriter writer)
    {
        ArgumentNullException.ThrowIfNull(writer);

        var trailingByteCount = buffer.Length & 3;
        if (trailingByteCount != 0 && Options.InvalidDataMode == Arm64InvalidDataMode.Throw)
        {
            throw new ArgumentException($"The buffer length ({buffer.Length} bytes) is not aligned to the required 4-byte ARM64 instruction size.", nameof(buffer));
        }

        var instructionByteLength = buffer.Length - trailingByteCount;
        var instructionBuffer = buffer.Slice(0, instructionByteLength);
        var trailingBytes = buffer.Slice(instructionByteLength);
        var rawInstructions = MemoryMarshal.Cast<byte, uint>(instructionBuffer);

        // Clear the internal pending labels
        // And collect any new internal labels from the buffer
        // So that we can create labels for the disassembled instructions
        _internalLabels.Clear();

        // Create a label for the first instruction if requested
        if (Options.PrintLabelBeforeFirstInstruction && Options.AutoLabelKinds.HasFlag(Arm64DisassemblerAutoLabelKind.FirstInstruction))
        {
            _internalLabels.Add(0, 1);
        }

        for (int i = 0; i < rawInstructions.Length; i++)
        {
            var rawInstruction = rawInstructions[i];
            var instruction = Arm64Instruction.Decode(rawInstruction);
            if ((instruction.Flags & Arm64InstructionFlags.HasLabel) == 0)
            {
                continue;
            }

            for (int j = 0; j < instruction.OperandCount; j++)
            {
                var operand = instruction.GetOperand(j);
                if (operand.Kind == Arm64OperandKind.Label && ShouldAutoLabel(instruction.Id))
                {
                    var labelOperand = (Arm64LabelOperand)operand;
                    var absoluteOffset = unchecked(GetTargetAddress(instruction.Id, i * 4, labelOperand.Offset) - Options.BaseAddress);
                    if (absoluteOffset >= 0 && absoluteOffset <= instructionByteLength && (absoluteOffset & 3) == 0)
                    {
                        _internalLabels.TryAdd((int)absoluteOffset, _internalLabels.Count + 1);
                    }

                    break;
                }
            }
        }

        var textBuffer = ArrayPool<char>.Shared.Rent(Options.FormatLineBufferLength);
        try
        {
            var textSpan = textBuffer.AsSpan(0, Options.FormatLineBufferLength);

            bool nextNewLine = false;

            // Disassemble the instructions
            for (int i = 0; i < rawInstructions.Length; i++)
            {
                var rawInstruction = rawInstructions[i];

                var instruction = Arm64Instruction.Decode(rawInstruction);

                _currentOffset = i * 4;
                _currentInstructionId = instruction.Id;
                PrintLabel(_currentOffset, textSpan, writer, nextNewLine, i == 0, false);
                nextNewLine = false;

                // Pre instruction printer
                if (Options.PreInstructionPrinter is not null)
                {
                    Options.PreInstructionPrinter(_currentOffset, instruction, writer);
                }

                var runningSpan = textSpan;

                // Write the indent
                if (Options.PrintAddress || Options.PrintAssemblyBytes)
                {
                    if (Options.PrintAddress)
                    {
                        AppendText(ref runningSpan, FormatAddress(unchecked(Options.BaseAddress + _currentOffset)));
                        AppendSpaces(ref runningSpan, Options.IndentSize);
                    }

                    if (Options.PrintAssemblyBytes)
                    {
#if NETSTANDARD2_0
                        Span<byte> bytes = BitConverter.GetBytes(rawInstruction);
#else
                        var bytes = MemoryMarshal.AsBytes(new Span<uint>(ref rawInstruction));
#endif
                        var assemblyBytes = $"{FormatHexByte(bytes[0])} {FormatHexByte(bytes[1])} {FormatHexByte(bytes[2])} {FormatHexByte(bytes[3])}";
                        AppendText(ref runningSpan, assemblyBytes);
                        AppendSpaces(ref runningSpan, Options.IndentSize);
                    }
                }
                else
                {
                    AppendSpaces(ref runningSpan, Options.IndentSize);
                }

                // Write the instruction
                {
                    if (!instruction.TryFormat(runningSpan, out var instructionCharsWritten, null, Options.FormatProvider, _tryFormatLabelDelegate, Options.InstructionFormatting))
                        ThrowLineBufferTooSmall();
                    runningSpan = runningSpan.Slice(instructionCharsWritten);

                    // Write padding
                    if (Options.TryFormatComment is not null && Options.InstructionTextPaddingLength > instructionCharsWritten)
                    {
                        AppendSpaces(ref runningSpan, Options.InstructionTextPaddingLength - instructionCharsWritten);
                    }

                    if (Options.TryFormatComment is not null)
                    {
                        AppendSpaces(ref runningSpan, 4);
                        var commentPrefix = Options.CommentPrefix;
                        AppendText(ref runningSpan, commentPrefix);
                        if (commentPrefix.Length != 0)
                        {
                            AppendSpaces(ref runningSpan, 1);
                        }
                        if (Options.TryFormatComment(_currentOffset, instruction, runningSpan, out var commentsCharsWritten))
                        {
                            ValidateFormattedLength(commentsCharsWritten, runningSpan.Length);
                            runningSpan = runningSpan.Slice(commentsCharsWritten);
                        }
                    }

                    WriteLine(writer, textSpan.Slice(0, textSpan.Length - runningSpan.Length).TrimEnd(' '));
                    if (instruction.Id.IsBranch())
                    {
                        nextNewLine = true;
                    }
                }

                // Post instruction printer
                if (Options.PostInstructionPrinter is not null)
                {
                    Options.PostInstructionPrinter(_currentOffset, instruction, writer);
                }
            }

            _currentOffset = rawInstructions.Length * 4;
            // Print any pending labels
            PrintLabel(_currentOffset, textSpan, writer, false, false, trailingByteCount == 0);

            if (trailingByteCount != 0 && Options.InvalidDataMode == Arm64InvalidDataMode.EmitBytes)
            {
                PrintTrailingBytes(trailingBytes, textSpan, writer);
            }
        }
        finally
        {
            ArrayPool<char>.Shared.Return(textBuffer);
        }
    }

    private static void AppendText(ref Span<char> destination, ReadOnlySpan<char> text)
    {
        if (!text.TryCopyTo(destination)) ThrowLineBufferTooSmall();
        destination = destination.Slice(text.Length);
    }

    private static void AppendSpaces(ref Span<char> destination, int count)
    {
        if ((uint)count > (uint)destination.Length) ThrowLineBufferTooSmall();
        destination.Slice(0, count).Fill(' ');
        destination = destination.Slice(count);
    }

    [DoesNotReturn]
    private static void ThrowLineBufferTooSmall()
        => throw new InvalidOperationException("The formatted line exceeds FormatLineBufferLength. Increase the disassembler's FormatLineBufferLength.");

    private static void ValidateFormattedLength(int count, int available)
    {
        if ((uint)count > (uint)available)
            throw new InvalidOperationException("The formatting callback returned an invalid character count.");
    }

    private static void WriteLine(TextWriter writer, ReadOnlySpan<char> text)
#if NETSTANDARD2_0
        => writer.WriteLine(text.ToString());
#else
        => writer.WriteLine(text);
#endif

    private string FormatAddress(long address)
        => Options.AddressPrefix + address.ToString(Options.UseUppercaseHex ? "X16" : "x16", CultureInfo.InvariantCulture);

    private string FormatHexByte(byte value)
        => value.ToString(Options.UseUppercaseHex ? "X2" : "x2", CultureInfo.InvariantCulture);

    private string FormatLocalLabel(int labelIndex)
        => Options.LocalLabelFormat == Arm64DisassemblerOptions.DefaultLocalLabelFormat
            ? $"{Options.LocalLabelPrefix}{labelIndex:00}"
            : string.Format(CultureInfo.InvariantCulture, Options.LocalLabelFormat, labelIndex);

    private bool ShouldAutoLabel(Arm64InstructionId id)
    {
        var enabledKinds = Options.AutoLabelKinds;
        if (enabledKinds == Arm64DisassemblerAutoLabelKind.None) return false;

        var targetKind = GetAutoLabelKind(id);
        return targetKind != Arm64DisassemblerAutoLabelKind.None && (enabledKinds & targetKind) != 0;
    }

    private static Arm64DisassemblerAutoLabelKind GetAutoLabelKind(Arm64InstructionId id)
    {
        if (id == Arm64InstructionId.ADR_only_pcreladdr) return Arm64DisassemblerAutoLabelKind.Adr;
        if (id == Arm64InstructionId.ADRP_only_pcreladdr) return Arm64DisassemblerAutoLabelKind.Adrp;
        if (id == Arm64InstructionId.BL_only_branch_imm) return Arm64DisassemblerAutoLabelKind.Calls;
        if (id == Arm64InstructionId.B_only_branch_imm) return Arm64DisassemblerAutoLabelKind.Branches;
        if (id == Arm64InstructionId.B_only_condbranch || id == Arm64InstructionId.BC_only_condbranch) return Arm64DisassemblerAutoLabelKind.ConditionalBranches;

        var idText = id.ToString();
        if (idText.Contains("_loadlit", StringComparison.Ordinal)) return Arm64DisassemblerAutoLabelKind.LiteralLoads;
        if (idText.StartsWith("CB", StringComparison.Ordinal) || idText.StartsWith("TB", StringComparison.Ordinal)) return Arm64DisassemblerAutoLabelKind.TestCompareBranches;
        if (id.IsBranch()) return Arm64DisassemblerAutoLabelKind.Branches;
        return Arm64DisassemblerAutoLabelKind.None;
    }

    private void PrintTrailingBytes(ReadOnlySpan<byte> trailingBytes, Span<char> textSpan, TextWriter writer)
    {
        var runningSpan = textSpan;

        if (Options.PrintAddress)
        {
            AppendText(ref runningSpan, FormatAddress(unchecked(Options.BaseAddress + _currentOffset)));
        }
        AppendSpaces(ref runningSpan, Options.IndentSize);

        AppendText(ref runningSpan, ".byte ");

        for (var i = 0; i < trailingBytes.Length; i++)
        {
            if (i > 0)
            {
                AppendText(ref runningSpan, ", ");
            }

            AppendText(ref runningSpan, $"0x{FormatHexByte(trailingBytes[i])}");
        }

        WriteLine(writer, textSpan.Slice(0, textSpan.Length - runningSpan.Length));
    }

    private void PrintLabel(int offset, Span<char> textSpan, TextWriter writer, bool nextNewLine, bool isFirstLabel, bool isLast)
    {
        if (_internalLabels.TryGetValue(offset, out var labelIndex))
        {
            if (Options.PrintNewLineBeforeLabel && !isFirstLabel)
            {
                writer.WriteLine();
            }
            var runningSpan = textSpan;
            if (Options.TryFormatLabel is not null && Options.TryFormatLabel(unchecked(Options.BaseAddress + offset), runningSpan, out var charsWritten))
            {
                ValidateFormattedLength(charsWritten, runningSpan.Length);
                runningSpan = runningSpan.Slice(charsWritten);
            }
            else
            {
                AppendText(ref runningSpan, FormatLocalLabel(labelIndex));
            }
            AppendText(ref runningSpan, ":");
            WriteLine(writer, textSpan.Slice(0, textSpan.Length - runningSpan.Length));
        }
        else
        {
            if (Options.PrintNewLineAfterBranch && nextNewLine && !isLast)
            {
                writer.WriteLine();
            }
        }
    }

    private long GetTargetAddress(Arm64InstructionId id, int instructionOffset, long labelOffset)
    {
        var address = unchecked(Options.BaseAddress + instructionOffset);
        if (id == Arm64InstructionId.ADRP_only_pcreladdr) address &= ~0xFFFL;
        return unchecked(address + labelOffset);
    }

    private bool TryFormatLabel(long offset, Span<char> textSpan, out int charsWritten)
    {
        var targetAddress = GetTargetAddress(_currentInstructionId, _currentOffset, offset);

        var tryFormatLabel = Options.TryFormatLabel;
        if (tryFormatLabel is not null && tryFormatLabel(targetAddress, textSpan, out charsWritten))
        {
            ValidateFormattedLength(charsWritten, textSpan.Length);
            return true;
        }

        var absoluteOffset = unchecked(targetAddress - Options.BaseAddress);
        string labelText;
        if (ShouldAutoLabel(_currentInstructionId) && absoluteOffset >= 0 && absoluteOffset <= int.MaxValue && _internalLabels.TryGetValue((int)absoluteOffset, out var labelIndex))
        {
            labelText = FormatLocalLabel(labelIndex);
        }
        else if (Options.LabelFallback == Arm64DisassemblerLabelFallback.AbsoluteAddress)
        {
            var operandAddressPrefix = string.IsNullOrEmpty(Options.AddressPrefix) ? "0x" : Options.AddressPrefix;
            labelText = $"#{operandAddressPrefix}{targetAddress.ToString(Options.UseUppercaseHex ? "X16" : "x16", CultureInfo.InvariantCulture)}";
        }
        else
        {
            charsWritten = 0;
            return false;
        }
        AppendText(ref textSpan, labelText);
        charsWritten = labelText.Length;
        return true;
    }
}
