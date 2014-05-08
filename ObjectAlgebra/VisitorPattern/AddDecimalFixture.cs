using System;
using NUnit.Framework;

namespace ObjectAlgebra.VisitorPattern
{
	[TestFixture]
	public class AddDecimalFixture
	{
		[Test]
		public void Eval_ShouldAddTwoDecimal()
		{
			var a = new Lit<decimal>(7.5m);
			var b = new Lit<decimal>(2.1m);

			var add = new Add<decimal>(a, b);

			Assert.That(add.Accept(new DecimalEval()), Is.EqualTo(9.6));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit<decimal>(7.5m);
			var b = new Lit<decimal>(2.1m);

			var add = new Add<decimal>(a, b);
			Assert.That(add.Accept(new Print<decimal>()), Is.EqualTo("7.5+2.1"));
		}
	}
}