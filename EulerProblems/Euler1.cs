using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EulerProblems
{
	[TestFixture ()]
	public class Euler1
	{
		[Test ()]
		public void TestCaseI ()
		{
			// brute force
			var ranges = Enumerable.Range (0, 1000);
			var sum = ranges.Where (x => x % 3 == 0 || x % 5 == 0).Sum ();

			Assert.AreEqual(999, ranges.Last ());
			Assert.AreEqual (233168, sum);
		}

		[Test()]
		public void TestCaseII() {
			// arithmetical sequence
			var n = 999;
			var n3 = n / 3;
			var n5 = n / 5;
			var n15 = n / 15;

			var rs = (3 * n3 * (n3 + 1)) / 2
				+ (5 * n5 * (n5 + 1)) / 2
				- (15 * n15 * (n15 + 1)) / 2;

			Assert.AreEqual(233168, rs);
		}
	}
}
