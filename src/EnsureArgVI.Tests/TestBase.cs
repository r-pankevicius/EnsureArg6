namespace EnsureArgVI.Tests
{
	internal static class TestBase
	{
		internal static void AssertThrowsTheSameArgumentException<T>(
			T paramAndRetVal,
			Func<T, T> ensureArgFunc,
			Func<T, T> ensureArg6Func)
		{
			AssertThrowsTheSameArgumentException_Impl(
				paramAndRetVal,
				(arg) => { _ = ensureArgFunc(arg); },
				(arg) => { _ = ensureArg6Func(arg); });
		}

		private static void AssertThrowsTheSameArgumentException_Impl<T>(
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

		/*
		internal static void AssertThrowsTheSameArgumentException<T, T>(
			T param1, T param2,
			Action<T, T> ensureArgAction,
			Action<T, T> ensureArg6Action)
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

		internal static void AssertThrowsTheSameArgumentException<T>(
			T param1,
			T param2,
			Func<T, T> ensureArgFunc,
			Func<T, T> ensureArg6Func)
		{
			AssertThrowsTheSameArgumentException(
				paramAndRetVal,
				(arg) => { _ = ensureArgFunc(arg); },
				(arg) => { _ = ensureArg6Func(arg); });
		}
		*/
	}
}
