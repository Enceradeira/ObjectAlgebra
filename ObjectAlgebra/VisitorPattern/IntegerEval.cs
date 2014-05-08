using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class IntegerEval : IVisitor<int>
	{
		public int VisitAdd(int left, int right)
		{
			return left + right;
		}

		public int VisitLit(Lit lit)
		{
			return lit.Value;
		}
	}
}