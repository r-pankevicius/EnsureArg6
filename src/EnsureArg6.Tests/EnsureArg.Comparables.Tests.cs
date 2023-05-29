using EnsureThat;

namespace EnsureArg6.Tests
{
	public class EnsureArg6_Comparables_Tests
	{
		private static readonly Person Mickey = new("Mickey", 35);
		private static readonly Person Mallory = new("Mallory", 30);
		private static readonly Person Kid = new("Bob", 7);
		private static readonly Person OldMan = new("Jack", 70);

		/// <summary>
		/// Persons are compared by age.
		/// </summary>
		private record Person(string Name, int Age) : IComparable<Person>
		{
			public int CompareTo(Person? other) => other is null ? 1 : Age.CompareTo(other.Age);
		}

		[Fact]
		public void Is_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.Is(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.Is(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mickey, Mallory, Check, Check6);
		}

		[Fact]
		public void IsNot_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.IsNot(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.IsNot(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mickey, Mickey, Check, Check6);
		}

		[Fact]
		public void IsLt_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.IsLt(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.IsLt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mickey, Mickey, Check, Check6);
		}

		[Fact]
		public void IsLte_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.IsLte(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.IsLte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mickey, Mallory, Check, Check6);
		}

		[Fact]
		public void IsGt_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.IsGt(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.IsGt(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mickey, Mickey, Check, Check6);
		}

		[Fact]
		public void IsGte_Test()
		{
			static Person Check(Person param1, Person param2) => EnsureArg.IsGte(param1, param2, nameof(param1));
			static Person Check6(Person param1, Person param2) => EnsureArg6.IsGte(param1, param2);

			TestBase.AssertThrowsTheSameArgumentException(Mallory, Mickey, Check, Check6);
		}

		[Fact]
		public void IsInRange_Test()
		{
			static Person Check(Person param, Person before, Person after) =>
				EnsureArg.IsInRange(param, before, after, nameof(param));
			static Person Check6(Person param, Person before, Person after) =>
				EnsureArg6.IsInRange(param, before, after);

			TestBase.AssertInRangeThrowsTheSameArgumentException(Kid, Mallory, OldMan, Check, Check6);
		}
	}
}
