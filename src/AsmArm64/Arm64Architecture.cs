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

    /// <summary>
    /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="other">An object to compare with this instance.</param>
    /// <returns>A value that indicates the relative order of the objects being compared.</returns>
    public int CompareTo(Arm64Architecture? other)
    {
        if (other is null)
        {
            return 1;
        }

        var majorComparison = Major.CompareTo(other.Major);
        return majorComparison != 0 ? majorComparison : Minor.CompareTo(other.Minor);
    }

    /// <summary>
    /// Compares the current instance with another object and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
    /// </summary>
    /// <param name="obj">An object to compare with this instance.</param>
    /// <returns>A value that indicates the relative order of the objects being compared.</returns>
    public int CompareTo(object? obj)
    {
        if (obj is null)
        {
            return 1;
        }

        return obj is Arm64Architecture other ? CompareTo(other) : throw new ArgumentException($"Object must be of type {nameof(Arm64Architecture)}");
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => $"ARMv{Major}.{Minor}-{Profile}";

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    public static bool operator <(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) < 0;

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    public static bool operator >(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) > 0;

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    public static bool operator <=(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) <= 0;

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    public static bool operator >=(Arm64Architecture left, Arm64Architecture right) => left.CompareTo(right) >= 0;

    /// <summary>
    /// Indicates whether the current object is equal to another object of the same type.
    /// </summary>
    /// <param name="other">An object to compare with this object.</param>
    /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
    public bool Equals(Arm64Architecture? other) => other is not null && Id == other.Id;

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
    public override bool Equals(object? obj) => obj is Arm64Architecture other && Equals(other);

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    public override int GetHashCode() => (int)Id;

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    public static bool operator ==(Arm64Architecture left, Arm64Architecture right) => left.Equals(right);

    /// <summary>
    /// Determines whether two specified instances of <see cref="Arm64Architecture"/> are not equal.
    /// </summary>
    /// <param name="left">The first object to compare.</param>
    /// <param name="right">The second object to compare.</param>
    /// <returns>true if the objects are not equal; otherwise, false.</returns>
    public static bool operator !=(Arm64Architecture left, Arm64Architecture right) => !left.Equals(right);
}
