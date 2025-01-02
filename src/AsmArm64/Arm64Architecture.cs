// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// An ARM64 architecture version. Example: ARMv8.0-A.
/// </summary>
/// <param name="Major">The major version.</param>
/// <param name="Minor">The minor version.</param>
/// <param name="Profile">The profile.</param>
public readonly partial record struct Arm64Architecture(Arm64ArchitectureId Id, int Major, int Minor, Arm64ArchitectureProfile Profile) : IComparable<Arm64Architecture>, IComparable
{
    public int CompareTo(Arm64Architecture other)
    {
        var majorComparison = Major.CompareTo(other.Major);
        return majorComparison != 0 ? majorComparison : Minor.CompareTo(other.Minor);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            return 1;
        }

        return obj is Arm64Architecture other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Arm64Architecture)}");
    }

    /// <inheritdoc />
    public override string ToString() => $"ARMv{Major}.{Minor}-{Profile}";

    public static bool operator <(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) < 0;

    public static bool operator >(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) > 0;

    public static bool operator <=(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) <= 0;

    public static bool operator >=(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) >= 0;
}