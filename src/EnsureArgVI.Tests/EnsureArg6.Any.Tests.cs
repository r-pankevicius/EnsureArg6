using EnsureThat;
using System.Diagnostics.CodeAnalysis;

namespace EnsureArgVI.Tests
{
	public class EnsureArg6_Any_Tests
	{
		[Fact]
		public void Test1()
		{
			static void NoNullzPlz(object param78y653) => EnsureArg.IsNotNull(param78y653, nameof(param78y653));
			static void NoNullzPlz6(object param78y653) => EnsureArg6.IsNotNull(param78y653);

			// Exclamation marks are used to suppress the warning about the parameter being null.
			// What is strange because compiler sees that the parameter is not null.
			AssertThrowsTheSameArgumentException(NoNullzPlz!, NoNullzPlz6!);
		}

		private static void AssertThrowsTheSameArgumentException(
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
