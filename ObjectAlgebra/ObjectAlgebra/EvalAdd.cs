using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class EvalAdd : IEval
	{
		private readonly IEval _left;

		private readonly IEval _right;

		public EvalAdd(IEval left, IEval right)
		{
			_left = left;
			_right = right;
		}

		public int Eval()
		{
			return _left.Eval() + _right.Eval();
		}
	}
}