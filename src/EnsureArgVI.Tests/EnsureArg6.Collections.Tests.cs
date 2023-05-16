using EnsureThat;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Collections_Tests
	{
		[Fact]
		public void HasItems_Test()
		{
			static int[] Check(int[] myParamPamPam) => EnsureArg.HasItems<int[]>(myParamPamPam, nameof(myParamPamPam));
			static int[] Check6(int[] myParamPamPam) => EnsureArg6.HasItems<int[]>(myParamPamPam);

			TestBase.AssertThrowsTheSameArgumentException(Array.Empty<int>(), Check, Check6);
		}

		[Fact]
		public void ICollection_HasItems_Test()
		{
			static ICollection<int> Check(ICollection<int> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static ICollection<int> Check6(ICollection<int> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			ICollection<int> collection = Array.Empty<int>();
			TestBase.AssertThrowsTheSameArgumentException(collection, Check, Check6);
		}

		[Fact]
		public void IReadOnlyCollection_HasItems_Test()
		{
			static IReadOnlyCollection<int> Check(IReadOnlyCollection<int> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static IReadOnlyCollection<int> Check6(IReadOnlyCollection<int> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			IReadOnlyCollection<int> collection = Array.Empty<int>();
			TestBase.AssertThrowsTheSameArgumentException(collection, Check, Check6);
		}

		[Fact]
		public void IReadOnlyList_HasItems_Test()
		{
			static IReadOnlyList<int> Check(IReadOnlyList<int> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static IReadOnlyList<int> Check6(IReadOnlyList<int> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			IReadOnlyList<int> collection = new List<int>();
			TestBase.AssertThrowsTheSameArgumentException(collection, Check, Check6);
		}

		[Fact]
		public void ISet_HasItems_Test()
		{
			static ISet<int> Check(ISet<int> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static ISet<int> Check6(ISet<int> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			ISet<int> set = new HashSet<int>();
			TestBase.AssertThrowsTheSameArgumentException(set, Check, Check6);
		}

		[Fact]
		public void Array_HasItems_Test()
		{
			static int[] Check(int[] myParamPamPam) => EnsureArg.HasItems<int[]>(myParamPamPam, nameof(myParamPamPam));
			static int[] Check6(int[] myParamPamPam) => EnsureArg6.HasItems<int[]>(myParamPamPam);

			int[] array = Array.Empty<int>();
			TestBase.AssertThrowsTheSameArgumentException(array, Check, Check6);
		}

		[Fact]
		public void IList_HasItems_Test()
		{
			static IList<int> Check(IList<int> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static IList<int> Check6(IList<int> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			IList<int> list = new List<int>();
			TestBase.AssertThrowsTheSameArgumentException(list, Check, Check6);
		}

		[Fact]
		public void IDictionary_HasItems_Test()
		{
			static IDictionary<int, string> Check(IDictionary<int, string> myParamPamPam) => EnsureArg.HasItems(myParamPamPam, nameof(myParamPamPam));
			static IDictionary<int, string> Check6(IDictionary<int, string> myParamPamPam) => EnsureArg6.HasItems(myParamPamPam);

			IDictionary<int, string> list = new Dictionary<int, string>();
			TestBase.AssertThrowsTheSameArgumentException(list, Check, Check6);
		}
	}
}
