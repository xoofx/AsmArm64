// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Represents an assembler finalization failure with structured diagnostics.
/// </summary>
public sealed class Arm64AssemblerException : InvalidOperationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64AssemblerException"/> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    /// <param name="diagnostics">The diagnostics that describe the failure.</param>
    public Arm64AssemblerException(string message, IReadOnlyList<Arm64AssemblerDiagnostic> diagnostics)
        : base(message)
    {
        Diagnostics = diagnostics;
    }

    /// <summary>
    /// Gets the diagnostics that describe the failure.
    /// </summary>
    public IReadOnlyList<Arm64AssemblerDiagnostic> Diagnostics { get; }
}
