namespace EnsureArgVI.Tests.Mocks
{
	public class Sketch6
	{
		public virtual int Zero => 0;

		public virtual void CheckNotNull(string? notNullString)
		{
			EnsureArg6.IsNotNull(notNullString);
		}
	}
}
