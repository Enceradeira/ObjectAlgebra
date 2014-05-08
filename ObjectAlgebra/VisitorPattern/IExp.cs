using System;

namespace ObjectAlgebra.VisitorPattern
{
	public interface IExp
	{
		T Accept<T>(IVisitor<T> visitor);
	}
}