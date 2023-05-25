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

		internal static void AssertThrowsTheSameArgumentException_Type<T, TType>(
			T obj, TType type,
			Func<T, TType, T> ensureArgAction,
			Func<T, TType, T> ensureArg6Action)
				where TType : Type
		{
			AssertThrowsTheSameArgumentException_Impl(
				() => { _ = ensureArgAction(obj, type); },
				() => { _ = ensureArg6Action(obj, type); });
		}

		internal static void AssertInRangeThrowsTheSameArgumentException<T>(
			T param, T min, T max,
			Func<T, T, T, T> ensureInRangeArgAction,
			Func<T, T, T, T> ensureInRangeArg6Action)
		{
			AssertThrowsTheSameArgumentException_Impl(
				() => { _ = ensureInRangeArgAction(param, min, max); },
				() => { _ = ensureInRangeArg6Action(param, min, max); });
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
