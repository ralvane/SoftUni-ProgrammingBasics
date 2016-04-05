using System;

namespace Loops_MinNumber {
	class Program {
		public static int Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			int result = 0, num = 0;
			if (n > 0) {
				result = int.Parse (Console.ReadLine ());
				for (int i = 1; i < n; i++) {
					num = int.Parse (Console.ReadLine ());
					if (result > num)
						result = num;
				}
			}

			Console.WriteLine (result);

			return 0;
		}
	}
}