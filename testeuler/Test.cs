using NUnit.Framework;
using System;
using System.Collections.Generic;

using euler;

namespace testeuler
{
	[TestFixture ()]
	public class Test
	{
		private EulerFuncs ef = new EulerFuncs();

		[Test ()]
		public void TestFindSum ()
		{
			Assert.AreEqual (23, ef.FindSum (10));
		}

		[Test ()]
		public void TestFibonacci() {
			//1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
			Assert.AreEqual(1, ef.Fibonacci(1));
			Assert.AreEqual(2, ef.Fibonacci(2));
			Assert.AreEqual(3, ef.Fibonacci(3));
			Assert.AreEqual(5, ef.Fibonacci(4));
			Assert.AreEqual(8, ef.Fibonacci(5));
			Assert.AreEqual(13, ef.Fibonacci(6));
			Assert.AreEqual(21, ef.Fibonacci(7));
			Assert.AreEqual(34, ef.Fibonacci(8));
			Assert.AreEqual(55, ef.Fibonacci(9));
			Assert.AreEqual (89, ef.Fibonacci (10));
			Assert.Less(4000000, ef.Fibonacci(600));
		}

		[Test ()]
		public void TestProblem3() {
			Assert.AreEqual (29, ef.FindAnswer3 (13195));
			//Assert.AreEqual (13, ef.FindAnswer3 (39));
		}

		[Test ()]
		public void TestFindPrimeNumbers() {
			var expected = new List<uint> ();
			expected.Add (1);
			expected.Add (2);
			expected.Add (3);
			expected.Add (5);
			expected.Add (7);
			CollectionAssert.AreEqual (expected, ef.FindPrimeNumbers (10));

		}
	}
}

