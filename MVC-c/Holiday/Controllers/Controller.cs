using Holiday.Model;
using Holiday.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holiday.Controller
{
    public class Controller
    {
        Display newDisplay = new Display();
        public HolidayPlan CurrentHoliday { get; set; }
        public Controller()
        {
            newDisplay.InPutHoliday();
            this.CurrentHoliday = newDisplay.currentHoliday;
            newDisplay.currentHoliday = this.CurrentHoliday;
            newDisplay.OutPutHoliday();
        }
    }
}
