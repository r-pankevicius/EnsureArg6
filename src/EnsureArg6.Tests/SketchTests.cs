using EnsureArg6.Tests.Mocks;

namespace EnsureArg6.Tests
{
	public class SketchTests
	{
		[Fact]
		public void Zero_ReturnsZero()
		{
			var sut = new Sketch();
			int result = sut.Zero;
			result.Should().Be(0);
		}

		[Fact]
		public void CheckNotNull_WithNull_ThrowsArgumentNullException()
		{
			var sut = new Sketch();
			Action act = () => sut.CheckNotNull(null);
			act.Should().Throw<ArgumentNullException>()
				.WithMessage("Value can not be null.");
		}

		[Fact]
		public void CheckNotNullWithNameof_WithNull_ThrowsArgumentNullException()
		{
			var sut = new Sketch();
			Action act = () => sut.CheckNotNullWithNameof(null);
			act.Should().Throw<ArgumentNullException>()
				.WithMessage("Value can not be null. (Parameter 'notNullString')");
		}
	}
}