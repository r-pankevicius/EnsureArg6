using EnsureThat;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Comparables.int.cs
    public static partial class EnsureArg6
    {
        public static int Is(int value, int expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.Is(value, expected, paramName);

        public static int IsNot(int value, int expected, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsNot(value, expected, paramName);

        public static int IsLt(int value, int limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLt(value, limit, paramName);

        public static int IsLte(int value, int limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsLte(value, limit, paramName);

        public static int IsGt(int value, int limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGt(value, limit, paramName);

        public static int IsGte(int value, int limit, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsGte(value, limit, paramName);

        public static int IsInRange(int value, int min, int max, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsInRange(value, min, max, paramName);
    }
}
