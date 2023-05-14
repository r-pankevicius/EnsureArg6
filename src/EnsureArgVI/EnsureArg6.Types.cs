using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Types.cs
    public static partial class EnsureArg6
    {
        [return: NotNull]
        public static Type IsInt([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInt(param, paramName);

        [return: NotNull]
        public static object IsInt([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsInt(param, paramName);

        [return: NotNull]
        public static Type IsShort([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsShort(param, paramName);

        [return: NotNull]
        public static object IsShort([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsShort(param, paramName);

        [return: NotNull]
        public static Type IsDecimal([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDecimal(param, paramName);

        [return: NotNull]
        public static object IsDecimal([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDecimal(param, paramName);

        [return: NotNull]
        public static Type IsDouble([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDouble(param, paramName);

        [return: NotNull]
        public static object IsDouble([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDouble(param, paramName);

        [return: NotNull]
        public static Type IsFloat([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsFloat(param, paramName);

        [return: NotNull]
        public static object IsFloat([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsFloat(param, paramName);

        [return: NotNull]
        public static Type IsBool([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsBool(param, paramName);

        [return: NotNull]
        public static object IsBool([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsBool(param, paramName);

        [return: NotNull]
        public static Type IsDateTime([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDateTime(param, paramName);

        [return: NotNull]
        public static object IsDateTime([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsDateTime(param, paramName);

        [return: NotNull]
        public static Type IsString([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsString(param, paramName);

        [return: NotNull]
        public static object IsString([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsString(param, paramName);

        [return: NotNull]
        public static object IsOfType([NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        public static Type IsOfType([NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        public static object IsNotOfType([NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static Type IsNotOfType([NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static object IsAssignableToType([NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null)
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        public static Type IsAssignableToType([NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null)
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        public static object IsNotAssignableToType([NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static Type IsNotAssignableToType([NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        public static object IsClass([NotNull]object param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsClass(param, paramName);

        [return: NotNull]
        public static Type IsClass([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => EnsureArg.IsClass(param, paramName);
    }
}
