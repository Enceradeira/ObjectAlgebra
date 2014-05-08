using System;
using NUnit.Framework;

namespace ObjectAlgebra.Polymorphismus
{
	[TestFixture]
	public class SubIntFixture
	{
		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var sub = new SubInt(a, b);

			Assert.That(sub.Eval(), Is.EqualTo(-1));
		}

		[Test]
		public void Print_ShouldPrintExpression()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var sub = new SubInt(a, b);

			Assert.That(sub.Print(), Is.EqualTo("7-8"));
		}
	}
}