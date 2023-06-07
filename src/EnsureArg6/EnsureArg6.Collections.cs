using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Collections.cs
	public static partial class EnsureArg6
	{
        [return: NotNull]
        public static T HasItems<T>(
            [NotNull] T value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : class, ICollection
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static ICollection<T> HasItems<T>(
            [NotNull]ICollection<T> value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static IReadOnlyCollection<T> HasItems<T>(
            [NotNull]IReadOnlyCollection<T> value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static IReadOnlyList<T> HasItems<T>(
            [NotNull]IReadOnlyList<T> value,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static ISet<T> HasItems<T>(
            [NotNull]ISet<T> value,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static T[] HasItems<T>(
            [NotNull]T[] value,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static IList<T> HasItems<T>(
            [NotNull] IList<T> value,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>(
            [NotNull]IDictionary<TKey, TValue> value,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasItems(value, paramName, optsFn);

        [return: NotNull]
        public static T[] SizeIs<T>(
            [NotNull]T[] value,
            int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static T[] SizeIs<T>(
            [NotNull]T[] value,
            long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static T SizeIs<T>(
            [NotNull]T value,
            int expected,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "") where T : class, ICollection
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static T SizeIs<T>(
            [NotNull]T value,
            long expected,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "") where T : class, ICollection
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static ICollection<T> SizeIs<T>(
            [NotNull]ICollection<T> value,
            int expected,
            OptsFn? optsFn = null,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static ICollection<T> SizeIs<T>(
            [NotNull]ICollection<T> value,
            long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static IList<T> SizeIs<T>(
            [NotNull] IList<T> value,
            int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static IList<T> SizeIs<T>(
            [NotNull]IList<T> value,
            long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>(
            [NotNull]IDictionary<TKey, TValue> value,
            int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>(
            [NotNull]IDictionary<TKey, TValue> value,
            long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.SizeIs(value, expected, paramName, optsFn);

        [return: NotNull]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>(
            [NotNull]IDictionary<TKey, TValue> value,
            TKey expectedKey,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.ContainsKey(value, expectedKey, paramName, optsFn);

        [return: NotNull]
        public static IList<T> HasAny<T>(
            [NotNull] IList<T> value,
            Func<T, bool> predicate,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        public static ICollection<T> HasAny<T>(
            [NotNull]ICollection<T> value,
            Func<T, bool> predicate,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasAny(value, predicate, paramName, optsFn);

        [return: NotNull]
        public static T[] HasAny<T>(
            [NotNull]T[] value,
            Func<T, bool> predicate,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasAny(value, predicate, paramName, optsFn);
    }
}
