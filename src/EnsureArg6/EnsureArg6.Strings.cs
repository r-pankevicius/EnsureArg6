using EnsureThat;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace EnsureArg6
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Strings.cs
	public static partial class EnsureArg6
    {
        [return: NotNull]
        public static string IsNotNull(
            [NotNull] string? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNull(value, paramName, optsFn);

        [return: NotNull]
        public static string IsNotNullOrWhiteSpace(
            [NotNull] string? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNullOrWhiteSpace(value, paramName, optsFn);

        [return: NotNull]
        public static string IsNotNullOrEmpty(
            [NotNull] string? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNullOrEmpty(value, paramName, optsFn);

        public static string IsNotEmptyOrWhiteSpace(
            string? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEmptyOrWhiteSpace(value, paramName, optsFn);

        public static string IsNotEmpty(
            string value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEmpty(value, paramName, optsFn);

        [return: NotNull]
        public static string HasLength(
            [NotNull] string value,
            int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasLength(value, expected, paramName, optsFn);

        [return: NotNull]
        public static string HasLengthBetween(
            [NotNull] string value,
            int minLength, int maxLength,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasLengthBetween(value, minLength, maxLength, paramName, optsFn);

        [return: NotNull]
        public static string Matches(
            [NotNull] string value,
            [NotNull] string regexPattern,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Matches(value, regexPattern, paramName, optsFn);

        [return: NotNull]
        public static string Matches(
            [NotNull] string value,
            [NotNull] Regex match,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Matches(value, match, paramName, optsFn);

        public static string Is(
            string value,
            string expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName, optsFn);

        public static string Is(
            string value,
            string expected,
            StringComparison comparison,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, comparison, paramName, optsFn);

        public static string IsEqualTo(
            string value,
            string expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsEqualTo(value, expected, paramName, optsFn);

        public static string IsEqualTo(
            string value,
            string expected,
            StringComparison comparison,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsEqualTo(value, expected, comparison, paramName, optsFn);

        public static string IsNot(
            string value,
            string notExpected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, notExpected, paramName, optsFn);

        public static string IsNot(
            string value,
            string notExpected,
            StringComparison comparison,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, notExpected, comparison, paramName, optsFn);

        public static string IsNotEqualTo(
            string value,
            string notExpected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEqualTo(value, notExpected, paramName, optsFn);

        public static string IsNotEqualTo(
            string value,
            string notExpected,
            StringComparison comparison,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEqualTo(value, notExpected, comparison, paramName, optsFn);

        public static Guid IsGuid(
            [NotNull] string value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGuid(value, paramName, optsFn);

        [return: NotNull]
        public static string StartsWith(
            [NotNull] string value,
            [NotNull] string expectedStartsWith,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.StartsWith(value, expectedStartsWith, paramName, optsFn);

        [return: NotNull]
        public static string StartsWith(
            [NotNull] string value,
            [NotNull] string expectedStartsWith,
            StringComparison comparisonType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.StartsWith(value, expectedStartsWith, comparisonType, paramName, optsFn);

        [return: NotNull]
        public static string IsAllLettersOrDigits(
            [NotNull] string value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsAllLettersOrDigits(value, paramName, optsFn);
    }
}
