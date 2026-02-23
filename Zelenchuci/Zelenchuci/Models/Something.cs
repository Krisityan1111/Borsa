using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchuci.Models
{
    public class Something
    {
        public double zPrice;
        public double pPrice;
        public double zKg;
        public double pKg;

        public double ZPrice
        {
            get { return zPrice; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                zPrice = value;
            }
        }

        public double PPrice
        {
            get { return pPrice; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                pPrice = value;
            }
        }

        public double ZKg
        {
            get { return zKg; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                zKg = value;
            }
        }

        public double PKg
        {
            get { return pKg; }
            set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                pKg = value;
            }
        }

        public Something(double zPrice,  double pPrice, double zKg, double pKg)
        {
            ZPrice = zPrice;
            PPrice = pPrice;
            ZKg = zKg;
            PKg = pKg;
        }

        public Something() : this(0, 0, 0, 0) { }

        public double Calculate()
        {
            return ZPrice * ZKg + PPrice * PKg;
        }
    }
}
