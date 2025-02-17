// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections;
using System.ComponentModel;

namespace AsmArm64;

/// <summary>
/// Represents a collection of ARM64 operands.
/// </summary>
public readonly unsafe struct Arm64Operands : IEnumerable<Arm64Operand>
{
    private readonly Arm64Instruction _instruction;

    /// <summary>
    /// Initializes a new instance of the <see cref="Arm64Operands"/> struct.
    /// </summary>
    /// <param name="instruction">The instruction.</param>
    public Arm64Operands(Arm64Instruction instruction)
        => _instruction = instruction;

    /// <summary>
    /// Gets the number of operands.
    /// </summary>
    public int Count => _instruction.OperandCount;

    /// <summary>
    /// Gets the operand at the specified index.
    /// </summary>
    /// <param name="index">The index of the operand.</param>
    /// <returns>The operand at the specified index.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
    public Arm64Operand this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)Count);
            return _instruction.IsOperandEncodingSize4Bytes ? new Arm64Operand(*((ulong*)_instruction.OperandsPtr + index), _instruction.RawValue) : new Arm64Operand(*((uint*)_instruction.OperandsPtr + index), _instruction.RawValue);
        }
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>An enumerator for the collection.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Enumerator GetEnumerator() => new(this);

    /// <inheritdoc />
    IEnumerator<Arm64Operand> IEnumerable<Arm64Operand>.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <summary>
    /// Enumerates the elements of an <see cref="Arm64Operands"/> collection.
    /// </summary>
    public struct Enumerator : IEnumerator<Arm64Operand>
    {
        private readonly byte* _operandPtr;
        private readonly bool _isOperandEncodingSize4Bytes;
        private readonly int _count;
        private readonly Arm64RawInstruction _rawValue;
        private int _index;

        /// <summary>
        /// Initializes a new instance of the <see cref="Enumerator"/> struct.
        /// </summary>
        /// <param name="operands">The operands collection.</param>
        public Enumerator(Arm64Operands operands)
        {
            _operandPtr = operands._instruction.OperandsPtr;
            _isOperandEncodingSize4Bytes = operands._instruction.IsOperandEncodingSize4Bytes;
            _count = operands.Count;
            _rawValue = operands._instruction.RawValue;
            _index = -1;
        }

        /// <summary>
        /// Gets the element at the current position of the enumerator.
        /// </summary>
        public Arm64Operand Current => (uint)_index < (uint)_count ?
            _isOperandEncodingSize4Bytes
                ? new Arm64Operand(*((uint*)_operandPtr + _index), _rawValue)
                : new Arm64Operand(*((ulong*)_operandPtr + _index), _rawValue) : throw new InvalidOperationException();

        /// <inheritdoc />
        object IEnumerator.Current => Current;

        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <inheritdoc />
        public bool MoveNext()
        {
            return ++_index < _count;
        }

        /// <inheritdoc />
        public void Reset()
        {
            _index = -1;
        }
    }
}
