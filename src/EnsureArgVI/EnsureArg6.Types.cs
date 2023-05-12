#if false
using System;
using System.Diagnostics.CodeAnalysis;

namespace EnsureArgVI
{
    // https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Types.cs
    public static partial class EnsureArg6
    {
        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsInt([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsInt(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsInt([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsInt(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsShort([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsShort(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsShort([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsShort(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDecimal([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDecimal(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDecimal([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDecimal(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDouble([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDouble(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDouble([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDouble(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsFloat([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsFloat(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsFloat([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsFloat(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsBool([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsBool(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsBool([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsBool(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsDateTime([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDateTime(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsDateTime([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsDateTime(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsString([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsString(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsString([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsString(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsOfType([NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsOfType([NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsOfType(param, expectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsNotOfType([NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsNotOfType([NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsNotOfType(param, nonExpectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsAssignableToType([NotNull] object param, Type expectedType, [InvokerParameterName] string paramName = null)
	        => Ensure.Type.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsAssignableToType([NotNull]Type param, Type expectedType, [InvokerParameterName] string paramName = null)
	        => Ensure.Type.IsAssignableToType(param, expectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsNotAssignableToType([NotNull]object param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
	        => Ensure.Type.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsNotAssignableToType([NotNull]Type param, Type nonExpectedType, [InvokerParameterName] string paramName = null)
	        => Ensure.Type.IsNotAssignableToType(param, nonExpectedType, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static object IsClass([NotNull]object param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsClass(param, paramName);

        [return: NotNull]
        [ContractAnnotation("param:null => halt")]
        public static Type IsClass([NotNull]Type param, [InvokerParameterName] string paramName = null)
            => Ensure.Type.IsClass(param, paramName);
    }
}
#endif
