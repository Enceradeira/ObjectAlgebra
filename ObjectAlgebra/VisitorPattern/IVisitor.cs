using System;

namespace ObjectAlgebra.VisitorPattern
{
	public interface IVisitor<T>
	{
		T VisitAdd(T left, T right);
		T VisitLit(Lit lit);
		T VisitSub(T left, T right);
	}
}