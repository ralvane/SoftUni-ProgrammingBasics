using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (Console.ReadLine ());

		for (int row = 0; row < n + 1; row++)
		{
			Console.Write (new String (' ', n - row));
			Console.Write (new String ('*', row));
			Console.Write (" | ");
			Console.Write (new String ('*', row));
			Console.WriteLine (new String (' ', n - row));
		}

		return 0;
	}
}