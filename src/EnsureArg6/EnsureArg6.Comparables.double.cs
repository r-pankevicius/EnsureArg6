using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.double.cs
	public static partial class EnsureArg6
	{
		public static double Is(
			double value, double expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.Is(value, expected, paramName, optsFn);

		public static double IsNot(
			double value, double expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsNot(value, expected, paramName, optsFn);

		public static double IsLt(
			double value, double limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsLt(value, limit, paramName, optsFn);

		public static double IsLte(
			double value, double limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsLte(value, limit, paramName, optsFn);

		public static double IsGt(
			double value, double limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsGt(value, limit, paramName, optsFn);

		public static double IsGte(
			double value, double limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsGte(value, limit, paramName, optsFn);

		public static double IsInRange(
			double value, double min, double max,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
			=> EnsureArg.IsInRange(value, min, max, paramName, optsFn);
	}
}
