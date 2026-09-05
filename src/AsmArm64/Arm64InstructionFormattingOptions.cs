// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Controls instruction text independently of disassembly listing layout.
/// Defaults preserve the decoded instruction's presentation.
/// </summary>
public sealed class Arm64InstructionFormattingOptions
{
    private Arm64InstructionAliasMode _aliasMode;
    private Arm64NumericFormat _immediateFormat;
    private Arm64NumericFormat _memoryOffsetFormat;
    private Arm64NumericFormat _labelOffsetFormat;

    /// <summary>Gets or sets whether to print the decoded view or its base instruction.</summary>
    /// <exception cref="ArgumentOutOfRangeException">The mode is undefined.</exception>
    public Arm64InstructionAliasMode AliasMode
    {
        get => _aliasMode;
        set
        {
            if (value is not Arm64InstructionAliasMode.Preferred and not Arm64InstructionAliasMode.BaseInstruction)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown alias mode.");
            _aliasMode = value;
        }
    }

    /// <summary>Gets or sets whether mnemonic, register, and keyword text is uppercase. Defaults to false.</summary>
    public bool UseUppercaseText { get; set; }

    /// <summary>Gets or sets whether hexadecimal digits are uppercase. Defaults to false; the prefix remains <c>0x</c>.</summary>
    public bool UseUppercaseHex { get; set; }

    /// <summary>Gets or sets integer immediate formatting. Does not affect floating-point constants, shift operands, or register indices.</summary>
    /// <exception cref="ArgumentOutOfRangeException">The format is undefined.</exception>
    public Arm64NumericFormat ImmediateFormat
    {
        get => _immediateFormat;
        set { ValidateNumericFormat(value); _immediateFormat = value; }
    }

    /// <summary>Gets or sets memory displacement formatting, independently of integer immediates.</summary>
    /// <exception cref="ArgumentOutOfRangeException">The format is undefined.</exception>
    public Arm64NumericFormat MemoryOffsetFormat
    {
        get => _memoryOffsetFormat;
        set { ValidateNumericFormat(value); _memoryOffsetFormat = value; }
    }

    /// <summary>Gets or sets unresolved relative label offset formatting. Symbol names are unaffected.</summary>
    /// <exception cref="ArgumentOutOfRangeException">The format is undefined.</exception>
    public Arm64NumericFormat LabelOffsetFormat
    {
        get => _labelOffsetFormat;
        set { ValidateNumericFormat(value); _labelOffsetFormat = value; }
    }

    /// <summary>Gets or sets whether optional operands with their default values are printed. Defaults to false.</summary>
    public bool PrintDefaultOperands { get; set; }

    /// <summary>Gets or sets the numeric format provider. A null value uses the current culture.</summary>
    public IFormatProvider? FormatProvider { get; set; }

    private static void ValidateNumericFormat(Arm64NumericFormat value)
    {
        if (value is < Arm64NumericFormat.Default or > Arm64NumericFormat.Auto)
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown numeric format.");
    }
}

/// <summary>Specifies which instruction representation to print.</summary>
public enum Arm64InstructionAliasMode
{
    /// <summary>Prints the decoded view, normally Arm's preferred alias. An explicitly obtained base view remains a base view.</summary>
    Preferred,
    /// <summary>Prints the base instruction with its base operands, without architectural aliases.</summary>
    BaseInstruction,
}

/// <summary>Specifies how an integer operand is printed.</summary>
public enum Arm64NumericFormat
{
    /// <summary>Preserves operand-specific defaults, including hexadecimal bit masks and decimal displacements.</summary>
    Default,
    /// <summary>Prints decimal integers.</summary>
    Decimal,
    /// <summary>Prints hexadecimal integers with a <c>0x</c> prefix. Signed displacements use signed magnitude.</summary>
    Hexadecimal,
    /// <summary>Prints magnitudes zero through nine as decimal and larger magnitudes as hexadecimal.</summary>
    Auto,
}
