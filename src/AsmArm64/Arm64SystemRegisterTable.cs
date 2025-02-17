// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// Internal class to provide information about ARM64 system registers.
/// </summary>
internal static partial class Arm64SystemRegisterTable
{
    public static string GetNameById(Arm64SystemRegisterKnownId id) => NamesOrderedById[(int)id];

    public static ushort GetValueById(Arm64SystemRegisterKnownId id) => ValuesOrderedById[(int)id];

    public static Arm64SystemRegisterKind GetKindById(Arm64SystemRegisterKnownId id) => KindsOrderedById[(int)id];

    public static bool TryFindIdByValue(ushort value, out Arm64SystemRegisterKnownId id)
    {
        Span<ushort> values = ValuesForBinarySearch;
        var indexOfValue = values.BinarySearch(value);
        if (indexOfValue >= 0)
        {
            id = IdsOrderedByValue[indexOfValue];
            return true;
        }
        id = Arm64SystemRegisterKnownId.None;
        return false;
    }
}