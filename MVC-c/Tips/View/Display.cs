using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tips.Model;

namespace Tips.View
{
    public class Display
    {
        public double Sum { get; set; }
        public double Percent { get; set; }
        public double TotalSum { get; set; }
        
        public void ReadingData()
        {
            Console.WriteLine("Enter sum:");
            Sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter percent:");
            Percent = double.Parse(Console.ReadLine());
        }
      public void WritingData()
      {
            Console.WriteLine($"The total sum is :{TotalSum:c2}");
      }
    }
}
