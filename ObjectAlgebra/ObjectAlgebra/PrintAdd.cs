using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class PrintAdd : IPrint
	{
		private readonly IPrint _left;

		private readonly IPrint _right;

		public PrintAdd(IPrint left, IPrint right)
		{
			_left = left;
			_right = right;
		}

		public string Print()
		{
			return string.Format("{0}+{1}", _left.Print(), _right.Print());
		}
	}
}