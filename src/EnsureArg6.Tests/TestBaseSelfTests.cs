using Xunit.Sdk;

namespace EnsureArg6.Tests
{
	public class TestBaseSelfTests
	{
		[Fact]
		public void AssertThrowsTheSameArgumentException_DoesntThrow_OnSameException()
		{
			static int Check1(int _param) => throw new ArgumentException("qwerty");
			static int Check2(int _param) => throw new ArgumentException("qwerty");

			TestBase.AssertThrowsTheSameArgumentException(42, Check1, Check2);
		}

		[Fact]
		public void AssertThrowsTheSameArgumentException_Throws_OnDifferentExceptionType()
		{
			static int Check1(int _param) => throw new ArgumentException("qwerty");
			static int Check2(int _param) => throw new InvalidOperationException("abcedf");

			bool exceptionWasThrown = false;

			try
			{
				TestBase.AssertThrowsTheSameArgumentException(42, Check1, Check2);
			}
			catch (InvalidOperationException)
			{
				exceptionWasThrown = true;
			}

			exceptionWasThrown.Should().BeTrue();
		}

		[Fact]
		public void AssertThrowsTheSameArgumentException_Throws_OnDifferentExceptionMessage()
		{
			static int Check1(int _param) => throw new ArgumentException("qwerty");
			static int Check2(int _param) => throw new ArgumentException("abcedf");

			bool exceptionWasThrown = false;

			try
			{
				TestBase.AssertThrowsTheSameArgumentException(42, Check1, Check2);
			}
			catch (XunitException)
			{
				exceptionWasThrown = true;
			}

			exceptionWasThrown.Should().BeTrue();
		}
	}
}
