using EnsureThat;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Enums_Tests
	{
		private enum Number
		{
			One = 1,
			Two = 2,
			Three = 3
		}

		[Fact]
		public void EnumIsDefined_Test()
		{
			static Number Check(Number myParamPamPam) => EnsureArg.EnumIsDefined(myParamPamPam, nameof(myParamPamPam));
			static Number Check6(Number myParamPamPam) => EnsureArg6.EnumIsDefined(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(default(Number), Check, Check6);
		}

		[Fact]
		public void EnumIsDefinedWithFlagsSupport_Test()
		{
			static Number Check(Number myParamPamPam) => EnsureArg.EnumIsDefinedWithFlagsSupport(myParamPamPam, nameof(myParamPamPam));
			static Number Check6(Number myParamPamPam) => EnsureArg6.EnumIsDefinedWithFlagsSupport(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(default(Number), Check, Check6);
		}
	}
}
