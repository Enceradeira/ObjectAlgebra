using System;

namespace ObjectAlgebra.Polymorphismus
{
	public class Lit<T> : IExp<T>
	{
		private readonly T _value;

		public Lit(T value)
		{
			_value = value;
		}

		public T Eval()
		{
			return _value;
		}

		public string Print()
		{
			return _value.ToString();
		}
	}
}