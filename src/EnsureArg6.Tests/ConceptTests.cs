using EnsureThat;

namespace EnsureArg6.Tests
{
	public class ConceptTests
	{
		[Fact]
		public void CanEnterClub_Test()
		{
			static Person CheckCantEnter(Person? person) => Club.Enter(person);
			static Person CheckCantEnter6(Person? person) => Club.Enter6(person);

			var personToCheck = new Person("Andreas", 17);

			// Both methods will throw:
			// System.ArgumentOutOfRangeException : Value '17' is not greater than or equal to limit '21'. (Parameter 'person.Age')
			// Actual value was 17.
			TestBase.AssertThrowsTheSameArgumentException(personToCheck, CheckCantEnter, CheckCantEnter6);
		}

		private static class Club
		{
			private const int MinAge = 21;

			public static Person Enter(Person? person)
			{
				EnsureArg.IsNotNull(person, nameof(person));
				EnsureArg.IsGte(person.Age, MinAge, $"{nameof(person)}.{nameof(person.Age)}");
				return person!;
			}

			public static Person Enter6(Person? person)
			{
				EnsureArg6.IsNotNull(person);
				EnsureArg6.IsGte(person.Age, MinAge);
				return person!;
			}
		}

		private class Person
		{
			public Person(string name, int age)
			{
				Name = name;
				Age = age;
			}

			public string Name { get; set; }
			public int Age { get; set; }
		}
	}
}
