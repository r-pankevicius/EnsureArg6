using EnsureThat;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Any_Tests
	{
		[Fact]
		public void Test1()
		{
			static void NoNullzPlz(object param78y653) => EnsureArg.IsNotNull(param78y653, nameof(param78y653));
			static void NoNullzPlz6(object param78y653) => EnsureArg6.IsNotNull(param78y653);

			//!CS8622
			// Exclamation marks are used to suppress the warning about the parameter being null.
			// What is strange because compiler sees that the parameter is not null.
			TestBase.AssertThrowsTheSameArgumentException(NoNullzPlz!, NoNullzPlz6!);
		}
	}
}
