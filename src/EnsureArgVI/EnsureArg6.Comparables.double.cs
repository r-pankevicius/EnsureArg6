#if false
namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.double.cs
    public static partial class EnsureArg6
    {
        public static double Is(double value, double expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.Is(value, expected, paramName);

        public static double IsNot(double value, double expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNot(value, expected, paramName);

        public static double IsLt(double value, double limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLt(value, limit, paramName);

        public static double IsLte(double value, double limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLte(value, limit, paramName);

        public static double IsGt(double value, double limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGt(value, limit, paramName);

        public static double IsGte(double value, double limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGte(value, limit, paramName);

        public static double IsInRange(double value, double min, double max, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
#endif
