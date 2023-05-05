using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace EnsureArgVI
{
	public static class EnsureArgFluent
	{
		/// <summary>
		/// Returns an <see cref="NumericAssure{T}"/> object that can be used to assert the
		/// current <see cref="int"/><paramref name="value"/>>.
		/// </summary>
		[Pure]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int32Assure Arg(
			this int? value,
			[CallerArgumentExpression("value")] string paramName = "")
		{
			return new Int32Assure(value, paramName);
		}
	}

	public readonly struct Int32Assure
	{
		private readonly int? _value;
		private readonly string _paramName;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Int32Assure(int? value, string paramName)
		{
			_value = value;
			_paramName = paramName;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int IsNotNull()
		{
			if (_value is null)
			{
				throw new ArgumentNullException(_paramName, "Value can not be null.");
			}

			return _value.Value;
		}
	}
}
