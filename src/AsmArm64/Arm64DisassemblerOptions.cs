// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Options for configuring the ARM64 disassembler.
/// </summary>
public class Arm64DisassemblerOptions
{
    private int _formatLineBufferLength;
    private int _indentSize;
    private int _instructionTextPaddingLength;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64DisassemblerOptions"/> class.
    /// </summary>
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

    /// <summary>
    /// Gets or sets the delegate to format labels.
    /// </summary>
    public Arm64TryFormatDelegate? TryFormatLabel { get; set; }

    /// <summary>
    /// Gets or sets the delegate to format instruction comments.
    /// </summary>
    public Arm64TryFormatInstructionCommentDelegate? TryFormatComment { get; set; }

    /// <summary>
    /// Gets or sets the length of the instruction text padding.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is negative.</exception>
    public int InstructionTextPaddingLength
    {
        get => _instructionTextPaddingLength;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _instructionTextPaddingLength = value;
        }
    }

    /// <summary>
    /// Gets or sets the delegate to print a text before the instruction being printed.
    /// </summary>
    public Arm64InstructionPrinterDelegate? PreInstructionPrinter { get; set; }

    /// <summary>
    /// Gets or sets the delegate to print a text after the instruction being printed.
    /// </summary>
    public Arm64InstructionPrinterDelegate? PostInstructionPrinter { get; set; }

    /// <summary>
    /// Gets or sets the length of the format line buffer.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is less than 256.</exception>
    public int FormatLineBufferLength
    {
        get => _formatLineBufferLength;
        set
        {
            if (value < 256) throw new ArgumentOutOfRangeException(nameof(value), "The format buffer length must be at least 256");
            _formatLineBufferLength = value;
        }
    }

    /// <summary>
    /// Gets or sets the prefix for local labels.
    /// </summary>
    public string LocalLabelPrefix { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to print the address.
    /// </summary>
    public bool PrintAddress { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to print the assembly bytes.
    /// </summary>
    public bool PrintAssemblyBytes { get; set; }

    /// <summary>
    /// Gets or sets the base address.
    /// </summary>
    public long BaseAddress { get; set; }

    /// <summary>
    /// Gets or sets the size of the indent.
    /// </summary>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is negative.</exception>
    public int IndentSize
    {
        get => _indentSize;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _indentSize = value;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether to print a label before the first instruction.
    /// </summary>
    public bool PrintLabelBeforeFirstInstruction { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to print a new line after a branch.
    /// </summary>
    public bool PrintNewLineAfterBranch { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to print a new line before a label.
    /// </summary>
    public bool PrintNewLineBeforeLabel { get; set; }

    /// <summary>
    /// Gets or sets the format provider.
    /// </summary>
    public IFormatProvider? FormatProvider { get; set; }
}


public delegate void Arm64InstructionPrinterDelegate(long offset, Arm64Instruction instruction, TextWriter writer);

public delegate bool Arm64TryFormatInstructionCommentDelegate(long offset, Arm64Instruction instruction, Span<char> destination, out int charsWritten);