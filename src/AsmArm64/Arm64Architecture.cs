// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

namespace AsmArm64;

/// <summary>
/// An ARM64 architecture version. Example: ARMv8.0-A.
/// </summary>
public sealed partial class Arm64Architecture : IEquatable<Arm64Architecture>, IComparable<Arm64Architecture>, IComparable
{
    internal Arm64Architecture(Arm64ArchitectureId id, int major, int minor, Arm64ArchitectureProfile profile)
    {
        Id = id;
        Major = major;
        Minor = minor;
        Profile = profile;
    }

    /// <summary>
    /// Gets the id of the architecture.
    /// </summary>
    public Arm64ArchitectureId Id { get; }
    

    /// <summary>
    /// Gets the major version.
    /// </summary>
    public int Major { get; }

    /// <summary>
    /// Gets the minor version.
    /// </summary>
    public int Minor { get; }

    /// <summary>
    /// Gets the profile.
    /// </summary>
    public Arm64ArchitectureProfile Profile { get; }
    
    public int CompareTo(Arm64Architecture? other)
    {
        if (other is null)
        {
            return 1;
        }

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

    public bool Equals(Arm64Architecture? other) => other is not null && Id == other.Id;

    public override bool Equals(object? obj) => obj is Arm64Architecture other && Equals(other);

    public override int GetHashCode() => (int)Id;

    public static bool operator ==(Arm64Architecture left, Arm64Architecture right) => left.Equals(right);

    public static bool operator !=(Arm64Architecture left, Arm64Architecture right) => !left.Equals(right);
}