namespace EnsureThat
{
	public class EnsureArg6_Any_Tests
	{
		[Fact]
		public void IsNotNull_Test()
		{
			static object? Check(object? myParamPamPam) => EnsureArg.IsNotNull(myParamPamPam, nameof(myParamPamPam));
			static object? Check6(object? myParamPamPam) => EnsureArg6.IsNotNull(myParamPamPam);

			object? param = null;
			TestBase.AssertThrowsTheSameArgumentException(param, Check, Check6);
		}
	}
}
