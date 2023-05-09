using EnsureArgVI.Tests.Mocks;

namespace EnsureArgVI.Tests
{
	public class Sketch6Tests
	{
		[Fact]
		public void Zero_ReturnsZero()
		{
			var sut = new Sketch6();
			int result = sut.Zero;
			result.Should().Be(0);
		}

		[Fact]
		public void CheckNotNull_WithNull_ThrowsArgumentNullException()
		{
			var sut = new Sketch6();
			Action act = () => sut.CheckNotNull(null);
			act.Should().Throw<ArgumentNullException>()
				.WithMessage("Value can not be null. (Parameter 'notNullObject')");
		}
	}
}
