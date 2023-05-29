using EnsureThat;
using System.Text.RegularExpressions;

namespace EnsureArg6.Tests
{
	public class EnsurEnsureArg6_Strings_Tests
	{
		private const string AllDigitsPatternString = "^[0-9]+$";

		private static readonly Regex AllDigitsRegex = new(AllDigitsPatternString);

		[Fact]
		public void IsNotNull_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotNull(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotNull(myParamPamPam);

			string? param = null;
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IIsNotNullOrEmpty_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotNullOrEmpty(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotNullOrEmpty(myParamPamPam);

			string? param = "";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNotNullOrWhiteSpace_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotNullOrWhiteSpace(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotNullOrWhiteSpace(myParamPamPam);

			string? param = "    ";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNotEmptyOrWhiteSpace_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotEmptyOrWhiteSpace(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotEmptyOrWhiteSpace(myParamPamPam);

			string? param = "    ";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNotEmpty_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotEmpty(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotEmpty(myParamPamPam);

			string? param = "";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void HasLength_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.HasLength(myParamPamPam, 3, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.HasLength(myParamPamPam, 3);

			string? param = "AAA4";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void HasLengthBetween_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.HasLengthBetween(myParamPamPam, 3, 4, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.HasLengthBetween(myParamPamPam, 3, 4);

			string? param = "AAA45";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Matches_StringPattern_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.Matches(myParamPamPam, AllDigitsPatternString, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.Matches(myParamPamPam, AllDigitsPatternString);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Matches_Regex_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.Matches(myParamPamPam, AllDigitsRegex, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.Matches(myParamPamPam, AllDigitsRegex);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		// Is
		// Is_WithStringComparison
		// IsEqualTo
		// IsEqualTo_WithStringComparison
		// IsNot
		// IsNot_WithStringComparison
		// IsNotEqualTo
		// IsNotEqualTo_WithStringComparison
		// IsGuid
		// StartsWith
		// StartsWith_WithStringComparison
		// IsAllLettersOrDigits
	}
}
