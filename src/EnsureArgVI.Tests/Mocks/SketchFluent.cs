using Ensure6 = EnsureArgVI.EnsureArgFluent;

namespace EnsureArgVI.Tests.Mocks
{
	public class SketchFluent
	{
		public virtual void CheckNotNull(int? notNullInt)
		{
			Ensure6.Arg(notNullInt).IsNotNull();
		}
	}
}
