using EnsureThat;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureArg6
{
	// https://github.com/danielwertheim/Ensure.That/blob/master/src/projects/EnsureThat/EnsureArg.Any.cs
	public static partial class EnsureArg6
	{
        [return: NotNull]
        public static T IsNotNull<T>(
            [NotNull] T? value,
			[CallerArgumentExpression("value")] string paramName = "") where T : class
            => EnsureArg.IsNotNull(value, paramName);
    }
}
