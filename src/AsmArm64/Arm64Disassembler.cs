// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Buffers;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AsmArm64;

public class Arm64Disassembler
{
    private readonly Dictionary<int, int> _internalLabels;
    private int _currentOffset;
    private readonly Arm64TryFormatDelegate _tryFormatLabelDelegate;

    public Arm64Disassembler() : this(new Arm64DisassemblerOptions())
    {
    }
    
    public Arm64Disassembler(Arm64DisassemblerOptions options)
    {
        _internalLabels = new();
        Options = options;
        _tryFormatLabelDelegate = TryFormatLabel;
    }

    public Arm64DisassemblerOptions Options { get; }
    
    public string Disassemble(Span<byte> buffer)
    {
        var writer = new StringWriter();
        Disassemble(buffer, writer);
        return writer.ToString();
    }

    public void Disassemble(Span<byte> buffer, TextWriter writer)
    {
        var rawInstructions = MemoryMarshal.Cast<byte, uint>(buffer);

        // Clear the internal pending labels
        // And collect any new internal labels from the buffer
        // So that we can create labels for the disassembled instructions
        _internalLabels.Clear();

        // Create a label for the first instruction if requested
        if (Options.PrintLabelBeforeFirstInstruction)
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
                if (operand.Kind == Arm64OperandKind.Label)
                {
                    var labelOperand = (Arm64LabelOperand)operand;
                    var absoluteOffset = i * 4 + labelOperand.Offset;
                    if (absoluteOffset >= 0 && absoluteOffset <= buffer.Length)
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
                _currentOffset = i * 4;
                PrintLabel(_currentOffset, textSpan, writer, nextNewLine, i == 0);
                nextNewLine = false;

                // Write the indent
                if (Options.PrintAddress || Options.PrintAssemblyBytes)
                {
                    if (Options.PrintAddress)
                    {
                        writer.Write($"{Options.BaseAddress + _currentOffset:X16}");
                        WriteIndentSize(textSpan, writer);
                    }

                    if (Options.PrintAssemblyBytes)
                    {
                        var bytes = MemoryMarshal.AsBytes(new Span<uint>(ref rawInstruction));
                        for (int bi = 0; bi < bytes.Length; bi++)
                        {
                            if (bi > 0) writer.Write(' ');
                            writer.Write($"{bytes[bi]:X2}");
                        }

                        WriteIndentSize(textSpan, writer);
                    }
                }
                else
                {
                    WriteIndentSize(textSpan, writer);
                }

                // Write the instruction
                {
                    var instruction = Arm64Instruction.Decode(rawInstruction);
                    var result = instruction.TryFormat(textSpan, out var charsWritten, null, Options.FormatProvider, _tryFormatLabelDelegate);
                    Debug.Assert(result);
                    writer.Write(textSpan.Slice(0, charsWritten));

                    if (Options.TryFormatComment is not null)
                    {
                        var indentSpan = GetIndentSpan(textSpan);
                        var localTextSpan = textSpan.Slice(indentSpan.Length);
                        if (Options.TryFormatComment(_currentOffset, localTextSpan, out charsWritten))
                        {
                            writer.Write(indentSpan);
                            writer.Write("// ");
                            writer.Write(localTextSpan.Slice(0, charsWritten));
                        }
                    }
                    writer.WriteLine();

                    if (instruction.Id.IsBranch())
                    {
                        nextNewLine = true;
                    }
                }
            }

            _currentOffset = rawInstructions.Length * 4;
            // Print any pending labels
            PrintLabel(_currentOffset, textSpan, writer, false, false);
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

    private void WriteIndentSize(Span<char> textSpan, TextWriter writer)
        => writer.Write(GetIndentSpan(textSpan));

    private void PrintLabel(int offset, Span<char> textSpan, TextWriter writer, bool nextNewLine, bool isFirstLabel)
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
                var result = textSpan.TryWrite($"{Options.LocalLabelPrefix}{labelIndex:00}:", out charsWritten);
                Debug.Assert(result);
            }
            writer.WriteLine(textSpan.Slice(0, charsWritten));
        }
        else
        {
            if (Options.PrintNewLineAfterBranch && nextNewLine)
            {
                writer.WriteLine();
            }
        }
    }
    
    private bool TryFormatLabelExtended(long offset, bool handleInternalLabels, Span<char> textSpan, out int charsWritten)
    {
        var absoluteOffset = _currentOffset + offset;

        var tryFormatLabel = Options.TryFormatLabel;
        if (tryFormatLabel is not null && tryFormatLabel(absoluteOffset, textSpan, out charsWritten))
        {
            return true;
        }

        if (handleInternalLabels)
        {
            if (_internalLabels.TryGetValue((int)absoluteOffset, out var labelIndex))
            {
                return textSpan.TryWrite($"{Options.LocalLabelPrefix}{labelIndex:00}", out charsWritten);
            }

            // If not found, we will provide print absolute address
            textSpan.TryWrite($"#0x{Options.BaseAddress + absoluteOffset:X16}", out charsWritten);
            return false;
        }

        charsWritten = 0;
        return false;
    }

    private bool TryFormatLabel(long offset, Span<char> textSpan, out int charsWritten) => TryFormatLabelExtended(offset, true, textSpan, out charsWritten);
}
