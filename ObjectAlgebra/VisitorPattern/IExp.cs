using System;

namespace ObjectAlgebra.VisitorPattern
{
	public interface IExp<T>
	{
		TResult Accept<TResult>(IVisitor<T, TResult> visitor);
	}
}