using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogramm.Model
{
    public class Numbers
    {
        private List<int>numbers=new List<int>();
        public Numbers(List<int> numbers)
        {
            this.numbers = numbers;
        }
        int countUnder200, count399 = 0, count599 = 0, count799, count800Up = 0;
        public void Counters()
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 200) { countUnder200++; }
                if (numbers[i] >= 200 && numbers[i] <= 399) { count399++; }
                if (numbers[i] >= 400 && numbers[i] <= 599) { count599++; }
                if (numbers[i] >= 600 && numbers[i] <= 799) { count799++; }
                if (numbers[i] >= 800) { count800Up++; }
            }
        }
        public void OutPutPercent()
        {
            double p1 = countUnder200 / 20 * 100;
            double p2 = count399 / 20 * 100;
            double p3 = count599 / 20 * 100;
            double p4 = count799 / 20 * 100;
            double p5 = count800Up / 20 * 100;
            Console.WriteLine($" percent numbers under 200 is:{p1}% ");
            Console.WriteLine($" percent numbers under 399 is:{p2}% ");
            Console.WriteLine($" percent numbers under 599 is:{p3}% ");
            Console.WriteLine($" percent numbers under 799 is:{p4}% ");
            Console.WriteLine($" percent numbers under 800 is:{p5}% ");
        }
    }
}
