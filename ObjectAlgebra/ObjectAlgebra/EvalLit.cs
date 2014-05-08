using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class EvalLit : IEval
	{
		private readonly int _value;

		public EvalLit(int value)
		{
			_value = value;
		}

		public int Eval()
		{
			return _value;
		}
	}
}