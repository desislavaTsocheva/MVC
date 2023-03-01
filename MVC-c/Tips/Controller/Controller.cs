using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tips.Model;
using Tips.View;

namespace Tips.Controller
{
    public class Controller
    {
        Display myDisplay = new Display();
        private Tip newTip;
        public Controller()
        {
            myDisplay.ReadingData();
            Tip newTip = new Tip(myDisplay.Sum, myDisplay.Percent);
            myDisplay.TotalSum = newTip.CalculateAll();
            myDisplay.WritingData();
        }
    }
}
