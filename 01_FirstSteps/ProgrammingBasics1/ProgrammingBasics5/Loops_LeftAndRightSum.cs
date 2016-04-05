using System;
	namespace Loops_LeftAndRightSum {
		class Program {
			public static int Main(string[] args) {
				int n = int.Parse (Console.ReadLine ());

				int sum1 = 0, sum2 = 0;
				for (int i = 0; i < n; i++) {
					sum1 += int.Parse (Console.ReadLine ());
				}
				for (int i = 0; i < n; i++) {
					sum2 += int.Parse (Console.ReadLine ());
				}

				if (sum1 == sum2)
					Console.WriteLine ("Yes sum " + sum1);
				else
					Console.WriteLine ("No diff " + Math.Abs(sum1 - sum2));

				return 0;
			}
		}
	}