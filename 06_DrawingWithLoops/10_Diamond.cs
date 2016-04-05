using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse (Console.ReadLine ());
		int upperRows = n % 2 == 0 ? n / 2 : (int)Math.Ceiling(n / (float)2);
		int lowerRows = n - upperRows;
		int cols = n;
		int outerDashes = (int)Math.Floor ((n - 1) / (float)2);
			
		Console.Write( new String('-', outerDashes) );
		Console.Write( new String('*', n % 2 == 0 ? 2 : 1) );
		Console.Write( new String('-', outerDashes) );
		Console.WriteLine ();

		outerDashes--;
		for (int row = 1; row < upperRows; row++)
		{
			Console.Write (new String ('-', outerDashes));
			Console.Write ('*');
			Console.Write ( new String('-', cols - 2 * outerDashes - 2) );
			Console.Write ('*');
			Console.Write (new String ('-', outerDashes));
			Console.WriteLine ();
			outerDashes--;
		}

		if (n > 2)
		{
			outerDashes = 1;
			for (int row = lowerRows; row > 1; row--)
			{
				Console.Write (new String ('-', outerDashes));
				Console.Write ('*');
				Console.Write (new String ('-', cols - 2 * outerDashes > 0 ? cols - 2 * outerDashes - 2 : 0));
				Console.Write ('*');
				Console.Write (new String ('-', outerDashes));
				Console.WriteLine ();
				outerDashes++;
			}

			if (n % 2 != 0)
			{
				Console.Write (new String ('-', (int)Math.Floor ((n - 1) / (float)2)));
				Console.Write (new String ('*', n % 2 == 0 ? 2 : 1));
				Console.Write (new String ('-', (int)Math.Floor ((n - 1) / (float)2)));
			}
		}
		return 0;
	}
}