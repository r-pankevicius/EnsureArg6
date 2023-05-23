using EnsureThat;
using System;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.ValueTypes.cs
    public static partial class EnsureArg6
    {
        public static bool IsTrue(bool value, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsTrue(value, paramName);

        public static bool IsFalse(bool value, [CallerArgumentExpression("value")] string paramName = "")
            => EnsureArg.IsFalse(value, paramName);

        public static T IsNotDefault<T>(T value, [CallerArgumentExpression("value")] string paramName = "") where T : struct
            => Ensure.Any.IsNotDefault(value, paramName);

        public static T? IsNotNull<T>(T? value, [CallerArgumentExpression("value")] string paramName = "") where T : struct
            => Ensure.Any.IsNotNull(value, paramName);

        public static Guid IsNotEmpty(Guid value, [CallerArgumentExpression("value")] string paramName = "")
            => Ensure.Guid.IsNotEmpty(value, paramName);
    }
}
