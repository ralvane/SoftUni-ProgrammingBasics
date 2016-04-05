using System;

namespace Loops_VowelsSum {
	class Program {
		public static int Main(string[] args)
		{
			var s = Console.ReadLine();
			int s_len = s.Length;

			int _sum = 0;
			for (int i = 0; i < s_len; i++) {
				if (s [i] == 'a')
					_sum++;
				else if (s [i] == 'e')
					_sum += 2;
				else if (s [i] == 'i')
					_sum += 3;
				else if (s [i] == 'o')
					_sum += 4;
				else if (s [i] == 'u')
					_sum += 5;
			}

			Console.WriteLine (_sum);

			return 0;
		}
	}
}