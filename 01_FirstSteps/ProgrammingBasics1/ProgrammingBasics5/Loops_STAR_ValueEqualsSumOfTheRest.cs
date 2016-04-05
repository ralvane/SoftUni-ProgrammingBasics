using System;

namespace Loops_Star1 {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			int max_val = int.MinValue, val = 0, sum_vals = 0;
			for (int i = 0; i < n; i++) {
				val = int.Parse (Console.ReadLine ());

				if (val > max_val)
					max_val = val;

				sum_vals += val;
			}

			if (sum_vals == 0)
				Console.WriteLine ("Yes sum = 0");
			else if (sum_vals - max_val == max_val)
				Console.WriteLine ("Yes sum = " + max_val);
			else
				Console.WriteLine ("No diff = " + Math.Abs((max_val - (sum_vals - max_val))));

			return 0;
		}
	}
}