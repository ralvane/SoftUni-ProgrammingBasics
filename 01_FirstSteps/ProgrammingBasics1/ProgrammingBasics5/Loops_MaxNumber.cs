using System;

namespace Loops_MaxNumber {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			int result = -10000000, num = 0;
			if (n > 0) {
				for (int i = 0; i < n; i++) {
					num = int.Parse(Console.ReadLine());
					if (num > result)
						result = num;
				}
			}

			Console.WriteLine (result);

			return 0;
		}
	}
}