using System;

namespace euler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			var e = new EulerFuncs ();
			//Console.WriteLine (e.FindPrimeNumbers(775146));

			var numbers = e.FindPrimeNumbers ((long) Math.Sqrt(600851475143));
			numbers.Reverse ();
			Console.WriteLine ("Looking for answers");
			Console.WriteLine (e.Search31(600851475143, numbers, new System.Collections.Generic.List<long>()));
		}

	}
}
