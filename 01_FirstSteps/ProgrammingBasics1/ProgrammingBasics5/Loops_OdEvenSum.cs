using System;

namespace Loops_OddEvenSum {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			int sum_odd = 0, sum_even = 0;
			for (int i = 1; i <= n; i++) {
				if (i % 2 == 0)
					sum_even += int.Parse (Console.ReadLine ());
				else
					sum_odd += int.Parse (Console.ReadLine ());
			}

			if (sum_odd == sum_even)
				Console.WriteLine ("Yes Sum = " + sum_odd);
			else
				Console.WriteLine ("No diff = " + Math.Abs(sum_odd - sum_even));

			return 0;
		}
	}
}