using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (System.Console.ReadLine ());

		if (n < 2) {
			if (n == 1) {
				System.Console.WriteLine ('+');
				return 0;
			}
			return 1;
		}

		for (int row = 0; row < n; row++)
		{
			if (row == 0 || row == n - 1) {
				System.Console.Write ('+');
				for (int col = 0; col < n - 2; col++)
					System.Console.Write (" -");
				System.Console.Write (" +");
			}
			else {
				System.Console.Write ('|');
				for (int col = 0; col < n - 2; col++)
					System.Console.Write (" -");
				System.Console.Write (" |");
			}
			System.Console.WriteLine ();
		}

		return 0;
	}
}