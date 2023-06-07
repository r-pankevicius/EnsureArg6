using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.int.cs
	public static partial class EnsureArg6
	{
		public static int Is(int value, int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.Is(value, expected, paramName, optsFn);

		public static int IsNot(int value, int expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsNot(value, expected, paramName, optsFn);

		public static int IsLt(int value, int limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsLt(value, limit, paramName, optsFn);

		public static int IsLte(int value, int limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsLte(value, limit, paramName, optsFn);

		public static int IsGt(int value, int limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsGt(value, limit, paramName, optsFn);

		public static int IsGte(int value, int limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsGte(value, limit, paramName, optsFn);

		public static int IsInRange(int value, int min, int max,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsInRange(value, min, max, paramName, optsFn);
	}
}
