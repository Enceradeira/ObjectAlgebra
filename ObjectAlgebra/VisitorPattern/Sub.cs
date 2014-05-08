using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Sub : IExp
	{
		private readonly Lit _left;

		private readonly Lit _right;

		public Sub(Lit left, Lit right)
		{
			_left = left;
			_right = right;
		}

		public T Accept<T>(IVisitor<T> visitor)
		{
			return visitor.VisitSub(_left.Accept(visitor), _right.Accept(visitor));
		}
	}
}