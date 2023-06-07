namespace EnsureThat
{
	public class EnsureArg6_Comparables_double_Tests
	{
		[Fact]
		public void Is_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.Is(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.50, 2.99, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99, 2.99, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99, 2.99, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99, 2.50, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.99, 2.99, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static double Check(double param1, double param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static double Check6(double param1, double param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(2.50, 2.99, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static double Check(double param, double before, double after) =>
				EnsureArg.IsInRange<double>(param, before, after, nameof(param));
			static double Check6(double param, double before, double after) =>
				EnsureArg6.IsInRange<double>(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(2.50, 2.99, 3.50, Check, Check6);
		}
	}
}
