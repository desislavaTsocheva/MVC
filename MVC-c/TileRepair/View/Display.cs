using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileRepair.Model;

namespace TileRepair.View
{
    public class Display
    {
       public Repair currentRepair { get;set; }
        public void InPut()
        {
            Console.WriteLine("Еnter playground area");
            int area=int.Parse(Console.ReadLine());
            Console.WriteLine("Еnter tile width");
            int tileWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Еnter tile lenght");
            int tileLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Еnter bench width");
            int benchWidth = int.Parse(Console.ReadLine());
            Console.WriteLine("Еnter bench lenght");
            int benchLength=int.Parse(Console.ReadLine());
            currentRepair = new Repair(area, tileWidth, tileLength, benchWidth, benchLength);

        } 
        public void OutPut()
        {
            currentRepair.OutPutInfo();
        }
    }
}
