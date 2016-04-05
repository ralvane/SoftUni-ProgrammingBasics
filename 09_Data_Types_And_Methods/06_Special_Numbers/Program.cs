namespace _06_SpecialNumbers
{
	using System;

	class Program
	{
		public static void Main()
		{
			uint n = (uint)Math.Abs(int.Parse (Console.ReadLine ()));

			for (int i = 1; i <= n; ++i) {
				uint digitsSum = SumOfDigits ((uint)i);

				Console.WriteLine ($"{i} -> {IsSpecial (digitsSum)}");
			}
		}

		private static uint SumOfDigits(uint num)
		{
			uint sum = 0;
			while (num > 0) {
				sum += num % 10;
				num /= 10;
			}

			return sum;
		}

		private static bool IsSpecial(uint num)
		{
			return (num == 5) ||
				(num == 7) ||
				(num == 11);
		}
	}
}