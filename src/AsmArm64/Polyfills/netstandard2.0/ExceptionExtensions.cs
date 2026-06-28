// Copyright (c) Alexandre Mutel. All rights reserved.
// Licensed under the BSD-Clause 2 license.
// See license.txt file in the project root for full license information.

#if NETSTANDARD2_0
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System;

internal static class ExceptionExtensions
{
    extension(ArgumentNullException)
    {
        public static void ThrowIfNull(object? argument, [CallerArgumentExpression(nameof(argument))] string? paramName = null)
        {
            if (argument is null)
            {
                throw new ArgumentNullException(paramName);
            }
        }
    }

    extension(ObjectDisposedException)
    {
        public static void ThrowIf([DoesNotReturnIf(true)] bool condition, object instance)
        {
            if (condition)
            {
                throw new ObjectDisposedException(instance?.GetType().FullName);
            }
        }
    }

    extension(ArgumentOutOfRangeException)
    {
        public static void ThrowIfGreaterThanOrEqual<T>(T value, T other, [CallerArgumentExpression(nameof(value))] string? paramName = null)
          where T : IComparable<T>
        {
            if (value.CompareTo(other) >= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be greater than or equal to '{other}'.");
        }

        public static void ThrowIfGreaterThan<T>(T value, T other, [CallerArgumentExpression(nameof(value))] string? paramName = null)
          where T : IComparable<T>
        {
            if (value.CompareTo(other) > 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be greater than '{other}'.");
        }

        public static void ThrowIfNegative<T>(T value, [CallerArgumentExpression(nameof(value))] string? paramName = null)
            where T : struct, global::System.IComparable<T>
        {
            switch (value)
            {
                case byte or ushort or uint or ulong or char:
                    return;
                case sbyte n:
                    if (n < 0)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                case short n:
                    if (n < 0)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                case int n:
                    if (n < 0)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                case long n:
                    if (n < 0L)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;

                case float n:
                    if (n < 0F)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                case double n:
                    if (n < 0D)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                case decimal n:
                    if (n < 0M)
                        ThrowArgumentOutOfRangeException(paramName, value);
                    return;
                default:
                    throw new InvalidOperationException($"Invalid type '{typeof(T).AssemblyQualifiedName}' for {paramName}.");
            }

            static void ThrowArgumentOutOfRangeException(string? paramName, object value)
            {
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be negative.");
            }
        }
    }
}
#endif