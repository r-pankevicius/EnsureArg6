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
			OptsFn? optsFn = null,
			[CallerArgumentExpression("value")] string paramName = "")
		{
			return Ensure.String.IsNotNull(value, paramName, optsFn);
		}
	}
}
