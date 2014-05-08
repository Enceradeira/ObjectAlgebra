using System;

namespace ObjectAlgebra.PolymorphismusPattern
{
	public interface IExp<out T>
	{
		T Eval();
		string Print();
	}
}