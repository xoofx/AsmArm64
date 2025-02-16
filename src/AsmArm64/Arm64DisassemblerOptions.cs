// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public class Arm64DisassemblerOptions
{
    private int _formatLineBufferLength;
    private int _indentSize;
    private int _instructionTextPaddingLength;

    public Arm64DisassemblerOptions()
    {
        BaseAddress = 0x1_0000;
        FormatLineBufferLength = 4096;
        IndentSize = 4;
        LocalLabelPrefix = "LL_";
        PrintNewLineBeforeLabel = true;
        PrintNewLineAfterBranch = true;
        PrintLabelBeforeFirstInstruction = true;
        InstructionTextPaddingLength = 16;
    }

    public Arm64TryFormatDelegate? TryFormatLabel { get; set; }

    public Arm64TryFormatInstructionCommentDelegate? TryFormatComment { get; set; }

    public int InstructionTextPaddingLength
    {
        get => _instructionTextPaddingLength;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _instructionTextPaddingLength = value;
        }
    }

    public Arm64InstructionPrinterDelegate? PreInstructionPrinter { get; set; }

    public Arm64InstructionPrinterDelegate? PostInstructionPrinter { get; set; }

    public int FormatLineBufferLength
    {
        get => _formatLineBufferLength;
        set
        {
            if (value < 256) throw new ArgumentOutOfRangeException(nameof(value), "The format buffer length must be at least 256");
            _formatLineBufferLength = value;
        }
    }

    public string LocalLabelPrefix { get; set; }

    public bool PrintAddress { get; set; }

    public bool PrintAssemblyBytes { get; set; }

    public long BaseAddress { get; set; }

    public int IndentSize
    {
        get => _indentSize;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _indentSize = value;
        }
    }

    public bool PrintLabelBeforeFirstInstruction { get; set; }

    public bool PrintNewLineAfterBranch { get; set; }

    public bool PrintNewLineBeforeLabel { get; set; }

    public IFormatProvider? FormatProvider { get; set; }
}


public delegate void Arm64InstructionPrinterDelegate(long offset, Arm64Instruction instruction, TextWriter writer);

public delegate bool Arm64TryFormatInstructionCommentDelegate(long offset, Arm64Instruction instruction, Span<char> destination, out int charsWritten);