# EnsureArg6
[EnsureArg](https://github.com/danielwertheim/Ensure.That#ensurearg---using-simple-static-methods) without **nameof**.

Instead of writing:
```csharp
public static void EnterClub(Person? person)
{
	EnsureArg.IsNotNull(person, nameof(person));
	EnsureArg.IsGte(person.Age, MinAge, $"{nameof(person)}.{nameof(person.Age)}");
	
	LetIn(person);
}
```

you can write:
```csharp
public static void EnterClub(Person? person)
{
	EnsureArg6.IsNotNull(person);
	EnsureArg6.IsGte(person.Age, MinAge);
	
	LetIn(person);
}
```

and it will work the same. Example of failed validation example in both methods in case `MinAge` is `21`
and person is `{ Name: "Andreas", Age: 17}`:
```
System.ArgumentOutOfRangeException : Value '17' is not greater than or equal to limit '21'. (Parameter 'person.Age') Actual value was 17.
```
