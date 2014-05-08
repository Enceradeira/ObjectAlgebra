using System;

namespace ObjectAlgebra.Polymorphismus
{
	public class AddInt : IExp
	{
		private readonly Lit _left;

		private readonly Lit _right;

		public AddInt(Lit left, Lit right)
		{
			_left = left;
			_right = right;
		}

		public int Eval()
		{
			return _left.Eval() + _right.Eval();
		}

		public string Print()
		{
			return string.Format("{0}+{1}", _left.Print(), _right.Print());
		}
	}
}