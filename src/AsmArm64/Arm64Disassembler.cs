// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Buffers;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AsmArm64;

/// <summary>
/// Disassembles ARM64 instructions from a byte buffer.
/// </summary>
public class Arm64Disassembler
{
    private readonly Dictionary<int, int> _internalLabels;
    private int _currentOffset;
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
    public Arm64Disassembler(Arm64DisassemblerOptions options)
    {
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
    public string Disassemble(Span<byte> buffer)
        => Disassemble((ReadOnlySpan<byte>)buffer);

    /// <summary>
    /// Disassembles the specified byte buffer and returns the disassembled instructions as a string.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <returns>A string containing the disassembled instructions.</returns>
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
    public void Disassemble(Span<byte> buffer, TextWriter writer)
        => Disassemble((ReadOnlySpan<byte>)buffer, writer);

    /// <summary>
    /// Disassembles the specified byte buffer and writes the disassembled instructions to the specified <see cref="TextWriter"/>.
    /// </summary>
    /// <param name="buffer">The byte buffer containing the instructions to disassemble.</param>
    /// <param name="writer">The <see cref="TextWriter"/> to write the disassembled instructions to.</param>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="writer"/> is <c>null</c>.</exception>
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
                    var absoluteOffset = i * 4 + labelOperand.Offset;
                    if (absoluteOffset >= 0 && absoluteOffset <= instructionByteLength)
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
            var textSpan = textBuffer.AsSpan();

            bool nextNewLine = false;

            // Disassemble the instructions
            for (int i = 0; i < rawInstructions.Length; i++)
            {
                var rawInstruction = rawInstructions[i];

                var instruction = Arm64Instruction.Decode(rawInstruction);

                _currentOffset = i * 4;
                PrintLabel(_currentOffset, textSpan, writer, nextNewLine, i == 0, false);
                nextNewLine = false;

                // Pre instruction printer
                if (Options.PreInstructionPrinter is not null)
                {
                    Options.PreInstructionPrinter(_currentOffset, instruction, writer);
                }

                var runningSpan = textSpan;
                int charsWritten = 0;

                // Write the indent
                if (Options.PrintAddress || Options.PrintAssemblyBytes)
                {
                    if (Options.PrintAddress)
                    {
                        FormatAddress(Options.BaseAddress + _currentOffset).AsSpan().TryCopyTo(textSpan);
                        var localCharsWritten = Options.AddressPrefix.Length + 16;
                        charsWritten += localCharsWritten;
                        runningSpan = textSpan.Slice(localCharsWritten);

                        TryWriteSpaces(runningSpan, Options.IndentSize);
                        charsWritten += Options.IndentSize;
                        runningSpan = runningSpan.Slice(Options.IndentSize);
                    }

                    if (Options.PrintAssemblyBytes)
                    {
#if NETSTANDARD2_0
                        Span<byte> bytes = BitConverter.GetBytes(rawInstruction);
#else
                        var bytes = MemoryMarshal.AsBytes(new Span<uint>(ref rawInstruction));
#endif
                        var assemblyBytes = $"{FormatHexByte(bytes[0])} {FormatHexByte(bytes[1])} {FormatHexByte(bytes[2])} {FormatHexByte(bytes[3])}";
                        assemblyBytes.AsSpan().TryCopyTo(runningSpan);
                        var localCharsWritten = assemblyBytes.Length;
                        charsWritten += localCharsWritten;
                        runningSpan = runningSpan.Slice(localCharsWritten);

                        TryWriteSpaces(runningSpan, Options.IndentSize);
                        charsWritten += Options.IndentSize;
                        runningSpan = runningSpan.Slice(Options.IndentSize);
                    }
                }
                else
                {
                    TryWriteSpaces(runningSpan, Options.IndentSize);
                    charsWritten += Options.IndentSize;
                    runningSpan = runningSpan.Slice(Options.IndentSize);
                }

                // Write the instruction
                {
                    instruction.TryFormat(runningSpan, out var instructionCharsWritten, null, Options.FormatProvider, _tryFormatLabelDelegate);
                    charsWritten += instructionCharsWritten;
                    runningSpan = runningSpan.Slice(instructionCharsWritten);

                    // Write padding
                    if (Options.InstructionTextPaddingLength > 0 && instructionCharsWritten < Options.InstructionTextPaddingLength && TryWriteSpaces(runningSpan, Options.InstructionTextPaddingLength - instructionCharsWritten))
                    {
                        var paddingWritten = Options.InstructionTextPaddingLength - instructionCharsWritten;
                        charsWritten += paddingWritten;
                        runningSpan = runningSpan.Slice(paddingWritten);
                    }

                    if (Options.TryFormatComment is not null && TryWriteSpaces(runningSpan, 4))
                    {
                        charsWritten += 4;
                        runningSpan = runningSpan.Slice(4);

                        var commentPrefix = Options.CommentPrefix;
                        if (commentPrefix.Length == 0 || commentPrefix.AsSpan().TryCopyTo(runningSpan))
                        {
                            charsWritten += commentPrefix.Length;
                            runningSpan = runningSpan.Slice(commentPrefix.Length);
                            if (commentPrefix.Length != 0)
                            {
                                runningSpan[0] = ' ';
                                charsWritten++;
                                runningSpan = runningSpan.Slice(1);
                            }

                            if (Options.TryFormatComment(_currentOffset, instruction, runningSpan, out var commentsCharsWritten))
                            {
                                charsWritten += commentsCharsWritten;
                                runningSpan = runningSpan.Slice(commentsCharsWritten);
                            }
                        }
                    }

                    runningSpan = textSpan.Slice(0, charsWritten);

#if NETSTANDARD2_0
                    writer.WriteLine(runningSpan.TrimEnd(' ').ToString());
#else
                    runningSpan = runningSpan.TrimEnd(' ');
                    writer.WriteLine(runningSpan);
#endif
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

    private Span<char> GetIndentSpan(Span<char> textSpan)
    {
        var indentSize = Math.Min((int)Options.IndentSize, textSpan.Length);
        if (indentSize > 0)
        {
            for (int indent = 0; indent < indentSize; indent++)
            {
                textSpan[indent] = ' ';
            }

            return textSpan.Slice(0, indentSize);
        }

        return default;
    }

    private bool TryWriteSpaces(Span<char> textSpan, int count)
    {
        if (count > textSpan.Length)
        {
            return false;
        }
        for (int i = 0; i < count; i++)
        {
            textSpan[i] = ' ';
        }
        return true;
    }

    private void WriteIndentSize(Span<char> textSpan, TextWriter writer)
#if NETSTANDARD2_0
        => writer.Write(GetIndentSpan(textSpan).ToArray());
#else
        => writer.Write(GetIndentSpan(textSpan));
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
        var charsWritten = 0;

        if (Options.PrintAddress)
        {
            var addressText = FormatAddress(Options.BaseAddress + _currentOffset);
            addressText.AsSpan().TryCopyTo(textSpan);
            var addressCharsWritten = addressText.Length;
            charsWritten += addressCharsWritten;
            runningSpan = textSpan.Slice(addressCharsWritten);

            TryWriteSpaces(runningSpan, Options.IndentSize);
            charsWritten += Options.IndentSize;
            runningSpan = runningSpan.Slice(Options.IndentSize);
        }
        else
        {
            TryWriteSpaces(runningSpan, Options.IndentSize);
            charsWritten += Options.IndentSize;
            runningSpan = runningSpan.Slice(Options.IndentSize);
        }

        ".byte ".TryCopyTo(runningSpan);
        charsWritten += 6;
        runningSpan = runningSpan.Slice(6);

        for (var i = 0; i < trailingBytes.Length; i++)
        {
            if (i > 0)
            {
                ", ".TryCopyTo(runningSpan);
                charsWritten += 2;
                runningSpan = runningSpan.Slice(2);
            }

            var byteText = $"0x{FormatHexByte(trailingBytes[i])}";
            byteText.AsSpan().TryCopyTo(runningSpan);
            var byteCharsWritten = byteText.Length;
            charsWritten += byteCharsWritten;
            runningSpan = runningSpan.Slice(byteCharsWritten);
        }

#if NETSTANDARD2_0
        writer.WriteLine(textSpan.Slice(0, charsWritten).ToArray());
#else
        writer.WriteLine(textSpan.Slice(0, charsWritten));
#endif
    }

    private void PrintLabel(int offset, Span<char> textSpan, TextWriter writer, bool nextNewLine, bool isFirstLabel, bool isLast)
    {
        if (_internalLabels.TryGetValue(offset, out var labelIndex))
        {
            if (Options.PrintNewLineBeforeLabel && !isFirstLabel)
            {
                writer.WriteLine();
            }
            if (TryFormatLabelExtended(0, false, textSpan, out var charsWritten) && charsWritten + 1 < textSpan.Length)
            {
                textSpan[charsWritten] = ':';
                charsWritten++;
            }
            else
            {
                var result = textSpan.TryWrite($"{FormatLocalLabel(labelIndex)}:", out charsWritten);
                Debug.Assert(result);
            }

#if NETSTANDARD2_0
            writer.WriteLine(textSpan.Slice(0, charsWritten).ToArray());
#else
            writer.WriteLine(textSpan.Slice(0, charsWritten));
#endif
        }
        else
        {
            if (Options.PrintNewLineAfterBranch && nextNewLine && !isLast)
            {
                writer.WriteLine();
            }
        }
    }

    private bool TryFormatLabelExtended(long offset, bool handleInternalLabels, Span<char> textSpan, out int charsWritten)
    {
        var absoluteOffset = _currentOffset + offset;

        var tryFormatLabel = Options.TryFormatLabel;
        if (tryFormatLabel is not null && tryFormatLabel(Options.BaseAddress + absoluteOffset, textSpan, out charsWritten))
        {
            return true;
        }

        if (handleInternalLabels)
        {
            if (_internalLabels.TryGetValue((int)absoluteOffset, out var labelIndex))
            {
                var labelText = FormatLocalLabel(labelIndex);
                charsWritten = labelText.Length;
                return labelText.AsSpan().TryCopyTo(textSpan);
            }

            // If not found, we will provide print absolute address
            var operandAddressPrefix = string.IsNullOrEmpty(Options.AddressPrefix) ? "0x" : Options.AddressPrefix;
            var addressText = $"#{operandAddressPrefix}{(Options.BaseAddress + absoluteOffset).ToString(Options.UseUppercaseHex ? "X16" : "x16", CultureInfo.InvariantCulture)}";
            addressText.AsSpan().TryCopyTo(textSpan);
            charsWritten = addressText.Length;
            return false;
        }

        charsWritten = 0;
        return false;
    }

    private bool TryFormatLabel(long offset, Span<char> textSpan, out int charsWritten) => TryFormatLabelExtended(offset, true, textSpan, out charsWritten);
}
