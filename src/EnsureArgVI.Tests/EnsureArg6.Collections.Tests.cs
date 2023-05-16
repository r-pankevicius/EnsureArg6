using EnsureThat;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Collections_Tests
	{
		[Fact]
		public void HasItemsT_Test()
		{
			static void Check(int[] myParamPamPam) => EnsureArg.HasItems<int[]>(myParamPamPam, nameof(myParamPamPam));
			static void Check6(int[] myParamPamPam) => EnsureArg6.HasItems<int[]>(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(Array.Empty<int>(), Check, Check6);
		}

		[Fact]
		public void HasItems_Test()
		{
			static void Check(int[] myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static void Check6(int[] myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(Array.Empty<int>(), Check, Check6);
		}

	}
}
