using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableExchange.Model
{
    public class Exchange
    {
		private double priceKgVegetables;
		private double priceKgFruits;
		private int kgVegetables;
		private int kgFruits;
		public Exchange(double priceKgVegetables, double priceKgFruits, int kgVegetables, int kgFruits)
		{
			PriceKgVegetables = priceKgVegetables;
			PriceKgFruits = priceKgFruits;
			KgVegetables = kgVegetables;
			KgFruits = kgFruits;
		}

		public double PriceKgVegetables
		{
			get { return this.priceKgVegetables; }
			set { priceKgVegetables = value; }
		}
        public double PriceKgFruits
        {
            get { return this.priceKgFruits; }
            set { priceKgFruits= value; }
        }
		public int KgVegetables
		{
			get { return this.kgVegetables; }
			set { this.kgVegetables= value; }
		}
        public int KgFruits
        {
            get { return this.kgFruits; }
            set { this.kgFruits = value; }
        }

		public void Profit()
		{
			double sumFruits = 0;
			sumFruits = (PriceKgFruits * kgFruits);
			double sumVegetables = 0;
			sumVegetables = PriceKgVegetables * kgVegetables;
			Console.WriteLine($"{kgFruits} kg costs: {sumFruits:c2}");
			Console.WriteLine($"{kgVegetables} kg costs: {sumVegetables:c2}");
			double allSum = (sumVegetables + sumFruits) / 1.94;
			Math.Round(allSum,3);
			Console.WriteLine($"All sum in euro is: {allSum}");
		}
    }
}
