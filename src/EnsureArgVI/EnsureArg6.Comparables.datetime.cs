#if false
using System;

namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.datetime.cs
    public static partial class EnsureArg6
    {
        public static DateTime Is(DateTime value, DateTime expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.Is(value, expected, paramName);

        public static DateTime IsNot(DateTime value, DateTime expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNot(value, expected, paramName);

        public static DateTime IsLt(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLt(value, limit, paramName);

        public static DateTime IsLte(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLte(value, limit, paramName);

        public static DateTime IsGt(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGt(value, limit, paramName);

        public static DateTime IsGte(DateTime value, DateTime limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGte(value, limit, paramName);

        public static DateTime IsInRange(DateTime value, DateTime min, DateTime max, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
#endif
