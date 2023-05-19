namespace EnsureArg6.Tests
{
	internal static class TestBase
	{
		internal static void AssertThrowsTheSameArgumentException<T>(
			T paramAndRetVal,
			Func<T, T> ensureArgFunc,
			Func<T, T> ensureArg6Func)
		{
			AssertThrowsTheSameArgumentException_Impl(
				() => { _ = ensureArgFunc(paramAndRetVal); },
				() => { _ = ensureArg6Func(paramAndRetVal); });
		}

		internal static void AssertThrowsTheSameArgumentException<T>(
			T param1, T param2,
			Action<T, T> ensureArgAction,
			Action<T, T> ensureArg6Action)
		{
			AssertThrowsTheSameArgumentException_Impl(
				() => { ensureArgAction(param1, param2); },
				() => { ensureArg6Action(param1, param2); });
		}

		internal static void AssertThrowsTheSameArgumentException<T>(
			T param1, T param2,
			Func<T, T, T> ensureArgAction,
			Func<T, T, T> ensureArg6Action)
		{
			AssertThrowsTheSameArgumentException_Impl(
				() => { _ = ensureArgAction(param1, param2); },
				() => { _ = ensureArg6Action(param1, param2); });
		}

		private static void AssertThrowsTheSameArgumentException_Impl(
			Action ensureArgAction,
			Action ensureArg6Action)
		{
			Exception? ensureArgException = null;
			Exception? ensureArg6Exception = null;

			try
			{
				ensureArgAction();
			}
			catch (ArgumentException ex1)
			{
				ensureArgException = ex1;
			}

			ensureArgException.Should().NotBeNull($"{nameof(ensureArgAction)} did not throw.");

			try
			{
				ensureArg6Action();
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
