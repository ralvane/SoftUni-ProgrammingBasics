using System;

class Program {
	public static int Main(string[] args)
	{
		int n = int.Parse( System.Console.ReadLine() );

		for (var i = 0; i < n; i++)
			System.Console.WriteLine (new String ('*', n));
		return 0;
	}
}