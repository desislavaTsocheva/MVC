using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportPrice.Model;

namespace TransportPrice.View
{
    public class Display
    {
        public Transport CurrentTransport { get; set; }

        public void InPutData()
        {
            Console.WriteLine("Enter how much kilometers you'll travel?");
            int kilometers = int.Parse(Console.ReadLine());

            Console.WriteLine("During day or night you'll travel? ");
            string tariff = Console.ReadLine();

           CurrentTransport=new Transport(kilometers, tariff);
        }
        public void OutPutTheBestTransport()
        {
            CurrentTransport.OutPut();
        }
    }
}
