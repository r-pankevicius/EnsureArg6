using System.Diagnostics.CodeAnalysis;

namespace EnsureArgVI.Tests
{
	internal static class TestBase
	{
		internal static void AssertThrowsTheSameArgumentException(
			[NotNull] Action<object?> ensureArgAction,
			[NotNull] Action<object?> ensureArg6Action)
		{
			Exception? ensureArgException = null;
			Exception? ensureArg6Exception = null;

			try
			{
				ensureArgAction(null);
			}
			catch (ArgumentException ex1)
			{
				ensureArgException = ex1;
			}

			if (ensureArgException is null)
			{
				throw new InvalidOperationException($"{nameof(ensureArgAction)} did not throw.");
			}

			try
			{
				ensureArg6Action(null);
			}
			catch (ArgumentException ex1)
			{
				ensureArg6Exception = ex1;
			}

			if (ensureArg6Exception is null)
			{
				throw new InvalidOperationException($"{nameof(ensureArg6Action)} did not throw.");
			}

			Assert.Equal(ensureArgException.Message, ensureArg6Exception.Message);
		}
	}
}
