using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureThat
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Any.cs
	public static partial class EnsureArg6
	{
        [return: NotNull]
        public static T IsNotNull<T>(
            [NotNull] T? value,
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "") where T : class
            => EnsureArg.IsNotNull(value, paramName, optsFn);
    }
}
