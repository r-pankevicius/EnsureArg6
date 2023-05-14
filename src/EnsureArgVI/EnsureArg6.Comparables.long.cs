#if false
namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.long.cs
    public static partial class EnsureArg6
    {
        public static long Is(long value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.Is(value, expected, paramName);

        public static long IsNot(long value, long expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNot(value, expected, paramName);

        public static long IsLt(long value, long limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLt(value, limit, paramName);

        public static long IsLte(long value, long limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLte(value, limit, paramName);

        public static long IsGt(long value, long limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGt(value, limit, paramName);

        public static long IsGte(long value, long limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGte(value, limit, paramName);

        public static long IsInRange(long value, long min, long max, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
#endif
