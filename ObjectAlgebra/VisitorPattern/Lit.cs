using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Lit<T> : IExp<T>
	{
		private readonly T _value;

		public Lit(T value)
		{
			_value = value;
		}

		public T Value
		{
			get { return _value; }
		}

		public TResult Accept<TResult>(IVisitor<T, TResult> eval)
		{
			return eval.VisitLit(this);
		}
	}
}