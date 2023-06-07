using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.decimal.cs
	public static partial class EnsureArg6
    {
        public static decimal Is(
            decimal value, decimal expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName, optsFn);

        public static decimal IsNot(
            decimal value, decimal expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName, optsFn);

        public static decimal IsLt(
            decimal value, decimal limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName, optsFn);

        public static decimal IsLte(
            decimal value, decimal limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName, optsFn);

        public static decimal IsGt(
            decimal value, decimal limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName, optsFn);

        public static decimal IsGte(
            decimal value, decimal limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName, optsFn);

        public static decimal IsInRange(
            decimal value, decimal min, decimal max,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName, optsFn);
    }
}
