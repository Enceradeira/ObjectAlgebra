using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Print : IVisitor<string>
	{
		public string VisitAdd(string left, string right)
		{
			return string.Format("{0}+{1}", left, right);
		}

		public string VisitLit(Lit lit)
		{
			return lit.Value.ToString();
		}
	}
}