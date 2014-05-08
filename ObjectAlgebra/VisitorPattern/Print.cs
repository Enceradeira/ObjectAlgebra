using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Print<T> : IVisitor<T, string>
	{
		public string VisitAdd(string left, string right)
		{
			return string.Format("{0}+{1}", left, right);
		}

		public string VisitLit(Lit<T> lit)
		{
			return lit.Value.ToString();
		}
	}
}