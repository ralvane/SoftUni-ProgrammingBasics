using System;

namespace TradeCommissions {
	class Program {
		public static int Main( string[] args )
		{
			var city = Console.ReadLine ().ToLower ();
			double sales = double.Parse (Console.ReadLine ());
			double commission = .0;
			bool ERROR = false;

			if (sales >= 0 && sales <= 500) {
				if (city == "sofia")
					commission = sales * 0.05;
				else if (city == "varna")
					commission = sales * 0.045;
				else if (city == "plovdiv")
					commission = sales * 0.055;
				else
					ERROR = true;
			} else if (sales > 500 && sales <= 1000) {
				if (city == "sofia")
					commission = sales * 0.07;
				else if (city == "varna")
					commission = sales * 0.075;
				else if (city == "plovdiv")
					commission = sales * 0.08;
				else
					ERROR = true;
			} else if (sales > 1000 && sales <= 10000) {
				if (city == "sofia")
					commission = sales * 0.08;
				else if (city == "varna")
					commission = sales * 0.1;
				else if (city == "plovdiv")
					commission = sales * 0.12;
				else
					ERROR = true;
			} else if (sales > 10000) {
				if (city == "sofia")
					commission = sales * 0.12;
				else if (city == "varna")
					commission = sales * 0.13;
				else if (city == "plovdiv")
					commission = sales * 0.145;
				else
					ERROR = true;
			} else
				ERROR = true;
			
			if (!ERROR)
				Console.WriteLine ("{0:f2}", commission);
			else
				Console.WriteLine ("error");

			return 0;
		}
	}
}