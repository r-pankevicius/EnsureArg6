namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.double.cs
    public static partial class EnsureArg6
    {
        public static double Is(double value, double expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static double IsNot(double value, double expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName);

        public static double IsLt(double value, double limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName);

        public static double IsLte(double value, double limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName);

        public static double IsGt(double value, double limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName);

        public static double IsGte(double value, double limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName);

        public static double IsInRange(double value, double min, double max, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
