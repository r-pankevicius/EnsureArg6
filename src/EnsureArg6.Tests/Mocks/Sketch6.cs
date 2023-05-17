namespace EnsureArg6.Tests.Mocks
{
	public class Sketch6
	{
		public virtual int Zero => 0;

		public virtual void CheckNotNull(object? notNullObject)
		{
			EnsureArg6.IsNotNull(notNullObject);
		}
	}
}
