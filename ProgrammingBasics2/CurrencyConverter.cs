using System;

namespace CurrencyConverter {
	class Program {
		private static decimal USD = 1.79549m;
		private static decimal EUR = 1.95583m;
		private static decimal GBP = 2.53405m;

		public static int Main(string[] args)
		{
			var amount = decimal.Parse (Console.ReadLine ());
			var srcCurrency = Console.ReadLine ();
			var tgtCurrency = Console.ReadLine ();

			decimal toBGN;
			if (srcCurrency == "USD") {
				toBGN = amount * USD;
			} else if (srcCurrency == "EUR") {
				toBGN = amount * EUR;
			} else if (srcCurrency == "GBP") {
				toBGN = amount * GBP;
			} else {
				toBGN = amount;
			}

			decimal toCurrency;
			if (tgtCurrency == "USD") {
				toCurrency = toBGN / USD;
			} else if (tgtCurrency == "EUR") {
				toCurrency = toBGN / EUR;
			} else if (tgtCurrency == "GBP") {
				toCurrency = toBGN / GBP;
			} else {
				toCurrency = toBGN;
			}

			Console.WriteLine ("{0} {1}", Math.Round(toCurrency, 2), tgtCurrency);

			return 0;
		}
	}
}