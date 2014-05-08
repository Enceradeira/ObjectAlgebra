using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class EvalExp : IExpFactory<IEval>
	{
		public IEval CreateLit(int n)
		{
			return new EvalLit(n);
		}

		public IEval CreateAdd(IEval left, IEval right)
		{
			return new EvalAdd(left, right);
		}

		public IEval CreateSub(IEval left, IEval right)
		{
			return new EvalSub(left, right);
		}
	}
}