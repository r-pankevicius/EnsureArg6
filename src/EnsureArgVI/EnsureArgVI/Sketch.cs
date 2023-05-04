using EnsureThat;

namespace EnsureArgVI
{
	public class Sketch
	{
		public int Zero => 0;

		public void CheckNotNull(string? value)
		{
			EnsureArg.IsNotNull(value);
		}

		public void CheckNotNullWithNameof(string? value)
		{
			EnsureArg.IsNotNull(value, nameof(value));
		}
	}
}
