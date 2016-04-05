using System;

namespace NumbersToStrings {
	class Program {
		public static int Main(string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			if (n < 0 || n > 100) {
				Console.WriteLine ("invalid number");
				return 1;
			}

			string s;
			if (n / 10 == 2)
				s = "twenty";
			else if (n / 10 == 3)
				s = "thirty";
			else if (n / 10 == 4)
				s = "fourty";
			else if (n / 10 == 5)
				s = "fifty";
			else if (n / 10 == 6)
				s = "sixty";
			else if (n / 10 == 7)
				s = "seventy";
			else if (n / 10 == 8)
				s = "eighty";
			else if (n / 10 == 9)
				s = "ninety";
			else
				s = "";

			if ((n >= 21 && n <= 29) ||
			    (n >= 31 && n <= 39) ||
			    (n >= 41 && n <= 49) ||
			    (n >= 51 && n <= 59) ||
			    (n >= 61 && n <= 69) ||
			    (n >= 71 && n <= 79) ||
			    (n >= 81 && n <= 89) ||
			    (n >= 91 && n <= 99))
				s += " ";

			if (n == 10)
				s = "ten";
			else if (n == 11)
				s = "eleven";
			else if (n == 12)
				s = "twelve";
			else if (n == 13)
				s = "thirteen";
			else if (n == 14)
				s = "fourteen";
			else if (n == 15)
				s = "fifteen";
			else if (n == 16)
				s = "sixteen";
			else if (n == 17)
				s = "seventeen";
			else if (n == 18)
				s = "eighteen";
			else if (n == 19)
				s = "nineteen";
			else if (n == 0)
				s = "zero";
			else if (n % 10 == 1)
				s += "one";
			else if (n % 10 == 2)
				s += "two";
			else if (n % 10 == 3)
				s += "three";
			else if (n % 10 == 4)
				s += "four";
			else if (n % 10 == 5)
				s += "five";
			else if (n % 10 == 6)
				s += "six";
			else if (n % 10 == 7)
				s += "seven";
			else if (n % 10 == 8)
				s += "eight";
			else if (n % 10 == 9)
				s += "nine";

			if (n == 100)
				s = "one hundred";

			Console.WriteLine (s);

			return 0;
		}
	}
}