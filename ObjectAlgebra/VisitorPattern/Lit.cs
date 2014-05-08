using System;

namespace ObjectAlgebra.VisitorPattern
{
	public class Lit : IExp
	{
		private readonly int _value;

		public Lit(int value)
		{
			_value = value;
		}

		public int Value
		{
			get { return _value; }
		}

		public T Accept<T>(IVisitor<T> eval)
		{
			return eval.VisitLit(this);
		}
	}
}