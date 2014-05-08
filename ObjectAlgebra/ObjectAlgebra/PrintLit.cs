using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class PrintLit : IPrint
	{
		private readonly int _value;

		public PrintLit(int value)
		{
			_value = value;
		}

		public string Print()
		{
			return _value.ToString();
		}
	}
}