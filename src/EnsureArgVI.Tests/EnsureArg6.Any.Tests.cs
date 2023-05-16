using EnsureThat;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Any_Tests
	{
		[Fact]
		public void IsNotNull_Test()
		{
			static void Check(object? myParamPamPam) => EnsureArg.IsNotNull(myParamPamPam, nameof(myParamPamPam));
			static void Check6(object? myParamPamPam) => EnsureArg6.IsNotNull(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentExceptionOnDefault<object?>(Check, Check6);
		}
	}
}
