using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsurEnsureArg6_Strings_Tests
	{
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

		// 
		// 
		// IsNotEmptyOrWhiteSpace
		// IsNotEmpty
		// HasLength
		// HasLengthBetween
		// Matches_StringPattern
		// Matches_Regex
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
