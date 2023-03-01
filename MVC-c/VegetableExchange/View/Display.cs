using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegetableExchange.Model;

namespace VegetableExchange.View
{
    public class Display
    {
        public Exchange newExchange { get; set; }
        public void Input()
        {
            Console.WriteLine("Enter kilograms fruits");
            int kgFr=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter kilograms vegetables");
            int kgVeg=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price for kilogram fruits");
            double priceFr=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter price for kilogram vegetables");
            double priceVeg=double.Parse(Console.ReadLine());
            newExchange = new Exchange(priceVeg, priceFr, kgVeg, kgFr);
        }
        public void OutPutPrices()
        {
            newExchange.Profit();
        }
    }
}
