// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

// ReSharper disable InconsistentNaming

using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace AsmArm64;

/// <summary>
/// Represents an ARM64 assembler.
/// </summary>
public partial class Arm64Assembler : IDisposable
{
    private readonly List<Arm64Label> _labels;
    private readonly List<UnboundInstructionLabel> _instructionsWithLabelToPatch;
    private readonly Arm64InstructionBuffer _buffer;
    private readonly Arm64AssemblerBuffer? _ownedBuffer;
    private List<Action>? _resolveEndCallbacks;
    private List<Arm64AssemblerDiagnostic>? _diagnostics;
    private bool _isDisposed;
    private bool _isFinalized;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Assembler"/> class with an owned byte buffer.
    /// </summary>
    /// <param name="baseAddress">The base address of the assembled code.</param>
    public Arm64Assembler(ulong baseAddress = 0x1_0000UL) : this(new Arm64AssemblerBuffer(), ownsBuffer: true)
    {
        BaseAddress = baseAddress;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Assembler"/> class.
    /// </summary>
    /// <param name="buffer">The instruction buffer.</param>
    public Arm64Assembler(Arm64InstructionBuffer buffer)
        : this(buffer, ownsBuffer: false)
    {
    }

    private Arm64Assembler(Arm64InstructionBuffer buffer, bool ownsBuffer)
    {
        ArgumentNullException.ThrowIfNull(buffer);
        _labels = new();
        _instructionsWithLabelToPatch = new();
        BaseAddress = 0x1_0000UL;
        _buffer = buffer;
        _ownedBuffer = ownsBuffer ? (Arm64AssemblerBuffer)buffer : null;
        DebugMap = new Arm64AssemblerDebugMap();
    }

    /// <summary>
    /// Gets the assembled bytes when this assembler owns a byte buffer.
    /// </summary>
    /// <remarks>The returned span is invalidated by subsequent writes, resizes, reset, or disposal.</remarks>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public ReadOnlySpan<byte> Buffer => GetByteBuffer().AsSpan();

    /// <summary>
    /// Gets the underlying instruction buffer.
    /// </summary>
    public Arm64InstructionBuffer InstructionBuffer => _buffer;

    /// <summary>
    /// Gets the number of bytes emitted by this assembler.
    /// </summary>
    public uint SizeInBytes => CurrentOffset;

    /// <summary>
    /// Gets the current offset.
    /// </summary>
    public uint CurrentOffset { get; private protected set; }

    /// <summary>
    /// Gets or sets the base address.
    /// </summary>
    public ulong BaseAddress { get; set; }

    /// <summary>
    /// Gets the current address.
    /// </summary>
    public ulong CurrentAddress => BaseAddress + CurrentOffset;

    /// <summary>
    /// Gets or sets the assembler debug map. Set this property to <c>null</c> to disable debug-map logging.
    /// </summary>
    public IArm64AssemblerDebugMap? DebugMap { get; set; }

    /// <summary>
    /// Resets the assembler state.
    /// </summary>
    public Arm64Assembler Reset()
    {
        ThrowIfDisposed();
        _labels.Clear();
        _instructionsWithLabelToPatch.Clear();
        _resolveEndCallbacks?.Clear();
        _diagnostics?.Clear();
        DebugMap?.Clear();
        _ownedBuffer?.Clear();
        CurrentOffset = 0;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Begins a new assembly session at the specified address.
    /// </summary>
    /// <param name="address">The base address.</param>
    /// <param name="name">An optional name for the new assembly session. Reserved for diagnostics.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler Begin(ulong address = 0x1_0000UL, string? name = null)
    {
        _ = name;
        Reset();
        BaseAddress = address;
        LogDebugInfo(Arm64AssemblerDebugInfoKind.OriginBegin, Arm64InstructionId.Invalid, null, 0, name);
        return this;
    }

    /// <summary>
    /// Marks the beginning of a code section in the debug map.
    /// </summary>
    /// <param name="name">The optional section name.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler BeginCodeSection(string? name = null)
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.CodeSectionBegin, Arm64InstructionId.Invalid, null, 0, name);
        return this;
    }

    /// <summary>
    /// Marks the end of a code section in the debug map.
    /// </summary>
    /// <returns>This assembler.</returns>
    public Arm64Assembler EndCodeSection()
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.CodeSectionEnd, Arm64InstructionId.Invalid, null, 0, null);
        return this;
    }

    /// <summary>
    /// Marks the beginning of a data section in the debug map.
    /// </summary>
    /// <param name="name">The optional section name.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler BeginDataSection(string? name = null)
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.DataSectionBegin, Arm64InstructionId.Invalid, null, 0, name);
        return this;
    }

    /// <summary>
    /// Marks the end of a data section in the debug map.
    /// </summary>
    /// <returns>This assembler.</returns>
    public Arm64Assembler EndDataSection()
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.DataSectionEnd, Arm64InstructionId.Invalid, null, 0, null);
        return this;
    }

    /// <summary>
    /// Marks the beginning of a function in the debug map.
    /// </summary>
    /// <param name="name">The optional function name.</param>
    /// <param name="debugFilePath">The caller source file path.</param>
    /// <param name="debugLineNumber">The caller source line number.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler BeginFunction(string? name = null, [CallerFilePath] string? debugFilePath = null, [CallerLineNumber] int debugLineNumber = 0)
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.FunctionBegin, Arm64InstructionId.Invalid, debugFilePath, debugLineNumber, name);
        return this;
    }

    /// <summary>
    /// Marks the end of a function in the debug map.
    /// </summary>
    /// <param name="name">The optional function name.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler EndFunction(string? name = null)
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.FunctionEnd, Arm64InstructionId.Invalid, null, 0, name);
        return this;
    }

    /// <summary>
    /// Sets the current origin without clearing already emitted bytes.
    /// </summary>
    /// <param name="address">The new current address.</param>
    /// <param name="name">An optional name for the origin. Reserved for diagnostics.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="address"/> is before the current offset.</exception>
    public Arm64Assembler Org(ulong address, string? name = null)
    {
        _ = name;
        ThrowIfDisposed();
        if (address < CurrentOffset)
        {
            throw new ArgumentOutOfRangeException(nameof(address), "The origin address cannot be less than the current offset.");
        }

        BaseAddress = address - CurrentOffset;
        LogDebugInfo(Arm64AssemblerDebugInfoKind.OriginBegin, Arm64InstructionId.Invalid, null, 0, name);
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Assembles the instructions and patches the labels.
    /// </summary>
    public Arm64Assembler Assemble() => End();

    /// <summary>
    /// Ends assembly, patches labels, and invokes resolve-end callbacks.
    /// </summary>
    /// <returns>This assembler.</returns>
    public Arm64Assembler End()
    {
        ThrowIfDisposed();
        _diagnostics?.Clear();
        foreach (var unboundLabel in _instructionsWithLabelToPatch)
        {
            var labelReference = GetFirstUnboundLabel(unboundLabel.Expression);
            if (labelReference is not null)
            {
                var diagnostic = CreateDiagnostic(
                    $"Label '{labelReference}' is not bound for instruction at 0x{BaseAddress + unboundLabel.InstructionOffset:X16}.",
                    unboundLabel);
                AddDiagnostic(diagnostic);
                ThrowAssemblerException(diagnostic.Message);
            }

            int offset;
            try
            {
                offset = EvaluateExpressionOffset(unboundLabel.Expression, BaseAddress + unboundLabel.InstructionOffset, unboundLabel.LabelOperandDescriptor);
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException or InvalidOperationException or OverflowException)
            {
                var diagnostic = CreateDiagnostic(
                    $"Expression '{unboundLabel.Expression}' is out of range for instruction at 0x{BaseAddress + unboundLabel.InstructionOffset:X16}. {ex.Message}",
                    unboundLabel);
                AddDiagnostic(diagnostic);
                ThrowAssemblerException(diagnostic.Message);
                return this;
            }
            var rawInstruction = _buffer.ReadAt(unboundLabel.InstructionOffset);
            try
            {
                rawInstruction |= Arm64LabelOperand.Encode(unboundLabel.LabelOperandDescriptor, offset);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                var diagnostic = CreateDiagnostic(
                    $"Expression '{unboundLabel.Expression}' is out of range for instruction at 0x{BaseAddress + unboundLabel.InstructionOffset:X16}; computed offset is {offset}. {ex.Message}",
                    unboundLabel);
                AddDiagnostic(diagnostic);
                ThrowAssemblerException(diagnostic.Message);
            }
            _buffer.WriteAt(unboundLabel.InstructionOffset, rawInstruction);
        }

        _instructionsWithLabelToPatch.Clear();
        _isFinalized = true;
        LogDebugInfo(Arm64AssemblerDebugInfoKind.End, Arm64InstructionId.Invalid, null, 0, null);

        if (_resolveEndCallbacks is not null)
        {
            foreach (var callback in _resolveEndCallbacks)
            {
                callback();
            }

            _resolveEndCallbacks.Clear();
        }

        return this;
    }

    /// <summary>
    /// Attempts to end assembly, patch labels, and invoke resolve-end callbacks without throwing assembler diagnostics.
    /// </summary>
    /// <param name="diagnostics">The diagnostics produced by finalization.</param>
    /// <returns><c>true</c> when finalization succeeds; otherwise <c>false</c>.</returns>
    public bool TryEnd(out IReadOnlyList<Arm64AssemblerDiagnostic> diagnostics)
    {
        try
        {
            End();
            diagnostics = Array.Empty<Arm64AssemblerDiagnostic>();
            return true;
        }
        catch (Arm64AssemblerException ex)
        {
            diagnostics = ex.Diagnostics;
            return false;
        }
    }

    /// <summary>
    /// Registers a callback invoked after the next successful <see cref="End"/> call.
    /// </summary>
    /// <param name="callback">The callback to invoke.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="callback"/> is <c>null</c>.</exception>
    public Arm64Assembler OnResolveEnd(Action callback)
    {
        ArgumentNullException.ThrowIfNull(callback);
        ThrowIfDisposed();
        (_resolveEndCallbacks ??= new()).Add(callback);
        return this;
    }

    /// <summary>
    /// Gets a value indicating whether <see cref="End"/> completed successfully after the last mutation.
    /// </summary>
    public bool IsFinalized => _isFinalized;

    /// <summary>
    /// Gets a value indicating whether this assembler has pending label patches.
    /// </summary>
    public bool HasPendingPatches => _instructionsWithLabelToPatch.Count != 0;

    /// <summary>
    /// Creates a new label identifier.
    /// </summary>
    /// <param name="name">The name of the label.</param>
    /// <param name="address">The address of the label.</param>
    /// <returns>The created label identifier.</returns>
    public Arm64LabelId CreateLabelId(string? name = null, ulong address = ulong.MaxValue)
    {
        ThrowIfDisposed();
        var index = _labels.Count + 1;
        var label = new Arm64Label(address, name) { Id = new Arm64LabelId(index) };
        _labels.Add(label);
        _isFinalized = false;
        return label.Id;
    }

    /// <summary>
    /// Binds a label to the current address.
    /// </summary>
    /// <param name="labelId">The label identifier.</param>
    public void BindLabel(Arm64LabelId labelId)
    {
        ThrowIfDisposed();
        if (labelId.Index == 0) throw new ArgumentException("Cannot bind the first label", nameof(labelId));

        var index = labelId.Index - 1;
        var labelReference = _labels[index];
        var currentAddress = CurrentAddress;
        if (labelReference.Address == ulong.MaxValue)
        {
            labelReference.Address = currentAddress;
            _isFinalized = false;
        }
        else
        {
            throw new InvalidOperationException($"Label {labelReference.Name} is already bound to address {labelReference.Address}");
        }
    }

    /// <summary>
    /// Gets the label associated with the specified label identifier.
    /// </summary>
    /// <param name="labelId">The label identifier.</param>
    /// <returns>The label.</returns>
    public Arm64Label GetLabel(Arm64LabelId labelId) => labelId.Index == 0 ? Arm64Label.Empty : _labels[labelId.Index - 1];

    /// <summary>
    /// Creates an unbound label.
    /// </summary>
    /// <param name="name">The optional label name.</param>
    /// <returns>The created label.</returns>
    public Arm64Label CreateLabel(string? name = null)
    {
        ThrowIfDisposed();
        _isFinalized = false;
        return new Arm64Label(name);
    }

    /// <summary>
    /// Creates and binds a label at the current address.
    /// </summary>
    /// <param name="label">The created label.</param>
    /// <param name="labelExpression">The source expression used for label-name inference.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler Label(out Arm64Label label, [CallerArgumentExpression(nameof(label))] string? labelExpression = null)
    {
        label = new Arm64Label(Arm64Label.ParseCSharpExpression(labelExpression));
        return Label(label);
    }

    /// <summary>
    /// Creates and binds a named label at the current address.
    /// </summary>
    /// <param name="name">The label name.</param>
    /// <param name="label">The created label.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler Label(string? name, out Arm64Label label)
    {
        label = new Arm64Label(name);
        return Label(label);
    }

    /// <summary>
    /// Creates an unbound forward label.
    /// </summary>
    /// <param name="label">The created forward label.</param>
    /// <param name="labelExpression">The source expression used for label-name inference.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler LabelForward(out Arm64Label label, [CallerArgumentExpression(nameof(label))] string? labelExpression = null)
    {
        ThrowIfDisposed();
        label = new Arm64Label(Arm64Label.ParseCSharpExpression(labelExpression));
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Creates a named unbound forward label.
    /// </summary>
    /// <param name="name">The label name.</param>
    /// <param name="label">The created forward label.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler LabelForward(string? name, out Arm64Label label)
    {
        ThrowIfDisposed();
        label = new Arm64Label(name);
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Binds a label at the current address.
    /// </summary>
    /// <param name="label">The label to bind.</param>
    /// <param name="force">A value indicating whether an already-bound label should be rebound.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="label"/> is <c>null</c>.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="label"/> is empty.</exception>
    /// <exception cref="InvalidOperationException">Thrown when <paramref name="label"/> is already bound and <paramref name="force"/> is <c>false</c>.</exception>
    public Arm64Assembler Label(Arm64Label label, bool force = false)
    {
        ArgumentNullException.ThrowIfNull(label);
        ThrowIfDisposed();
        if (label.IsEmpty) throw new ArgumentException("Label is empty.", nameof(label));
        if (label.IsBound && !force)
        {
            throw new InvalidOperationException($"Label {label} is already bound to address {label.Address}");
        }

        label.Address = CurrentAddress;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Appends bytes to the owned assembler buffer.
    /// </summary>
    /// <param name="input">The bytes to append.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public Arm64Assembler Append(ReadOnlySpan<byte> input)
    {
        ThrowIfDisposed();
        GetByteBuffer().WriteAt(CurrentOffset, input);
        CurrentOffset = checked((uint)(CurrentOffset + input.Length));
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Appends one byte to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendByte(byte value)
    {
        Span<byte> buffer = stackalloc byte[1];
        buffer[0] = value;
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 16-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt16(ushort value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ushort)];
        BinaryPrimitives.WriteUInt16LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 32-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt32(uint value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(uint)];
        BinaryPrimitives.WriteUInt32LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends a little-endian unsigned 64-bit value to the owned assembler buffer.
    /// </summary>
    /// <param name="value">The value to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendUInt64(ulong value)
    {
        Span<byte> buffer = stackalloc byte[sizeof(ulong)];
        BinaryPrimitives.WriteUInt64LittleEndian(buffer, value);
        return Append(buffer);
    }

    /// <summary>
    /// Appends one ARM64 instruction.
    /// </summary>
    /// <param name="instruction">The instruction to append.</param>
    /// <returns>This assembler.</returns>
    public Arm64Assembler AppendInstruction(Arm64RawInstruction instruction)
    {
        AddInstruction(instruction);
        return this;
    }

    /// <summary>
    /// Appends repeated bytes to the owned assembler buffer.
    /// </summary>
    /// <param name="length">The number of bytes to append.</param>
    /// <param name="fill">The fill byte.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="length"/> is negative.</exception>
    public Arm64Assembler AppendBytes(int length, byte fill = 0)
    {
        if (length < 0) throw new ArgumentOutOfRangeException(nameof(length), "Length must be zero or positive.");
        if (length == 0) return this;

        var byteBuffer = GetByteBuffer();
        var data = new byte[length];
        if (fill != 0)
        {
            data.AsSpan().Fill(fill);
        }

        byteBuffer.WriteAt(CurrentOffset, data);
        CurrentOffset = checked((uint)(CurrentOffset + length));
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Aligns the current offset to the specified power-of-two alignment.
    /// </summary>
    /// <param name="alignment">The alignment in bytes. Must be a power of two.</param>
    /// <param name="fill">The fill byte.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="alignment"/> is zero.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="alignment"/> is not a power of two.</exception>
    public Arm64Assembler Align(uint alignment, byte fill = 0)
    {
        if (alignment == 0) throw new ArgumentOutOfRangeException(nameof(alignment), "Alignment must be greater than zero.");
        if ((alignment & (alignment - 1)) != 0) throw new ArgumentException("Alignment must be a power of two.", nameof(alignment));

        var remainder = CurrentOffset & (alignment - 1);
        if (remainder == 0) return this;

        return AppendBytes(checked((int)(alignment - remainder)), fill);
    }

    /// <summary>
    /// Appends one or more NOP instructions.
    /// </summary>
    /// <param name="count">The number of NOP instructions to append.</param>
    /// <returns>This assembler.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="count"/> is negative.</exception>
    public Arm64Assembler Nop(int count = 1)
    {
        if (count < 0) throw new ArgumentOutOfRangeException(nameof(count), "Count must be zero or positive.");

        for (var i = 0; i < count; i++)
        {
            AddInstruction(Arm64InstructionFactory.NOP());
        }

        return this;
    }

    /// <summary>
    /// Copies the assembled bytes to a new array.
    /// </summary>
    /// <returns>A new array containing the assembled bytes.</returns>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    public byte[] ToArray() => GetByteBuffer().ToArray();

    /// <summary>
    /// Disassembles the assembled bytes owned by this assembler.
    /// </summary>
    /// <param name="options">Optional disassembler options. When omitted, the assembler base address is used.</param>
    /// <returns>The disassembled text.</returns>
    /// <exception cref="NotSupportedException">Thrown when this assembler was created with a custom instruction buffer.</exception>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when default options are used and <see cref="BaseAddress"/> cannot be represented as a signed 64-bit value.</exception>
    public string Disassemble(Arm64DisassemblerOptions? options = null)
    {
        if (options is null)
        {
            if (BaseAddress > long.MaxValue) throw new ArgumentOutOfRangeException(nameof(BaseAddress), "The base address must fit in a signed 64-bit value for disassembler options.");
            options = new Arm64DisassemblerOptions { BaseAddress = (long)BaseAddress };
        }

        return new Arm64Disassembler(options).Disassemble(Buffer);
    }

    private int RecordLabelOffset(Arm64AddressExpression expression, nint operandDescriptorEncodingOffset, Arm64InstructionId instructionId = Arm64InstructionId.Invalid, string? debugFilePath = null, int debugLineNumber = 0)
    {
        ThrowIfDisposed();
        ArgumentNullException.ThrowIfNull(expression);
        var descriptor = Arm64Instruction.GetOperandDescriptor(operandDescriptorEncodingOffset);
        if (GetFirstUnboundLabel(expression) is not null)
        {
            _instructionsWithLabelToPatch.Add(new(CurrentOffset, expression, descriptor, instructionId, debugFilePath, debugLineNumber));
            return 0;
        }

        int offset;
        try
        {
            offset = EvaluateExpressionOffset(expression, CurrentAddress, descriptor);
            _ = Arm64LabelOperand.Encode(descriptor, offset);
        }
        catch (Exception ex) when (ex is ArgumentOutOfRangeException or InvalidOperationException or OverflowException)
        {
            _diagnostics?.Clear();
            var diagnostic = new Arm64AssemblerDiagnostic(
                Arm64AssemblerDiagnosticSeverity.Error,
                $"Expression '{expression}' is out of range for instruction at 0x{CurrentAddress:X16}. {ex.Message}",
                CurrentOffset,
                CurrentAddress,
                GetDiagnosticLabelName(expression),
                instructionId,
                debugFilePath,
                debugLineNumber);
            AddDiagnostic(diagnostic);
            ThrowAssemblerException(diagnostic.Message);
            return 0;
        }

        return offset;
    }

    private int RecordLabelOffset(Arm64LabelId labelId, nint operandDescriptorEncodingOffset)
        => RecordLabelOffset(GetLabel(labelId), operandDescriptorEncodingOffset);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private Arm64Assembler AddInstruction(Arm64RawInstruction rawInstruction, Arm64InstructionId instructionId = Arm64InstructionId.Invalid, string? debugFilePath = null, int debugLineNumber = 0)
    {
        ThrowIfDisposed();
        LogDebugInfo(Arm64AssemblerDebugInfoKind.LineInfo, instructionId, debugFilePath, debugLineNumber, null);
        _buffer.WriteAt(CurrentOffset, rawInstruction);
        CurrentOffset += 4;
        _isFinalized = false;
        return this;
    }

    /// <summary>
    /// Releases resources owned by this assembler.
    /// </summary>
    public void Dispose()
    {
        if (_isDisposed) return;

        _ownedBuffer?.Dispose();
        _resolveEndCallbacks?.Clear();
        _isDisposed = true;
    }

    private Arm64AssemblerBuffer GetByteBuffer()
    {
        ThrowIfDisposed();
        if (_buffer is Arm64AssemblerBuffer byteBuffer) return byteBuffer;
        throw new NotSupportedException("Byte-buffer APIs are available only when the assembler owns an Arm64AssemblerBuffer.");
    }

    private void ThrowIfDisposed()
    {
        ObjectDisposedException.ThrowIf(_isDisposed, this);
    }

    private static int ComputeRelativeOffset(ulong targetAddress, ulong sourceAddress)
    {
        if (targetAddress >= sourceAddress)
        {
            var delta = targetAddress - sourceAddress;
            if (delta > int.MaxValue) throw new ArgumentOutOfRangeException(nameof(targetAddress), "The label offset is too large to encode as a 32-bit signed offset.");
            return (int)delta;
        }

        var negativeDelta = sourceAddress - targetAddress;
        if (negativeDelta > (ulong)int.MaxValue + 1) throw new ArgumentOutOfRangeException(nameof(targetAddress), "The label offset is too small to encode as a 32-bit signed offset.");
        return negativeDelta == (ulong)int.MaxValue + 1 ? int.MinValue : -(int)negativeDelta;
    }

    private static int EvaluateExpressionOffset(Arm64Expression expression, ulong sourceAddress, ulong labelOperandDescriptor)
    {
        var targetAddress = expression.Evaluate();
        if (targetAddress < 0) throw new ArgumentOutOfRangeException(nameof(expression), targetAddress, "The expression evaluated to a negative address.");

        var target = (ulong)targetAddress;
        var source = sourceAddress;
        var labelKind = (Arm64LabelEncodingKind)(labelOperandDescriptor >> 8);
        if (labelKind == Arm64LabelEncodingKind.PageOffset)
        {
            target &= ~((ulong)Arm64Address.PageSize - 1);
            source &= ~((ulong)Arm64Address.PageSize - 1);
        }

        return ComputeRelativeOffset(target, source);
    }

    private static Arm64Label? GetFirstUnboundLabel(Arm64Expression expression)
    {
        var labels = new HashSet<Arm64Label>();
        expression.CollectLabels(labels);
        return labels.FirstOrDefault(label => !label.IsBound);
    }

    private static string? GetDiagnosticLabelName(Arm64Expression expression)
    {
        var labels = new HashSet<Arm64Label>();
        expression.CollectLabels(labels);
        return labels.FirstOrDefault(label => label.Name is not null)?.Name;
    }

    private void LogDebugInfo(Arm64AssemblerDebugInfoKind kind, Arm64InstructionId instructionId, string? debugFilePath, int debugLineNumber, string? name)
    {
        DebugMap?.LogDebugInfo(new Arm64AssemblerDebugLineInfo(kind, CurrentOffset, CurrentAddress, debugFilePath, debugLineNumber, name, instructionId));
    }

    private Arm64AssemblerDiagnostic CreateDiagnostic(string message, UnboundInstructionLabel patch)
        => new(
            Arm64AssemblerDiagnosticSeverity.Error,
            message,
            patch.InstructionOffset,
            BaseAddress + patch.InstructionOffset,
            GetDiagnosticLabelName(patch.Expression),
            patch.InstructionId,
            patch.DebugFilePath,
            patch.DebugLineNumber);

    private void AddDiagnostic(Arm64AssemblerDiagnostic diagnostic)
    {
        (_diagnostics ??= new()).Add(diagnostic);
    }

    private void ThrowAssemblerException(string message)
    {
        throw new Arm64AssemblerException(message, _diagnostics?.ToArray() ?? Array.Empty<Arm64AssemblerDiagnostic>());
    }

    private record struct UnboundInstructionLabel(uint InstructionOffset, Arm64AddressExpression Expression, ulong LabelOperandDescriptor, Arm64InstructionId InstructionId, string? DebugFilePath, int DebugLineNumber);
}
