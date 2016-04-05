using System;

class Program
{
	public static int Main(string[] args)
	{
		int n = int.Parse ( System.Console.ReadLine());

		for (int row = 0; row < n; row++)
		{
			System.Console.Write ('*');
			for (int col = 0; col < n - 1; col++)
				System.Console.Write(" *");
		
			System.Console.WriteLine();
		}
		
		return 0;
	}
}