// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents a diagnostic produced while finalizing assembler output.
/// </summary>
/// <param name="Severity">The diagnostic severity.</param>
/// <param name="Message">The diagnostic message.</param>
/// <param name="Offset">The byte offset associated with the diagnostic, if known.</param>
/// <param name="Address">The address associated with the diagnostic, if known.</param>
/// <param name="LabelName">The label name associated with the diagnostic, if known.</param>
/// <param name="InstructionId">The instruction id associated with the diagnostic, if known.</param>
/// <param name="FilePath">The source file path associated with the diagnostic, if known.</param>
/// <param name="LineNumber">The source line number associated with the diagnostic, if known.</param>
public readonly record struct Arm64AssemblerDiagnostic(
    Arm64AssemblerDiagnosticSeverity Severity,
    string Message,
    uint? Offset = null,
    ulong? Address = null,
    string? LabelName = null,
    Arm64InstructionId InstructionId = Arm64InstructionId.Invalid,
    string? FilePath = null,
    int LineNumber = 0)
{
    /// <inheritdoc />
    public override string ToString()
    {
        var location = FilePath is not null && LineNumber > 0 ? $" {FilePath}:{LineNumber}" : string.Empty;
        var address = Address is not null ? $" address=0x{Address:X}" : string.Empty;
        var offset = Offset is not null ? $" offset=0x{Offset:X}" : string.Empty;
        var label = LabelName is not null ? $" label={LabelName}" : string.Empty;
        var instruction = InstructionId != Arm64InstructionId.Invalid ? $" instruction={InstructionId}" : string.Empty;
        return $"{Severity}: {Message}{location}{address}{offset}{label}{instruction}";
    }
}
