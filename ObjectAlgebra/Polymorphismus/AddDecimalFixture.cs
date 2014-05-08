using System;
using NUnit.Framework;

namespace ObjectAlgebra.Polymorphismus
{
	[TestFixture]
	public class AddDecimalFixture
	{
		[Test]
		public void Eval_ShouldAddToDecimal()
		{
			var a = new Lit<decimal>(7.5m);
			var b = new Lit<decimal>(2.1m);

			var add = new AddDecimal(a, b);

			Assert.That(add.Eval(), Is.EqualTo(9.6));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit<decimal>(7.5m);
			var b = new Lit<decimal>(2.1m);

			var add = new AddDecimal(a, b);
			Assert.That(add.Print(), Is.EqualTo("7.5+2.1"));
		}
	}
}