using EnsureThat;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace EnsureArgVI
{
	public static class EnsureArg6
	{
		[return: NotNull]
		public static string IsNotNull(
			[NotNull] string? value,
			[CallerArgumentExpression("value")] string paramName = "",
			OptsFn optsFn = null)
		{
			return Ensure.String.IsNotNull(value, paramName, optsFn);
		}
	}
}
