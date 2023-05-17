using EnsureThat;

namespace EnsureArg6.Tests.Mocks
{
	public class Sketch
	{
		public virtual int Zero => 0;

		public virtual void CheckNotNull(string? notNullString)
		{
			EnsureArg.IsNotNull(notNullString);
		}

		public virtual void CheckNotNullWithNameof(string? notNullString)
		{
			EnsureArg.IsNotNull(notNullString, nameof(notNullString));
		}
	}
}
