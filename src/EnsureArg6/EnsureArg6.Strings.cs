﻿using EnsureThat;
using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureArg6
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Strings.cs
	public static partial class EnsureArg6
    {
        [return: NotNull]
        public static string IsNotNull(
            [NotNull] string? value,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNull(value, paramName);

        [return: NotNull]
        public static string IsNotNullOrWhiteSpace(
            [NotNull] string? value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNullOrWhiteSpace(value, paramName);

        [return: NotNull]
        public static string IsNotNullOrEmpty(
            [NotNull] string? value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotNullOrEmpty(value, paramName);

        public static string IsNotEmptyOrWhiteSpace(
            string? value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEmptyOrWhiteSpace(value, paramName);

        public static string IsNotEmpty(
            string value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEmpty(value, paramName);

        [return: NotNull]
        public static string HasLength(
            [NotNull] string value,
            int expected,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasLength(value, expected, paramName);

        [return: NotNull]
        public static string HasLengthBetween(
            [NotNull] string value,
            int minLength, int maxLength,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.HasLengthBetween(value, minLength, maxLength, paramName);

        [return: NotNull]
        public static string Matches(
            [NotNull] string value,
            [NotNull] string regexPattern,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Matches(value, regexPattern, paramName);

        [return: NotNull]
        public static string Matches(
            [NotNull] string value,
            [NotNull] Regex match,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Matches(value, match, paramName);

        public static string Is(
            string value,
            string expected,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static string Is(
            string value,
            string expected,
            StringComparison comparison,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, comparison, paramName);

        public static string IsEqualTo(
            string value,
            string expected,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsEqualTo(value, expected, paramName);

        public static string IsEqualTo(
            string value,
            string expected,
            StringComparison comparison,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsEqualTo(value, expected, comparison, paramName);

        public static string IsNot(
            string value,
            string notExpected,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, notExpected, paramName);

        public static string IsNot(
            string value,
            string notExpected,
            StringComparison comparison,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, notExpected, comparison, paramName);

        public static string IsNotEqualTo(
            string value,
            string notExpected,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEqualTo(value, notExpected, paramName);

        public static string IsNotEqualTo(
            string value,
            string notExpected,
            StringComparison comparison,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNotEqualTo(value, notExpected, comparison, paramName);

        public static Guid IsGuid(
            [NotNull] string value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGuid(value, paramName);

        [return: NotNull]
        public static string StartsWith(
            [NotNull] string value,
            [NotNull] string expectedStartsWith,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.StartsWith(value, expectedStartsWith, paramName);

        [return: NotNull]
        public static string StartsWith(
            [NotNull] string value,
            [NotNull] string expectedStartsWith,
            StringComparison comparisonType,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.StartsWith(value, expectedStartsWith, comparisonType, paramName);

        [return: NotNull]
        public static string IsAllLettersOrDigits(
            [NotNull] string value,
            [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsAllLettersOrDigits(value, paramName);
    }
}