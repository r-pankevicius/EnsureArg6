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
		public void EnumIsDefinedTest()
		{
			static void EnumIsDefined(Number number) => EnsureArg.EnumIsDefined(number, nameof(number));
			static void EnumIsDefined6(Number number) => EnsureArg6.EnumIsDefined(number);

			//!CS8622
			// Exclamation marks are used to suppress the warning about the parameter being null.
			// What is strange because compiler sees that the parameter is not null.
			TestBase.AssertThrowsTheSameArgumentExceptionOnDefault<Number>(EnumIsDefined, EnumIsDefined6);
		}

		[Fact]
		public void EnumIsDefinedWithFlagsSupportTest()
		{
			throw new NotImplementedException();
		}
	}
}
