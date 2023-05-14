#if false
namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.int.cs
    public static partial class EnsureArg6
    {
        public static int Is(int value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.Is(value, expected, paramName);

        public static int IsNot(int value, int expected, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNot(value, expected, paramName);

        public static int IsLt(int value, int limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLt(value, limit, paramName);

        public static int IsLte(int value, int limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsLte(value, limit, paramName);

        public static int IsGt(int value, int limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGt(value, limit, paramName);

        public static int IsGte(int value, int limit, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsGte(value, limit, paramName);

        public static int IsInRange(int value, int min, int max, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
#endif
