using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Comparables_datetime_Tests
	{
		private static readonly DateTime Before = new DateTime(2000, 1, 1);
		private static readonly DateTime After = new DateTime(2023, 12, 31);

		[Fact]
		public void Is_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.Is(myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.Is(myParamPamPam, myParamPamPam);
			
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static DateTime Check(DateTime param1, DateTime param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static DateTime Check6(DateTime param1, DateTime param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Before, After, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.IsLt(myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.IsLt(myParamPamPam, myParamPamPam);
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.IsLte(myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.IsLte(myParamPamPam, myParamPamPam);
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.IsGt(myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.IsGt(myParamPamPam, myParamPamPam);
			
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.IsGte(myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.IsGte(myParamPamPam, myParamPamPam);
			
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static DateTime Check(DateTime myParamPamPam) => EnsureArg.IsInRange(myParamPamPam, myParamPamPam, myParamPamPam, nameof(myParamPamPam));
			static DateTime Check6(DateTime myParamPamPam) => EnsureArg6.IsInRange(myParamPamPam, myParamPamPam, myParamPamPam);
			
			TestBase.AssertThrowsTheSameArgumentException(DateTime.Now, Check, Check6);
		}

	}
}
