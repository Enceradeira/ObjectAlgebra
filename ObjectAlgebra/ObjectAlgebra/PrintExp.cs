using System;

namespace ObjectAlgebra.ObjectAlgebra
{
	public class PrintExp : IExpFactory<IPrint>
	{
		public IPrint CreateLit(int n)
		{
			return new PrintLit(n);
		}

		public IPrint CreateAdd(IPrint left, IPrint right)
		{
			return new PrintAdd(left, right);
		}
	}
}