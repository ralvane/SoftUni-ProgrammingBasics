using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (Console.ReadLine ());

		int stars = n % 2 == 0 ? 2 : 1;
		int dashes = (int)Math.Ceiling (n / (float)2) - 1;
		int roof_rows = (int)Math.Ceiling (n / (float)2);
		int walls_rows = (int)Math.Floor (n / (float)2);

		for (int row = 0; row < roof_rows; row++)
		{
			Console.Write (new string ('-', dashes));
			Console.Write (new String ('*', stars));
			Console.Write (new string ('-', dashes));
			Console.WriteLine ();
			dashes--;
			stars += 2;
		}

		for (int row = 0; row < walls_rows; row++)
		{
			Console.WriteLine ('|' + new String('*', n - 2) + '|');
		}

		return 0;
	}
}