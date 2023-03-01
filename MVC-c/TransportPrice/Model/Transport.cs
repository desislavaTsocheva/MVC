using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice.Model
{
    public class Transport
    {
        public Transport(int kilometers, string tariff)
        {
            Kilometers = kilometers;
            Tariff = tariff;

        } 
        private int kilometers;

		public int Kilometers
		{
			get { return kilometers; }
			set { kilometers = value; }
		}

		private string tariff;

		public string Tariff
		{
			get { return tariff; }
			set { tariff = value; }
		}

        public void OutPut()
        {
            double finalPrice = 0;

            if (kilometers < 20 && tariff == "day")
            {
                finalPrice = 0.70 + kilometers * 0.79;
                Console.WriteLine($"It's the best to travel with taxi and" +
                    $" the finall price will be: {finalPrice:c2}");
            }
            if (kilometers < 20 && tariff == "night")
            {
                finalPrice = 0.70 + kilometers * 0.90;
                Console.WriteLine($"It's the best to travel with taxi and" +
                    $" the finall price will be: {finalPrice:c2}");
            }
            if (kilometers >= 20 && kilometers < 100)
            {
                finalPrice = kilometers * 0.09;
                Console.WriteLine($"It's the best to travel with bus and" +
                    $" the finall price will be: {finalPrice:c2}");
            }
            if (kilometers > 100)
            {
                finalPrice = kilometers * 0.06;
                Console.WriteLine($"It's the best to travel with train and" +
                    $" the finall price will be: {finalPrice:c2}",2);
            }
        }
	}
}
