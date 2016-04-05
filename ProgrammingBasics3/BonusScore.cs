using System;

namespace BonusScore {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			double bonus = 0;
			if (n <= 100)
				bonus += 5;
			else if (n > 100 && n <= 1000)
				bonus += n * .2;
			else if (n > 1000)
				bonus += n * .1;

			if (n % 2 == 0)
				bonus++;
			if (n % 5 == 0 && n % 10 != 0)
				bonus += 2;

			Console.WriteLine ("Bonus score: {0}", bonus);
			Console.WriteLine ("Total score: {0}", n + bonus);

			return 0;
		}
	}
}