using System.Diagnostics.CodeAnalysis;

namespace EnsureArgVI
{
	public static partial class EnsureArg6
	{
        [return: NotNull]
        public static T IsNotNull<T>([NotNull] T value, [InvokerParameterName] string paramName = null) where T : class
            => Ensure.Any.IsNotNull(value, paramName);
    }
}
