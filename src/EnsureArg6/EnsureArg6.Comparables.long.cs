using EnsureThat;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.long.cs
    public static partial class EnsureArg6
    {
        public static long Is(long value, long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static long IsNot(long value, long expected,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName);

        public static long IsLt(long value, long limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName);

        public static long IsLte(long value, long limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName);

        public static long IsGt(long value, long limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName);

        public static long IsGte(long value, long limit,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName);

        public static long IsInRange(long value, long min, long max,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
