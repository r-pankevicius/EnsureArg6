using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Comparables_long_Tests
	{
		[Fact]
		public void Is_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.Is(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2L, 3L, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3L, 3L, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3L, 3L, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3L, 2L, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3L, 3L, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static long Check(long param1, long param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static long Check6(long param1, long param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2L, 3L, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static long Check(long param, long before, long after) =>
				EnsureArg.IsInRange<long>(param, before, after, nameof(param));
			static long Check6(long param, long before, long after) =>
				EnsureArg6.IsInRange<long>(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(2L, 3L, 4L, Check, Check6);
		}
	}
}
