namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.decimal.cs
    public static partial class EnsureArg6
    {
        public static decimal Is(decimal value, decimal expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static decimal IsNot(decimal value, decimal expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName);

        public static decimal IsLt(decimal value, decimal limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName);

        public static decimal IsLte(decimal value, decimal limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName);

        public static decimal IsGt(decimal value, decimal limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName);

        public static decimal IsGte(decimal value, decimal limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName);

        public static decimal IsInRange(decimal value, decimal min, decimal max, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
