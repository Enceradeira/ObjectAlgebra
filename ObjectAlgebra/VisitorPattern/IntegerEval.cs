using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class IntegerEval : IVisitor<int, int>
	{
		public int VisitAdd(int left, int right)
		{
			return left + right;
		}

		public int VisitLit(Lit<int> lit)
		{
			return lit.Value;
		}
	}
}