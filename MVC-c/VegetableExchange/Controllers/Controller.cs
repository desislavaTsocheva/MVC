using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableExchange.Model;
using VegetableExchange.View;

namespace VegetableExchange.Controllers
{
    public class Controller
    {
        Display newDisplay = new Display();
        public Exchange newExchange { get; set; }
        public Controller()
        {
            newDisplay.Input();
            this.newExchange = newDisplay.newExchange;
            newDisplay.newExchange = this.newExchange;
            newDisplay.OutPutPrices();
        }
    }
}
