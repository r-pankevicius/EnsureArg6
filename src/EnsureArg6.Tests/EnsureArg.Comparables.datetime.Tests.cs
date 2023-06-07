namespace EnsureThat
{
	public class EnsureArg6_Comparables_datetime_Tests
	{
		private static readonly DateTime Before = new (2000, 1, 1);
		private static readonly DateTime Now = new(2023, 5, 19);
		private static readonly DateTime After = new (2023, 12, 31);

		[Fact]
		public void Is_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) =>
				EnsureArg.Is(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) =>
				EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, After, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, Before, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, Before, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(After, Before, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, Before, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, After, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static DateTime Check(DateTime param, DateTime before, DateTime after) =>
				EnsureArg.IsInRange(param, before, after, nameof(param));
			static DateTime Check6(DateTime param, DateTime before, DateTime after) =>
				EnsureArg6.IsInRange<DateTime>(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(Before, Now, After, Check, Check6);
		}
	}
}
