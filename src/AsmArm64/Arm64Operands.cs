// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Collections;
using System.ComponentModel;

namespace AsmArm64;

public readonly unsafe struct Arm64Operands : IEnumerable<Arm64Operand>
{
    private readonly Arm64Instruction _instruction;
    
    public int Count => _instruction.OperandCount;
    
    public Arm64Operand this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual((uint)index, (uint)Count);
            return _instruction.IsOperandEncodingSize4Bytes ? new Arm64Operand(*((ulong*)_instruction.OperandsPtr + index), _instruction.RawValue) : new Arm64Operand(*((uint*)_instruction.OperandsPtr + index), _instruction.RawValue);
        }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Enumerator GetEnumerator() => new(this);
    
    IEnumerator<Arm64Operand> IEnumerable<Arm64Operand>.GetEnumerator() => GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    
    public struct Enumerator : IEnumerator<Arm64Operand>
    {
        private readonly byte* _operandPtr;
        private readonly bool _isOperandEncodingSize4Bytes;
        private readonly int _count;
        private readonly Arm64RawInstruction _rawValue;
        private int _index;
        public Enumerator(Arm64Operands operands)
        {
            _operandPtr = operands._instruction.OperandsPtr;
            _isOperandEncodingSize4Bytes = operands._instruction.IsOperandEncodingSize4Bytes;
            _count = operands.Count;
            _rawValue = operands._instruction.RawValue;
            _index = -1;
        }
        public Arm64Operand Current => (uint)_index < (uint)_count ?
            _isOperandEncodingSize4Bytes
                ? new Arm64Operand(*((uint*)_operandPtr + _index), _rawValue)
                : new Arm64Operand(*((ulong*)_operandPtr + _index), _rawValue) : throw new InvalidOperationException();

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return ++_index < _count;
        }
        public void Reset()
        {
            _index = -1;
        }
    }
}