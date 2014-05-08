using System;
using NUnit.Framework;

namespace ObjectAlgebra.ObjectAlgebra
{
	[TestFixture]
	public class SubIntFixture
	{
		private static T Sub7To8<T>(IExpFactory<T> printExp)
		{
			var a = printExp.CreateLit(7);
			var b = printExp.CreateLit(8);
			var add = printExp.CreateSub(a, b);
			return add;
		}

		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var sub = Sub7To8(new EvalExp());
			Assert.That(sub.Eval(), Is.EqualTo(-1));
		}

		[Test]
		public void Print_ShouldPrintExpression()
		{
			var sub = Sub7To8(new PrintExp());
			Assert.That(sub.Print(), Is.EqualTo("7-8"));
		}
	}
}