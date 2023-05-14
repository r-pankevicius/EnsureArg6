using EnsureThat;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Types.cs
    public static partial class EnsureArg6
    {
        [return: NotNull]
        public static Type IsInt([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsInt(param, paramName);

        [return: NotNull]
        public static object IsInt([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsInt(param, paramName);

        [return: NotNull]
        public static Type IsShort([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsShort(param, paramName);

        [return: NotNull]
        public static object IsShort([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsShort(param, paramName);

        [return: NotNull]
        public static Type IsDecimal([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDecimal(param, paramName);

        [return: NotNull]
        public static object IsDecimal([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDecimal(param, paramName);

        [return: NotNull]
        public static Type IsDouble([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDouble(param, paramName);

        [return: NotNull]
        public static object IsDouble([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDouble(param, paramName);

        [return: NotNull]
        public static Type IsFloat([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsFloat(param, paramName);

        [return: NotNull]
        public static object IsFloat([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsFloat(param, paramName);

        [return: NotNull]
        public static Type IsBool([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsBool(param, paramName);

        [return: NotNull]
        public static object IsBool([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsBool(param, paramName);

        [return: NotNull]
        public static Type IsDateTime([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDateTime(param, paramName);

        [return: NotNull]
        public static object IsDateTime([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDateTime(param, paramName);

        [return: NotNull]
        public static Type IsString([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsString(param, paramName);

        [return: NotNull]
        public static object IsString([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsString(param, paramName);

        [return: NotNull]
        public static object IsOfType([NotNull] object param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        public static Type IsOfType([NotNull]Type param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        public static object IsNotOfType([NotNull]object param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static Type IsNotOfType([NotNull]Type param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static object IsAssignableToType([NotNull] object param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        public static Type IsAssignableToType([NotNull]Type param, Type expectedType, [CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        public static object IsNotAssignableToType([NotNull]object param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static Type IsNotAssignableToType([NotNull]Type param, Type nonExpectedType, [CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static object IsClass([NotNull]object param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsClass(param, paramName);

        [return: NotNull]
        public static Type IsClass([NotNull]Type param, [CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsClass(param, paramName);
    }
}
