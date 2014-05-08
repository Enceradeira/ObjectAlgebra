using System;

namespace ObjectAlgebra.Polymorphismus
{
	public class AddInt: IExp<int>
	{
		private readonly Lit<int> _left;

		private readonly Lit<int> _right;

		public AddInt(Lit<int> left, Lit<int> right)
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