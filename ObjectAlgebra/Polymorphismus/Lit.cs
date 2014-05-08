using System;

namespace ObjectAlgebra.Polymorphismus
{
	public class Lit : IExp
	{
		private readonly int _value;

		public Lit(int value)
		{
			_value = value;
		}

		public int Eval()
		{
			return _value;
		}

		public string Print()
		{
			return _value.ToString();
		}
	}
}