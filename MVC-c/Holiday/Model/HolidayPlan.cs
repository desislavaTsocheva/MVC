using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.Model
{
    public class HolidayPlan
    {
		private double budget;
		private string season;

		public  string Season
		{
			get { return season; }
			set { season = value; }
		}
		public HolidayPlan(double budget, string season)
		{
			Budget = budget;
			Season = season;
		}

		public double Budget
		{
			get { return budget; }
			set { budget = value; }
		}

		public void OutPut()
		{
			if (budget <= 100&&season=="summer")
			{
				Console.WriteLine("Somewhere in Bulgariya");
				Console.WriteLine($"camp- {budget*3/10:c2}");
			}
            if (budget <= 100 && season == "winter")
            {
                Console.WriteLine("Somewhere in Bulgariya");
                Console.WriteLine($"hotel- {budget * 7 / 10:c2}");
            }
            if (budget >100&&budget<= 1000 && season == "summer")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"camp- {budget * 4 / 10:c2}");
            }
            if (budget <= 1000 && season == "winter")
            {
                Console.WriteLine("Somewhere in Balkans");
                Console.WriteLine($"camp- {budget * 8 / 10:c2}");
            }
            if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"camp- {budget * 9 / 10:c2}");
            }
        }
	}
}
