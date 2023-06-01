using EnsureThat;

namespace EnsureArg6.Tests
{
	public class ConceptTests
	{
		[Fact]
		public void CanEnterClub_Test()
		{
			Club.Enter(new Person("Andreas", 17));
		}

		[Fact]
		public void CanEnterClub6_Test()
		{
			Club6.Enter(new Person("Andreas", 17));
		}

		private static class Club
		{
			private const int MinAge = 21;

			public static void Enter(Person person)
			{
				//  System.ArgumentOutOfRangeException : Value '17' is not greater than or equal to limit '21'. (Parameter 'person.Age')
				//Actual value was 17.
				EnsureArg.IsNotNull(person, nameof(person));
				EnsureArg.IsGte(person.Age, MinAge, $"{nameof(person)}.{nameof(person.Age)}");
			}
		}

		private static class Club6
		{
			private const int MinAge = 21;

			public static void Enter(Person person)
			{
				// System.ArgumentOutOfRangeException : Value '17' is not greater than or equal to limit '21'. (Parameter 'person.Age')
				// Actual value was 17.
				EnsureArg6.IsNotNull(person);
				EnsureArg6.IsGte(person.Age, MinAge);
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
