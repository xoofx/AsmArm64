// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace AsmArm64.CodeGen.Model;

// Check https://github.com/CensoredUsername/dynasm-rs/blob/master/tools/aarch64_gen_opmap.py for ideas
// https://github.com/wdamron/arm/blob/main/INSTRUCTIONS.md
// https://github.com/wdamron/arm/blob/main/encoding.go

sealed class Operand
{
    public required OperandKind Kind { get; init; }

    public OperandDescriptor? Descriptor { get; set; }
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    /// <summary>
    /// If this parameter has a bang `!` at the end.
    /// </summary>
    public bool HasBang { get; set; }

    public override string ToString()
    {
        var builder = new StringBuilder();

        if (Kind == OperandKind.Memory)
        {
            builder.Append('[');
        }

        for (int i = 0; i < Items.Count; i++)
        {
            var parameter = Items[i];
            var isOptional = parameter is GroupOperandItem { IsOptional: true };
            if (isOptional)
            {
                builder.Append('{');
            }
            if (i > 0)
            {
                builder.Append(", ");
            }

            var parameterToStr = parameter.ToString();
            if (isOptional)
            {
                // For an optional, we handle it here by placing the { before the comma
                builder.Append(parameterToStr.Substring(1));
            }
            else
            {
                builder.Append(parameterToStr);
            }
        }

        if (Kind == OperandKind.Memory)
        {
            builder.Append(']');
        }

        if (HasBang)
        {
            builder.Append('!');
        }

        return builder.ToString();
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
enum OperandKind
{
    Undefined,
    Register,
    Immediate,
    Value,
    Enum,
    Memory,
    Group,
    RegisterGroup,
    Select,
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "kind")]
[JsonDerivedType(typeof(EnumOperandItem), typeDiscriminator: "enum")]
[JsonDerivedType(typeof(ValueOperandItem), typeDiscriminator: "value")]
[JsonDerivedType(typeof(ImmediateOperandItem), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(GroupOperandItem), typeDiscriminator: "group")]
[JsonDerivedType(typeof(RegisterGroupOperandItem), typeDiscriminator: "reg-group")]
[JsonDerivedType(typeof(RegisterOperandItem), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(SelectOperandItem), typeDiscriminator: "select")]
abstract class OperandItem(OperandItemKind kind)
{
    [JsonIgnore]
    public OperandItemKind Kind { get; } = kind;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandText> TextElements { get; } = new();

    public OperandItem? Indexer { get; set; }

    public string GetName() => string.Concat(TextElements.Select(x => x.Text));

    public sealed override string ToString()
    {
        var builder = new StringBuilder();
        ToStringPrefix(builder);
        ToStringTextElements(builder);
        ToStringParameters(builder);
        if (Indexer is not null)
        {
            builder.Append('[');
            builder.Append(Indexer);
            builder.Append(']');
        }

        return builder.ToString();
    }

    protected virtual void ToStringPrefix(StringBuilder builder)
    {
    }

    protected virtual void ToStringParameters(StringBuilder builder)
    {
    }

    protected void ToStringTextElements(StringBuilder builder)
    {
        foreach (var textElement in TextElements)
        {
            builder.Append(textElement.Text);
        }
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
enum OperandItemKind
{
    Register,
    Immediate,
    Value,
    Enum,
    Group,
    RegisterGroup,
    Select,
}

sealed class EnumOperandItem() : OperandItem(OperandItemKind.Enum);

sealed class ValueOperandItem() : OperandItem(OperandItemKind.Value);

sealed class ImmediateOperandItem() : OperandItem(OperandItemKind.Immediate)
{
    protected override void ToStringPrefix(StringBuilder builder) => builder.Append('#');
}

abstract class GroupOperandItemBase(OperandItemKind kind) : OperandItem(kind)
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    /// <summary>
    /// Is this object optional.
    /// </summary>
    public bool IsOptional { get; set; }

    protected override void ToStringParameters(StringBuilder builder)
    {
        builder.Append('{');
        builder.Append(string.Join(", ", Items));
        builder.Append('}');
    }
}


sealed class GroupOperandItem() : GroupOperandItemBase(OperandItemKind.Group);

sealed class RegisterGroupOperandItem() : GroupOperandItemBase(OperandItemKind.RegisterGroup);


[method: JsonConstructor]
sealed class OperandText(string text, EncodingSymbol? symbol)
{
    public string Text { get; } = text;

    public EncodingSymbol? Symbol { get; } = symbol;

    public override string ToString() => Symbol is not null ? $"{Text} ({Symbol})" : Text;
}

sealed class RegisterOperandItem() : OperandItem(OperandItemKind.Register);

/// <summary>
/// Arguments Starting with ( and with | and ) are grouped arguments.
/// </summary>
sealed class SelectOperandItem() : OperandItem(OperandItemKind.Select)
{
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<OperandItem> Items { get; } = new();

    protected override void ToStringParameters(StringBuilder builder)
    {
        builder.Append('(');
        builder.Append(string.Join("|", Items));
        builder.Append(')');
    }
}

[DebuggerDisplay("Name = {Name}, Symbols = {Symbols.Count}")]
class EncodingSymbolsInfo
{
    public required string Name { get; init; } = string.Empty;

    public Dictionary<string, EncodingSymbol> Symbols { get; } = new();
}

[DebuggerDisplay("Link = {Link}, BitInfos = {BitInfosDebuggerDisplay}, BitValues = {BitValues.Count}")]
class EncodingSymbol
{
    public required string Link { get; init; } = string.Empty;

    public required string Name { get; init; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingBitInfo> BitInfos { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitValueNames { get; } = new();

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<EncodingBitValue> BitValues { get; } = new();

    private string BitInfosDebuggerDisplay => string.Join(":", BitInfos);

    public override string ToString()
    {
        return BitValues.Count > 0 ? $"{BitInfosDebuggerDisplay} Match: ({string.Join(":", BitValueNames)} -> ([{string.Join("], [", BitValues)}])" : BitInfosDebuggerDisplay;
    }
}

record EncodingBitInfo
{
    public required string Name { get; init; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<int> BitIndices { get; } = new();

    public override string ToString()
    {
        if (BitIndices.Count == 0)
        {
            return Name;
        }

        var builder = new StringBuilder();
        builder.Append(Name);
        builder.Append('<');
        for (int i = 0; i < BitIndices.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(',');
            }
            builder.Append(BitIndices[i]);
        }
        builder.Append('>');
        return builder.ToString();
    }
}

record EncodingBitValue
{
    public string Value { get; set; } = string.Empty;

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<string> BitFields { get; } = new();

    public int GetBitFieldsAsInt()
    {
        var value = 0;
        foreach (var x in BitFields)
        {
            foreach(var bitField in x)
            {
                if (bitField == 'x') throw new InvalidOperationException("Cannot convert to int with x");
                Debug.Assert(bitField == '1' || bitField == '0');
                value <<= 1;
                value |= bitField == '1' ? 1 : 0;
            }
        }
        return value;
    }

    public override string ToString() => $"BitFields = {string.Join(":", BitFields)}, Value = {Value}";
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$kind")]
[JsonDerivedType(typeof(RegisterOperandDescriptor), typeDiscriminator: "reg")]
[JsonDerivedType(typeof(GroupRegisterOperandDescriptor), typeDiscriminator: "greg")]
[JsonDerivedType(typeof(ImmediateOperandDescriptor), typeDiscriminator: "imm")]
[JsonDerivedType(typeof(MemoryOperandDescriptor), typeDiscriminator: "mem")]
abstract class OperandDescriptor
{
    public required OperandDescriptorKind Kind { get; init; }

    public string Name { get; set; } = string.Empty;
}

sealed class GroupRegisterOperandDescriptor : OperandDescriptor
{
    public required int Size { get; set; }

    public required RegisterOperandDescriptor Register { get; init; }

    public override string ToString() => $"Group{Size}({Register})";
}

sealed class ImmediateOperandDescriptor : OperandDescriptor
{
    public ImmediateKind ImmediateKind { get; set; }

    public int Size { get; set; }

    public bool IsSigned { get; set; }

    public sbyte FixedValue { get; set; }
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();
    
    public override string ToString()
    {
        var builder = new StringBuilder();
        if (Size == 0 && Encoding.Count == 0)
        {
            builder.Append($"Imm {Name}, Signed: {IsSigned}, Size {Size}, Value: {FixedValue}");
        }
        else
        {
            builder.Append($"Imm {Name}, Signed: {IsSigned}, Size {Size}, Encoding: {string.Join(", ", Encoding)}");
        }

        return builder.ToString();
    }
}

sealed class MemoryOperandDescriptor : OperandDescriptor
{
    public MemoryOperandKind MemoryOperandKind { get; set; }

    public BitRange BaseRegister;

    public MemoryOperandExtendKind ExtendKind { get; set; }

    public sbyte FixedValue { get; set; }

    public bool IsPreIncrement { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexRegisterOrImmediate { get; } = new();
}


enum MemoryOperandKind
{
    None,
    // 1 [Xd]!
    // 1 [Xs]!
    BaseRegisterXn,
    // 1 [Xn|SP]
    BaseRegister,
    // 2 [Xn|SP,#-16]!
    // 2 [Xn|SP,#-4]!
    // 2 [Xn|SP,#-8]!
    BaseRegisterAndFixedImmediate,
    // 2 [Xn|SP,#imm]!
    // 2 [Xn|SP,#simm]!
    BaseRegisterXnOrSPAndImmediate,
    // 2 [Xn|SP{,#imm}]
    // 2 [Xn|SP{,#pimm}]
    // 2 [Xn|SP{,#simm}]
    // 2 [Xn|SP{,#simm}]!
    BaseRegisterAndImmediateOptional,
    // 3 [Xn|SP,(Wm|Xm){,extend,{amount}}]
    BaseRegisterAndIndexWmOrXmAndExtendAndAmountOptional,
    // 3 [Xn|SP,Xm{,LSLamount}]
    BaseRegisterAndIndexXmAndLslAmount,
    // 4 [Xn|SP,(Wm|Xm),extend,{amount}]
    BaseRegisterAndIndexWmOrXmAndExtendAndAmount,
}

enum MemoryOperandExtendKind : byte
{
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 0 (bit 0, bit 1 is not possible)
    /// </summary>
    NoLsl = 0,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 1 (when bit set)
    /// </summary>
    Shift1 = 1,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 2 (when bit set)
    /// </summary>
    Shift2 = 2,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 3 (when bit set)
    /// </summary>
    Shift3 = 3,
    /// <summary>
    /// Option:
    /// 010 = UXTW
    /// 011 = UXTX
    /// 110 = SXTW
    /// 111 = SXTX
    /// Amount: 4 (when bit set)
    /// </summary>
    Shift4 = 4,
}



sealed class DynamicRegisterSelector
{
    public int SelectorSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> SelectorEncoding { get; } = new();
    
    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitValueToRegister> MapBitValueToRegister { get; } = new();

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append($"DynamicXorW[{SelectorSize}](");
        builder.Append(string.Join(", ", SelectorEncoding));
        builder.Append(") -> {");
        for (int i = 0; i < MapBitValueToRegister.Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }
            builder.Append(MapBitValueToRegister[i]);
        }
        builder.Append("}");
        return builder.ToString();
    }
}

sealed class RegisterOperandDescriptor : OperandDescriptor
{
    public RegisterIndexEncodingKind RegisterIndexEncodingKind { get; set; }

    /// <summary>
    /// If the operand kind is <see cref="OperandDescriptorKind.DynamicRegXOrW"/>, then the kind of register is selected dynamically
    /// </summary>
    public DynamicRegisterSelector? DynamicRegisterXOrWSelector { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> IndexEncoding { get; } = new();

    public VectorArrangement? VectorArrangement { get; set; }
    
    //[JsonIgnore]
    //public bool HasFixedVectorArrangements
    //{
    //    get
    //    {
    //        return RegisterVectorArrangements.Count == 1 && !RegisterVectorArrangements[0].HasEncoding;
    //    }
    //}

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(Kind);

        builder.Append('/');
        builder.Append(RegisterIndexEncodingKind);

        if (DynamicRegisterXOrWSelector is not null)
        {
            builder.Append($" {DynamicRegisterXOrWSelector}");
        }

        if (Kind == OperandDescriptorKind.RegV && VectorArrangement != null)
        {
            builder.Append($".{VectorArrangement}");
        }

        if (IndexEncoding.Count > 0)
        {
            builder.Append('[');
            for (int i = 0; i < IndexEncoding.Count; i++)
            {
                if (i > 0)
                {
                    builder.Append(',');
                }
                builder.Append(IndexEncoding[i]);
            }
            builder.Append(']');
        }
        
        return builder.ToString();
    }
}




readonly record struct BitRange(int HiBit, int Width)
{
    public override string ToString() => $"({HiBit}:{Width})";
}

readonly record struct BitValueToRegister(string BitValues, OperandDescriptorKind RegisterKind)
{
    public override string ToString() => $"{BitValues} -> {RegisterKind}";
}

readonly record struct VectorArrangementValue(RegisterVArrangementKind Kind, string BitValues)
{
    public override string ToString() => $"{Kind} = {BitValues}";
}

record VectorArrangement
{
    private int _vectorArrangementValuesIndex;
    public RegisterVArrangementKind ArrangementKind { get; set; }

    public int EncodingSize { get; set; }

    [JsonObjectCreationHandling(JsonObjectCreationHandling.Populate)]
    public List<BitRange> Encoding { get; } = new();

    [JsonPropertyName("vaidx")]
    public int VectorArrangementValuesIndex
    {
        get => Values?.Index ?? _vectorArrangementValuesIndex;
        set => _vectorArrangementValuesIndex = value;
    }

    [JsonIgnore]
    public VectorArrangementValues? Values { get; set; }
    
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(ArrangementKind);
        hash.Add(EncodingSize);
        foreach (var bitRange in Encoding)
        {
            hash.Add(bitRange);
        }

        if (Values is not null)
        {
            foreach (var item in Values)
            {
                hash.Add(item);
            }
        }
        return hash.ToHashCode();
    }
    
    public virtual bool Equals(VectorArrangement? other)
    {
        if (other == null)
        {
            return false;
        }
        if (ArrangementKind != other.ArrangementKind)
        {
            return false;
        }
        if (EncodingSize != other.EncodingSize)
        {
            return false;
        }
        if (Encoding.Count != other.Encoding.Count)
        {
            return false;
        }

        for (int i = 0; i < Encoding.Count; i++)
        {
            if (Encoding[i] != other.Encoding[i])
            {
                return false;
            }
        }

        if (Values is null && other.Values is null)
        {
            return true;
        }

        if (Values is null || other.Values is null)
        {
            return false;
        }

        if (Values.Count != other.Values.Count)
        {
            return false;
        }
        
        for (int i = 0; i < Values.Count; i++)
        {
            if (Values[i] != other.Values[i])
            {
                return false;
            }
        }
        return true;
    }

    [JsonIgnore]
    public string Id => this.ToString();

    public override string ToString()
    {
        if (Encoding.Count == 0 && Values is null)
        {
            return ArrangementKind.ToString();
        }
        var builder = new StringBuilder();
        builder.Append(ArrangementKind);

        builder.Append($"(Size: {EncodingSize}, Encoding: ");

        builder.Append("[");
        for (var i = 0; i < Encoding.Count; i++)
        {
            var bitRange = Encoding[i];
            if (i > 0) builder.Append(",");
            builder.Append(bitRange);
        }
        builder.Append("], Values: ");

        builder.Append("{");
        for (var i = 0; i < Values!.Count; i++)
        {
            var item = Values[i];
            if (i > 0) builder.Append(",");
            builder.Append(item);
        }
        builder.Append("}");
        
        return builder.ToString();
    }
}

sealed class VectorArrangementValues : List<VectorArrangementValue>
{
    [JsonIgnore]
    public string Id => ToString();

    [JsonIgnore]
    public int Index { get; set; }

    public override int GetHashCode()
    {
        var hash = new HashCode();
        foreach (var item in this)
        {
            hash.Add(item);
        }
        return hash.ToHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not VectorArrangementValues other)
        {
            return false;
        }
        if (Count != other.Count)
        {
            return false;
        }
        for (int i = 0; i < Count; i++)
        {
            if (this[i] != other[i])
            {
                return false;
            }
        }
        return true;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("{");
        for (int i = 0; i < Count; i++)
        {
            if (i > 0)
            {
                builder.Append(", ");
            }
            builder.Append(this[i]);
        }
        builder.Append("}");
        return builder.ToString();
    }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum OperandDescriptorKind
{
    None,
    /// <summary>
    /// 64-bit register
    /// </summary>
    RegX,
    /// <summary>
    /// 64-bit register or SP (stack pointer)
    /// </summary>
    RegXOrSP,
    /// <summary>
    /// 32-bit register
    /// </summary>
    RegW,
    /// <summary>
    /// 32-bit register or WSP (stack pointer)
    /// </summary>
    RegWOrWSP,
    /// <summary>
    /// Either X or W depending on some encoding
    /// </summary>
    DynamicRegXOrW,
    /// <summary>
    /// Either B, H, S depending on some encoding
    /// </summary>
    DynamicRegVScalar,
    /// <summary>
    /// 8-bit register from vector registers
    /// </summary>
    RegB,
    /// <summary>
    /// 16-bit floating point register from vector registers
    /// </summary>
    RegH,
    /// <summary>
    /// 32-bit floating point register from vector registers
    /// </summary>
    RegS,
    /// <summary>
    /// 64-bit floating point register from vector registers
    /// </summary>
    RegD,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    RegV,
    /// <summary>
    /// Vector register (128-bit)
    /// </summary>
    RegQ,
    /// <summary>
    /// SVE register
    /// </summary>
    RegZ,
    MultiReg1,
    MultiReg2,
    MultiReg3,
    MultiReg4,
    /// <summary>
    /// An immediate
    /// </summary>
    Immediate,
    /// <summary>
    /// A memory operand
    /// </summary>
    Memory,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RegisterIndexEncodingKind : byte
{
    /// <summary>
    /// No encoding. The register is fixed.
    /// </summary>
    None,
    /// <summary>
    /// 5 bit
    /// </summary>
    Regular5,
    /// <summary>
    /// 4 bit
    /// </summary>
    Regular4,
    /// <summary>
    /// Special size:M:Rm encoding
    /// size:(23:2),M:(20:1),Rm:(19:4)
    /// With Size:
    /// * BitFields = 00, Value = RESERVED
    /// * BitFields = 01, Value = UInt('0':Rm)
    /// * BitFields = 10, Value = UInt(M:Rm)
    /// * BitFields = 11, Value = RESERVED
    /// </summary>
    SpecialMRm,
}

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RegisterVArrangementKind
{
    None,

    /// <summary>
    /// Dynamic
    /// </summary>
    T,
    B,
    H,
    S,
    D,

    T_16B,
    T_8B,
    T_4B,
    T_2B,

    T_2H,
    T_4H,
    T_8H,

    T_2S,
    T_4S,

    T_1D,
    T_2D,

    T_1Q,

    Reserved,
}


enum ImmediateKind
{
    None,
    /// <summary>
    /// A regular immediate
    /// </summary>
    Regular,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]"
    /// </summary>
    SimdBitShiftType0,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = 16 - UInt(immh:immb),001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = RESERVED]"
    /// </summary>
    SimdBitShiftType1,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = RESERVED,001x = 32 - UInt(immh:immb),01xx = 64 - UInt(immh:immb),1xxx = 128 - UInt(immh:immb)]"
    /// </summary>
    SimdBitShiftType2,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = RESERVED]"
    /// </summary>
    SimdBitShiftType3,
    /// <summary>
    /// The immediate used for the shift operation by SIMD instructions (7 bits with special encoding)
    /// immh [22:4] -> "[0001 = UInt(immh:immb) - 8,001x = UInt(immh:immb) - 16,01xx = UInt(immh:immb) - 32,1xxx = UInt(immh:immb) - 64]"
    /// </summary>
    SimdBitShiftType4,
    /// <summary>
    /// Rotation encoded in 1 bit. [0 = 90,1 = 270]
    /// </summary>
    Rotate90Or270,
    /// <summary>
    /// Rotation encoded in 2 bits. [00 = 0,01 = 90,10 = 180,11 = 270]
    /// </summary>
    Rotate0Or90Or180Or270,
    /// <summary>
    /// A fixed value
    /// </summary>
    FixedInt,
    /// <summary>
    /// A fixed value that is a float
    /// </summary>
    FixedFloatZero,
    /// <summary>
    /// Depending on the bit set of the encoding 0 -> 8, 1 -> 16
    /// </summary>
    EnumAmount8Or16,
    /// <summary>
    /// Depending on the value set in the bits: 00 -> 8, 01 -> 16, 10 -> 32, 11 -> RESERVED.
    /// </summary>
    SimdLeftShift8Or16Or32,
    /// <summary>
    /// Special immediate #index Size: 5 in instruction id EXT_asimdext_only - [(30:1),(14:4)] - Selector: Q,imm4&lt;3>
    /// 0:0 = UInt(imm4&lt;2:0>)
    /// 0:1 = RESERVED
    /// 1:x = UInt(imm4)
    /// </summary>
    SimdExtIndex,
    /// <summary>
    /// 64-bit immediate 'aaaaaaaabbbbbbbbccccccccddddddddeeeeeeeeffffffffgggggggghhhhhhhh'
    /// </summary>
    Imm64,
    /// <summary>
    /// A system register used my MRS and MSR.
    /// </summary>
    SystemRegister,
    /// <summary>
    /// A barrier operation limit used by DMB_bo_barriers and DSB_bo_barriers instructions.
    /// </summary>
    BarrierOperationLimit,
    PrefetchOperation,
    RangePrefetchOperation
}
