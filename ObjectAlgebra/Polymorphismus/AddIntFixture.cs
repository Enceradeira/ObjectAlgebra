﻿using System;
using NUnit.Framework;

namespace ObjectAlgebra.Polymorphismus
{
	[TestFixture]
	public class AddIntFixture
	{
		[Test]
		public void Eval_ShouldAddTwoInteger()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var add = new AddInt(a, b);

			Assert.That(add.Eval(), Is.EqualTo(15));
		}

		[Test]
		public void Print_ShouldPrintAddExpression()
		{
			var a = new Lit(7);
			var b = new Lit(8);
			var add = new AddInt(a, b);

			Assert.That(add.Print(), Is.EqualTo("7+8"));
		}
	}
}