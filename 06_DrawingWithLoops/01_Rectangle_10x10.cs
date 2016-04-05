using System;

class Program {
	public static int Main(string[] args)
	{
		int n = 10;

		for (var i = 0; i < n; i++)
			System.Console.WriteLine (new String ('*', n));
		return 0;
	}
}