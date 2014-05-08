using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class DecimalEval : IVisitor<decimal, decimal>
	{
		public decimal VisitAdd(decimal left, decimal right)
		{
			return left + right;
		}

		public decimal VisitLit(Lit<decimal> lit)
		{
			return lit.Value;
		}
	}
}