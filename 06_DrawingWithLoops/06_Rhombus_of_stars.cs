using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (System.Console.ReadLine ());

		if (n < 2) {
			if (n == 1) {
				System.Console.WriteLine ('*');
				return 0;
			}
			return 0;
		}

		int spaces = n - 1;
		int stars = 1;

		for (int row = 0; row < n; row++)
		{
			System.Console.Write (new String (' ', spaces));
			spaces--;
			for (int s = 0; s < stars; s++)
				System.Console.Write ("* ");
			stars++;
		
			System.Console.WriteLine ();
		}

		for (int row = n - 1; row > 0; row--)
		{
			System.Console.Write (new String (' ', spaces + 2));
			spaces++;
			for (int s = stars - 2; s > 0; s--)
				System.Console.Write ("* ");
			stars--;

			System.Console.WriteLine ();
		}

		return 0;
	}
}