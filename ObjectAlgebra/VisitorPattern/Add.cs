using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Add<T> : IExp<T>
	{
		private readonly Lit<T> _left;

		private readonly Lit<T> _right;

		public Add(Lit<T> left, Lit<T> right)
		{
			_left = left;
			_right = right;
		}

		public TResult Accept<TResult>(IVisitor<T, TResult> visitor)
		{
			return visitor.VisitAdd(_left.Accept(visitor), _right.Accept(visitor));
		}
	}
}