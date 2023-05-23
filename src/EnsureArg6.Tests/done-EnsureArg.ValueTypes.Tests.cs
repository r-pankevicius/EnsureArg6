using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_ValueTypes_Tests
	{
		[Fact]
		public void IsTrue_Test()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsTrue(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsTrue(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(false, Check, Check6);
		}

		[Fact]
		public void IsFalse_Test()
		{
			static bool Check(bool myParamPamPam) => EnsureArg.IsFalse(myParamPamPam, nameof(myParamPamPam));
			static bool Check6(bool myParamPamPam) => EnsureArg6.IsFalse(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(true, Check, Check6);
		}

		[Fact]
		public void IsNotDefault_Test()
		{
			static int Check(int myParamPamPam) => EnsureArg.IsNotDefault(myParamPamPam, nameof(myParamPamPam));
			static int Check6(int myParamPamPam) => EnsureArg6.IsNotDefault(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(default(int), Check, Check6);
		}

		[Fact]
		public void IsNotNull_Test()
		{
			static string Check(string? myParamPamPam) => EnsureArg.IsNotNull(myParamPamPam, nameof(myParamPamPam));
			static string Check6(string? myParamPamPam) => EnsureArg6.IsNotNull(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException((string?)null, Check, Check6);
		}

		[Fact]
		public void GuidIsNotEmpty_Test()
		{
			static Guid Check(Guid myParamPamPam) => EnsureArg.IsNotEmpty(myParamPamPam, nameof(myParamPamPam));
			static Guid Check6(Guid myParamPamPam) => EnsureArg6.IsNotEmpty(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(Guid.Empty, Check, Check6);
		}
	}
}
