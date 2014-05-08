using System;
using NUnit.Framework;

namespace ObjectAlgebra.Polymorphismus
{
	[TestFixture]
	public class AddIntFixture
	{
		[Test]
		public void Eval_ShouldAddToInteger()
		{
			var a = new Lit<int>(7);
			var b = new Lit<int>(8);
			var add = new AddInt(a, b);

			Assert.That(add.Eval(), Is.EqualTo(15));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit<int>(7);
			var b = new Lit<int>(8);
			var add = new AddInt(a, b);

			Assert.That(add.Print(), Is.EqualTo("7+8"));
		}
	}
}