using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Types.cs
	public static partial class EnsureArg6
    {
        [return: NotNull]
        public static Type IsInt([NotNull]Type param,
			OptsFn? optsFn = null,
[           CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsInt(param, paramName, optsFn);

        [return: NotNull]
        public static object IsInt([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsInt(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsShort([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsShort(param, paramName, optsFn);

        [return: NotNull]
        public static object IsShort([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsShort(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsDecimal([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDecimal(param, paramName, optsFn);

        [return: NotNull]
        public static object IsDecimal([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDecimal(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsDouble([NotNull]Type param,
			OptsFn? optsFn = null,
		[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDouble(param, paramName, optsFn);

        [return: NotNull]
        public static object IsDouble([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDouble(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsFloat([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsFloat(param, paramName, optsFn);

        [return: NotNull]
        public static object IsFloat([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsFloat(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsBool([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsBool(param, paramName, optsFn);

        [return: NotNull]
        public static object IsBool([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsBool(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsDateTime([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDateTime(param, paramName, optsFn);

        [return: NotNull]
        public static object IsDateTime([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsDateTime(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsString([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsString(param, paramName, optsFn);

        [return: NotNull]
        public static object IsString([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsString(param, paramName, optsFn);

        [return: NotNull]
        public static object IsOfType([NotNull] object param, Type expectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsOfType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        public static Type IsOfType([NotNull]Type param, Type expectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsOfType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        public static object IsNotOfType([NotNull]object param, Type nonExpectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        public static Type IsNotOfType([NotNull]Type param, Type nonExpectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsNotOfType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        public static object IsAssignableToType([NotNull] object param, Type expectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        public static Type IsAssignableToType([NotNull]Type param, Type expectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsAssignableToType(param, expectedType, paramName, optsFn);

        [return: NotNull]
        public static object IsNotAssignableToType([NotNull]object param, Type nonExpectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        public static Type IsNotAssignableToType([NotNull]Type param, Type nonExpectedType,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
	        => EnsureArg.IsNotAssignableToType(param, nonExpectedType, paramName, optsFn);

        [return: NotNull]
        public static object IsClass([NotNull]object param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsClass(param, paramName, optsFn);

        [return: NotNull]
        public static Type IsClass([NotNull]Type param,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("param")] string paramName = "")
            => EnsureArg.IsClass(param, paramName, optsFn);
    }
}
