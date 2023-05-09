using EnsureThat;

namespace EnsureArgVI.Tests
{
	/// <summary>
	/// Inspired by Lithuanian PM Algirdas Butkevičius: https://youtu.be/o14-cvvN1_w
	/// </summary>
	public class ShoulderToShoulderTests
	{
		[Fact]
		public void Test1()
		{
			static void NoNullzPlz(object param78y653) => EnsureArg.IsNotNull(param78y653, nameof(param78y653));
			static void NoNullzPlz6(object param78y653) => EnsureArg6.IsNotNull(param78y653);

			AssertThrowsTheSameArgumentException(NoNullzPlz, NoNullzPlz6);
		}

		private static void AssertThrowsTheSameArgumentException(
			Action ensureArgAction, Action ensureArg6Action)
		{
			Exception ensureArgException;
			Exception ensureArg6Exception;

			try
			{
				ensureArgAction();
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
				ensureArg6Action();
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
