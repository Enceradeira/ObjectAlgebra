using System;

namespace ObjectAlgebra.Polymorphismus
{
	public interface IExp<out T>
	{
		T Eval();
		string Print();
	}
}