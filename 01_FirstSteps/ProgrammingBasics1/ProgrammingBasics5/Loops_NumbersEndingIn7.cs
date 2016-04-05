using System;

namespace Loops_NumbersEndingIn7 {
	class Program {
		public static int Main(string[] args)
		{
			for (int i = 0; i <= 1000; i++) {
				if (i % 10 == 7)
					Console.WriteLine(i);
			}

			return 0;
		}
	}
}