using EnsureArgVI.Tests.Mocks;

namespace EnsureArgVI.Tests
{
	public class SketchFluentTests
	{
		[Fact]
		public void CheckNotNull_WithNull_ThrowsArgumentNullException()
		{
			var sut = new SketchFluent();
			Action act = () => sut.CheckNotNull(null);
			act.Should().Throw<ArgumentNullException>()
				.WithMessage("Value can not be null. (Parameter 'notNullInt')");
		}
	}
}
