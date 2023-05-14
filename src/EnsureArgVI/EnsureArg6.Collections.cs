#if false

using System;
using System.Collections;
using System.Collections.Generic;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Collections.cs
	public static partial class EnsureArg6
	{
        [return: NotNull]
        public static T HasItems<T>([NotNull] T value, [InvokerParameterName] string paramName = null) where T : class, ICollection
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static ICollection<T> HasItems<T>([NotNull]ICollection<T> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static IReadOnlyCollection<T> HasItems<T>([NotNull]IReadOnlyCollection<T> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static IReadOnlyList<T> HasItems<T>([NotNull]IReadOnlyList<T> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static ISet<T> HasItems<T>([NotNull]ISet<T> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static T[] HasItems<T>([NotNull]T[] value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static IList<T> HasItems<T>([NotNull] IList<T> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static IDictionary<TKey, TValue> HasItems<TKey, TValue>([NotNull]IDictionary<TKey, TValue> value, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasItems(value, paramName);

        [return: NotNull]
        public static T[] SizeIs<T>([NotNull]T[] value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static T[] SizeIs<T>([NotNull]T[] value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static T SizeIs<T>([NotNull]T value, int expected, [InvokerParameterName] string paramName = null) where T : class, ICollection
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static T SizeIs<T>([NotNull]T value, long expected, [InvokerParameterName] string paramName = null) where T : class, ICollection
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static ICollection<T> SizeIs<T>([NotNull]ICollection<T> value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static ICollection<T> SizeIs<T>([NotNull]ICollection<T> value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static IList<T> SizeIs<T>([NotNull] IList<T> value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static IList<T> SizeIs<T>([NotNull]IList<T> value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static IDictionary<TKey, TValue> SizeIs<TKey, TValue>([NotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.SizeIs(value, expected, paramName);

        [return: NotNull]
        public static IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([NotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName] string paramName = null)
            => EnsureArg.ContainsKey(value, expectedKey, paramName);

        [return: NotNull]
        public static IList<T> HasAny<T>([NotNull] IList<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasAny(value, predicate, paramName);

        [return: NotNull]
        public static ICollection<T> HasAny<T>([NotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasAny(value, predicate, paramName);

        [return: NotNull]
        public static T[] HasAny<T>([NotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName] string paramName = null)
            => EnsureArg.HasAny(value, predicate, paramName);
    }
}
#endif
