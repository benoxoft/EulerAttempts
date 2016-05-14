using System;

namespace euler
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			var e = new EulerFuncs ();
			Console.WriteLine (e.FindPrimeNumbers(600851475143));

			//Console.WriteLine (e.FindAnswer3(600851475143));
		}

	}
}
