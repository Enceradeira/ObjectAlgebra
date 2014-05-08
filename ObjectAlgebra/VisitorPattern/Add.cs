using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Add : IExp
	{
		private readonly Lit _left;

		private readonly Lit _right;

		public Add(Lit left, Lit right)
		{
			_left = left;
			_right = right;
		}

		public T Accept<T>(IVisitor<T> visitor)
		{
			return visitor.VisitAdd(_left.Accept(visitor), _right.Accept(visitor));
		}
	}
}