using Holiday.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.View
{
    public class Display
    {
        public HolidayPlan currentHoliday { get; set; }    
        public void InPutHoliday()
        {
            Console.WriteLine("Enter your budget");
            double budget=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter season");
            string season=Console.ReadLine();
            currentHoliday=new HolidayPlan(budget,season);
        }
        public void OutPutHoliday()
        {
            currentHoliday.OutPut();
        }


    }
}
