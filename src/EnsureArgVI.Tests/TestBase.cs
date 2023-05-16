namespace EnsureArgVI.Tests
{
	internal static class TestBase
	{
		internal static void AssertThrowsTheSameArgumentException<T>(
			T param,
			Action<T> ensureArgAction,
			Action<T> ensureArg6Action)
		{
			Exception? ensureArgException = null;
			Exception? ensureArg6Exception = null;

			try
			{
				ensureArgAction(param);
			}
			catch (ArgumentException ex1)
			{
				ensureArgException = ex1;
			}

			ensureArgException.Should().NotBeNull($"{nameof(ensureArgAction)} did not throw.");

			try
			{
				ensureArg6Action(param);
			}
			catch (ArgumentException ex1)
			{
				ensureArg6Exception = ex1;
			}

			ensureArg6Exception.Should().NotBeNull($"{nameof(ensureArg6Action)} did not throw.");

			ensureArgException!.Should().BeOfType(ensureArg6Exception!.GetType(), $"{nameof(ensureArgAction)} and {nameof(ensureArg6Action)} did not throw the same exception type.");
			ensureArgException!.Message.Should().Be(ensureArg6Exception.Message, $"{nameof(ensureArgAction)} and {nameof(ensureArg6Action)} did not throw the same exception message.");
		}

		internal static void AssertThrowsTheSameArgumentException<T1, T2>(
			T1 param1, T2 param2,
			Action<T1, T2> ensureArgAction,
			Action<T1, T2> ensureArg6Action)
		{
			Exception? ensureArgException = null;
			Exception? ensureArg6Exception = null;

			try
			{
				ensureArgAction(param1, param2);
			}
			catch (ArgumentException ex1)
			{
				ensureArgException = ex1;
			}

			ensureArgException.Should().NotBeNull($"{nameof(ensureArgAction)} did not throw.");

			try
			{
				ensureArg6Action(param1, param2);
			}
			catch (ArgumentException ex1)
			{
				ensureArg6Exception = ex1;
			}

			ensureArg6Exception.Should().NotBeNull($"{nameof(ensureArg6Action)} did not throw.");

			ensureArgException!.Should().BeOfType(ensureArg6Exception!.GetType(), $"{nameof(ensureArgAction)} and {nameof(ensureArg6Action)} did not throw the same exception type.");
			ensureArgException!.Message.Should().Be(ensureArg6Exception.Message, $"{nameof(ensureArgAction)} and {nameof(ensureArg6Action)} did not throw the same exception message.");
		}
	}
}
