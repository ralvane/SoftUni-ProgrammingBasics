using System;

namespace BonusScore_v2 {
	class Program {
		public static int Main (string[] args)
		{
			Console.Write ("Enter score: ");
			int n = int.Parse (Console.ReadLine ());

			int bonus = 0;
			if (n <= 100)
				bonus = 5;
			else if (n > 100 && n <= 1000)
				bonus = (int)(Math.Floor(n * 0.2));
			else if (n > 1000)
				bonus = (int)(n * Math.Floor(.1));

			if (n % 2 == 0)
				bonus++;
			if (n % 5 == 0)
				bonus += 2;

			Console.WriteLine ("Bonus score: {0}", bonus);
			Console.WriteLine ("Total score: {0}", n + bonus);

			return 0;
		}
	}
}