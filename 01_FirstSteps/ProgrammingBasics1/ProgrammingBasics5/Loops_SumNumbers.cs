using System;

namespace Loops_SumNumbers {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			var _sum = 0;
			int num;
			for (int i = 0; i < n; i++) {
				num = int.Parse (Console.ReadLine ());
				_sum += num;
			}

			Console.WriteLine(_sum);

			return 0;
		}
	}
}