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
			static string Check(string myParamPamPam) => EnsureArg.IsNotEmpty(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsNotEmpty(myParamPamPam);

			string? param = "";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void HasLength_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.HasLength(myParamPamPam, 3, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.HasLength(myParamPamPam, 3);

			string? param = "AAA4";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void HasLengthBetween_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.HasLengthBetween(myParamPamPam, 3, 4, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.HasLengthBetween(myParamPamPam, 3, 4);

			string? param = "AAA45";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Matches_StringPattern_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.Matches(myParamPamPam, AllDigitsPatternString, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.Matches(myParamPamPam, AllDigitsPatternString);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Matches_Regex_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.Matches(myParamPamPam, AllDigitsRegex, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.Matches(myParamPamPam, AllDigitsRegex);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Is_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.Is(myParamPamPam, "4a", nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.Is(myParamPamPam, "4a");

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void Is_WithStringComparison_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.Is(myParamPamPam, "k", StringComparison.OrdinalIgnoreCase, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.Is(myParamPamPam, "k", StringComparison.OrdinalIgnoreCase);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsEqualTo_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsEqualTo(myParamPamPam, "4a", nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsEqualTo(myParamPamPam, "4a");

			string param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsEqualTo_WithStringComparison_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsEqualTo(myParamPamPam, "k", StringComparison.OrdinalIgnoreCase, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsEqualTo(myParamPamPam, "k", StringComparison.OrdinalIgnoreCase);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsNot(myParamPamPam, "4A", nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsNot(myParamPamPam, "4A");

			string param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNot_WithStringComparison_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsNot(myParamPamPam, "4A", StringComparison.OrdinalIgnoreCase, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsNot(myParamPamPam, "4A", StringComparison.OrdinalIgnoreCase);

			string? param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNotEqualTo_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsNotEqualTo(myParamPamPam, "4A", nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsNotEqualTo(myParamPamPam, "4A");

			string param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsNotEqualTo_WithStringComparison_Test()
		{
			static string Check(string myParamPamPam) => EnsureArg.IsNotEqualTo(myParamPamPam, "4a", StringComparison.OrdinalIgnoreCase, nameof(myParamPamPam));
			static string Check6(string myParamPamPam) => EnsureArg6.IsNotEqualTo(myParamPamPam, "4a", StringComparison.OrdinalIgnoreCase);

			string param = "4A";
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}

		[Fact]
		public void IsGuid_Test()
		{
			static Guid Check(string myParamPamPam) => EnsureArg.IsGuid(myParamPamPam,nameof(myParamPamPam));
			static Guid Check6(string myParamPamPam) => EnsureArg6.IsGuid(myParamPamPam);

			string param = "abc";
			TestBase.AssertThrowsTheSameArgumentException2<string, Guid>(param, Check, Check6);
		}

		// StartsWith
		// StartsWith_WithStringComparison
		// IsAllLettersOrDigits
	}
}
