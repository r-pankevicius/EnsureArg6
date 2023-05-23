using EnsureThat;
using System;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.datetime.cs
    public static partial class EnsureArg6
    {
        public static DateTime Is(DateTime value, DateTime expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static DateTime IsNot(DateTime value, DateTime expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName);

        public static DateTime IsLt(DateTime value, DateTime limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName);

        public static DateTime IsLte(DateTime value, DateTime limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName);

        public static DateTime IsGt(DateTime value, DateTime limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName);

        public static DateTime IsGte(DateTime value, DateTime limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName);

        public static DateTime IsInRange(DateTime value, DateTime min, DateTime max, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
