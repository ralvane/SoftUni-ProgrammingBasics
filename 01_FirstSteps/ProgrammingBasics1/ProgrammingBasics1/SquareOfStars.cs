using System;

namespace SquareOfStars
{
	class Program
	{
		static void Main1 (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());

			if (n >= 2)
			{
				var asterix = new string ('*', n);
				var space = new string (' ', n - 2);

				Console.WriteLine (asterix);
				for (int i = 0; i < n - 2; i++) {
					Console.WriteLine ('*' + space + '*');
				}
				Console.WriteLine (asterix);
			}
		}
	}
}