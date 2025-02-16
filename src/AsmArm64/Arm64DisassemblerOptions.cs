// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

public class Arm64DisassemblerOptions
{
    private int _formatLineBufferLength;

    public Arm64DisassemblerOptions()
    {
        BaseAddress = 0x1_0000;
        FormatLineBufferLength = 1024;
        IndentSize = 4;
        LocalLabelPrefix = "LL_";
        PrintNewLineBeforeLabel = true;
        PrintNewLineAfterBranch = true;
        PrintLabelBeforeFirstInstruction = true;
    }

    public Arm64TryFormatDelegate? TryFormatLabel { get; set; }

    public Arm64TryFormatDelegate? TryFormatComment { get; set; }

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

    public uint IndentSize { get; set; }

    public bool PrintLabelBeforeFirstInstruction { get; set; }

    public bool PrintNewLineAfterBranch { get; set; }

    public bool PrintNewLineBeforeLabel { get; set; }

    public IFormatProvider? FormatProvider { get; set; }
}