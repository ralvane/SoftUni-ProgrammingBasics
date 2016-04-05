using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (System.Console.ReadLine ());

		System.Console.WriteLine (new String ('*', 2 * n) + new string (' ', n) + new string ('*', 2 * n));
		for (int row = 0; row < n - 2; row++)
		{
			Console.Write ('*');
			Console.Write (new String('/', n + n - 2));
			Console.Write ('*');
			//if ( n == 3 && row == 0 || row == n - 4 )
			if ( row == Math.Floor( (n - 3) / (float)2 ) )
				Console.Write (new String ('|', n));
			else
				Console.Write (new String (' ', n));
			Console.Write ('*');
			Console.Write (new String ('/', n + n - 2));
			Console.Write ('*');

			Console.WriteLine();
		}
		System.Console.WriteLine (new String ('*', 2 * n) + new string (' ', n) + new string ('*', 2 * n));

		return 0;
	}
}