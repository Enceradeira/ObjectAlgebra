using System;
using NUnit.Framework;

namespace ObjectAlgebra.VisitorPattern
{
	[TestFixture]
	public class AddIntFixture
	{
		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var a = new Lit<int>(7);
			var b = new Lit<int>(8);
			var add = new Add<int>(a, b);

			Assert.That(add.Accept(new IntegerEval()), Is.EqualTo(15));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit<int>(7);
			var b = new Lit<int>(8);
			var add = new Add<int>(a, b);

			Assert.That(add.Accept(new Print<int>()), Is.EqualTo("7+8"));
		}
	}
}