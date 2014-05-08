using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class EvalSub : IEval
	{
		private readonly IEval _left;

		private readonly IEval _right;

		public EvalSub(IEval left, IEval right)
		{
			_left = left;
			_right = right;
		}

		public int Eval()
		{
			return _left.Eval() - _right.Eval();
		}
	}
}