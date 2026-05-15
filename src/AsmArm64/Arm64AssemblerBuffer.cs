// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Buffers;
using System.Buffers.Binary;

namespace AsmArm64;

/// <summary>
/// Represents an owned byte buffer used by <see cref="Arm64Assembler"/>.
/// </summary>
public sealed class Arm64AssemblerBuffer : Arm64InstructionBuffer, IDisposable
{
    private const int DefaultCapacity = 256;

    private byte[] _buffer;
    private int _length;
    private bool _disposed;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64AssemblerBuffer"/> class.
    /// </summary>
    /// <param name="capacity">The initial capacity, in bytes.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="capacity"/> is negative.</exception>
    public Arm64AssemblerBuffer(int capacity = DefaultCapacity)
    {
        if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be zero or positive.");

        _buffer = ArrayPool<byte>.Shared.Rent(Math.Max(capacity, 1));
    }

    /// <summary>
    /// Gets the length of this buffer in bytes.
    /// </summary>
    public override int Length => _length;

    /// <summary>
    /// Gets the current capacity, in bytes.
    /// </summary>
    public int Capacity => _buffer.Length;

    /// <summary>
    /// Gets the written bytes.
    /// </summary>
    /// <returns>A read-only span over the written bytes. The span is invalidated by subsequent writes, resizes, or disposal.</returns>
    /// <exception cref="ObjectDisposedException">Thrown when this buffer has been disposed.</exception>
    public ReadOnlySpan<byte> AsSpan()
    {
        ThrowIfDisposed();
        return _buffer.AsSpan(0, _length);
    }

    /// <summary>
    /// Copies the written bytes to a new array.
    /// </summary>
    /// <returns>A new array containing the written bytes.</returns>
    /// <exception cref="ObjectDisposedException">Thrown when this buffer has been disposed.</exception>
    public byte[] ToArray()
    {
        ThrowIfDisposed();
        return AsSpan().ToArray();
    }

    /// <summary>
    /// Clears the logical contents of this buffer.
    /// </summary>
    /// <exception cref="ObjectDisposedException">Thrown when this buffer has been disposed.</exception>
    public void Clear()
    {
        ThrowIfDisposed();
        _length = 0;
    }

    /// <inheritdoc />
    public override Arm64RawInstruction ReadAt(uint offset)
    {
        ThrowIfDisposed();
        var index = checked((int)offset);
        if (index < 0 || index + sizeof(uint) > _length)
        {
            throw new ArgumentOutOfRangeException(nameof(offset), "The offset must reference a complete written instruction.");
        }

        return BinaryPrimitives.ReadUInt32LittleEndian(_buffer.AsSpan(index, sizeof(uint)));
    }

    /// <inheritdoc />
    public override void WriteAt(uint offset, Arm64RawInstruction rawInstruction)
    {
        ThrowIfDisposed();
        var index = checked((int)offset);
        EnsureLength(index + sizeof(uint));
        BinaryPrimitives.WriteUInt32LittleEndian(_buffer.AsSpan(index, sizeof(uint)), rawInstruction);
    }

    /// <summary>
    /// Writes bytes at the specified offset.
    /// </summary>
    /// <param name="offset">The byte offset to write to.</param>
    /// <param name="input">The bytes to write.</param>
    /// <exception cref="ObjectDisposedException">Thrown when this buffer has been disposed.</exception>
    public void WriteAt(uint offset, ReadOnlySpan<byte> input)
    {
        ThrowIfDisposed();
        var index = checked((int)offset);
        EnsureLength(index + input.Length);
        input.CopyTo(_buffer.AsSpan(index, input.Length));
    }

    /// <summary>
    /// Releases the pooled buffer used by this instance.
    /// </summary>
    public void Dispose()
    {
        if (_disposed) return;

        ArrayPool<byte>.Shared.Return(_buffer);
        _buffer = Array.Empty<byte>();
        _length = 0;
        _disposed = true;
    }

    private void EnsureLength(int length)
    {
        if (length < 0) throw new ArgumentOutOfRangeException(nameof(length));
        EnsureCapacity(length);
        if (length > _length)
        {
            _buffer.AsSpan(_length, length - _length).Clear();
        }

        _length = Math.Max(_length, length);
    }

    private void EnsureCapacity(int capacity)
    {
        if (capacity <= _buffer.Length) return;

        var newCapacity = _buffer.Length;
        do
        {
            newCapacity *= 2;
        }
        while (newCapacity < capacity);

        var newBuffer = ArrayPool<byte>.Shared.Rent(newCapacity);
        _buffer.AsSpan(0, _length).CopyTo(newBuffer);
        ArrayPool<byte>.Shared.Return(_buffer);
        _buffer = newBuffer;
    }

    private void ThrowIfDisposed()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
    }
}
