using Histogramm.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogramm.View
{
    public class Display
    {
        public List<Numbers> nums = new List<Numbers>();
        public void InPutNumbers(int num)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine("Enter number");
                num=int.Parse(nums[i].ToString());
            }  
        }
       
    }
}
