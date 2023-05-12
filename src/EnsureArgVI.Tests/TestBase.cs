namespace EnsureArgVI.Tests
{
	internal static class TestBase
	{

#pragma warning disable CS8604 // Possible null reference argument.
		internal static void AssertThrowsTheSameArgumentExceptionOnDefault<T>(
			Action<T> ensureArgAction,
			Action<T> ensureArg6Action)
		{
			Exception? ensureArgException = null;
			Exception? ensureArg6Exception = null;

			try
			{
				ensureArgAction(default);
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
				ensureArg6Action(default);
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
#pragma warning restore CS8604 // Possible null reference argument.

	}
}
