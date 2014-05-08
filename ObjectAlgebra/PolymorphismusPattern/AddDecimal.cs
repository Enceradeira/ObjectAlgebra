using System;

namespace ObjectAlgebra.PolymorphismusPattern
{
	public class AddDecimal : IExp<decimal>
	{
		private readonly Lit<decimal> _left;

		private readonly Lit<decimal> _right;

		public AddDecimal(Lit<decimal> left, Lit<decimal> right)
		{
			_left = left;
			_right = right;
		}

		public decimal Eval()
		{
			return _left.Eval() + _right.Eval();
		}

		public string Print()
		{
			return string.Format("{0}+{1}", _left.Print(), _right.Print());
		}
	}
}