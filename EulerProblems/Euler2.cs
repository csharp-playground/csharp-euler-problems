using System;
using System.Collections.Generic;
using System.Linq;

using NUnit.Framework;

namespace EulerProblems
{
	[TestFixture]
	public class Euler2
	{
		[Test]
		public void TestCaseI()
		{
			var max = 4000000;
			var start = 1;
			var next = 1;
			var sum = 0;
			while (next < max) {
				if (next % 2 == 0)
					sum += next;
				var temp = start + next;
				start = next;
				next = temp;
			}
			Assert.AreEqual (4613732, sum);
		}
	}
}
