using EnsureThat;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.cs
	public static partial class EnsureArg6
	{
        public static T Is<T>(
            T value,
            T expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.Is(value, expected, paramName);

        public static T Is<T>(
            T value,
            T expected,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.Is(value, expected, comparer, paramName);

        public static T IsNot<T>(
            T value,
            T expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsNot(value, expected, paramName);

        public static T IsNot<T>(
            T value,
            T expected,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsNot(value, expected, comparer, paramName);

        public static T IsLt<T>(
            T value,
            T limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsLt(value, limit, paramName);

        public static T IsLt<T>(
            T value,
            T limit,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsLt(value, limit, comparer, paramName);

        public static T IsLte<T>(
            T value,
            T limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsLte(value, limit, paramName);

        public static T IsLte<T>(
            T value,
            T limit,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsLte(value, limit, comparer, paramName);

        public static T IsGt<T>(
            T value,
            T limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsGt(value, limit, paramName);

        public static T IsGt<T>(
            T value,
            T limit,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsGt(value, limit, comparer, paramName);

        public static T IsGte<T>(
            T value,
            T limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsGte(value, limit, paramName);

        public static T IsGte<T>(
            T value,
            T limit,
            [NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsGte(value, limit, comparer, paramName);

        public static T IsInRange<T>(
            T value,
            T min,
            T max,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsInRange(value, min, max, paramName);

        public static T IsInRange<T>(
            T value,
            T min,
            T max,
			[NotNull] IComparer<T> comparer,
			OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "") where T : IComparable<T>
            => EnsureArg.IsInRange(value, min, max, comparer, paramName);
    }
}
