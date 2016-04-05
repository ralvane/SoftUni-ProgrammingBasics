namespace _04_ExactSumOfRealNumbers
{
	using System;

	class Program
	{
		public static void Main()
		{
			uint n = uint.Parse (Console.ReadLine ());

			decimal result = 0m;
			for (int i = 1; i <= n; ++i) {
				result += decimal.Parse (Console.ReadLine ());
			}

			Console.WriteLine (result);
		}
	}
}