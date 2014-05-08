using System;
using NUnit.Framework;

namespace ObjectAlgebra.ObjectAlgebra
{
	[TestFixture]
	public class AddIntFixture
	{
		private static T Add7To8<T>(IExpFactory<T> printExp)
		{
			var a = printExp.CreateLit(7);
			var b = printExp.CreateLit(8);
			var add = printExp.CreateAdd(a, b);
			return add;
		}

		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var add = Add7To8(new EvalExp());
			Assert.That(add.Eval(), Is.EqualTo(15));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var add = Add7To8(new PrintExp());
			Assert.That(add.Print(), Is.EqualTo("7+8"));
		}
	}
}