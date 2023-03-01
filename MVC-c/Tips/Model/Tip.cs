using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tips.Model
{
    public class Tip
    {
        private double sumOrder;
        private double percent;
        public Tip(double sumOrder, double percent)
        {
            SumOrder = sumOrder;
            Percent = percent;
        }

        public double SumOrder
        {
            get { return this.sumOrder; }
            set { this.sumOrder = value; }
        }
        public double Percent
        {
            get { return this.percent; }
            set { this.percent = value; }
        }

        public double CalculateAll()
        {
            return sumOrder+Percent*SumOrder;
        }
    }
}
