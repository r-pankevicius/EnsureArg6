using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Comparables_decimal_Tests
	{
		[Fact]
		public void Is_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.Is(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.50m, 2.99m, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99m, 2.99m, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99m, 2.99m, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99m, 2.50m, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99m, 2.99m, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static decimal Check(decimal param1, decimal param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static decimal Check6(decimal param1, decimal param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.50m, 2.99m, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static decimal Check(decimal param, decimal before, decimal after) =>
				EnsureArg.IsInRange(param, before, after, nameof(param));
			static decimal Check6(decimal param, decimal before, decimal after) =>
				EnsureArg6.IsInRange(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(2.50m, 2.99m, 3.50m, Check, Check6);
		}
	}
}
