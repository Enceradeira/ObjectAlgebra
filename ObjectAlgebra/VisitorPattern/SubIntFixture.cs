using System;
using NUnit.Framework;

namespace ObjectAlgebra.VisitorPattern
{
	[TestFixture]
	public class SubIntFixture
	{
		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var sub = new Sub(a, b);

			Assert.That(sub.Accept(new IntegerEval()), Is.EqualTo(-1));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var sub = new Sub(a, b);

			Assert.That(sub.Accept(new Print()), Is.EqualTo("7-8"));
		}
	}
}