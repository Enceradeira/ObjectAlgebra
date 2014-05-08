using System;

namespace ObjectAlgebra.VisitorPattern
{
	public interface IVisitor<T, TResult>
	{
		TResult VisitAdd(TResult left, TResult right);
		TResult VisitLit(Lit<T> lit);
	}
}