using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Comparables_int_Tests
	{
		[Fact]
		public void Is_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.Is(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2, 3, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3, 3, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3, 3, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3, 2, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(3, 3, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static int Check(int param1, int param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static int Check6(int param1, int param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2, 3, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static int Check(int param, int before, int after) =>
				EnsureArg.IsInRange<int>(param, before, after, nameof(param));
			static int Check6(int param, int before, int after) =>
				EnsureArg6.IsInRange<int>(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(2, 3, 4, Check, Check6);
		}
	}
}
