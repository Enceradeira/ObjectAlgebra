using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public interface IExpFactory<T>
	{
		T CreateLit(int n);
		T CreateAdd(T left, T right);
		T CreateSub(T left, T right);
	}
}