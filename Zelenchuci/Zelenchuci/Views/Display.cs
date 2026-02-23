using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchuci.Views
{
    public class Display
    {
        public double zPrice;
        public double pPrice;
        public double zKg;
        public double pKg;
        public double result;

        public Display()
        {
            zPrice = 0;
            pPrice = 0;
            zKg = 0;
            pKg = 0;
            
            GetValues();
        }

        public void GetValues()
        {
            Console.Write("Vegetables price per kg: ");
            zPrice = double.Parse(Console.ReadLine());
            Console.Write("Fruits price per kg: ");
            pPrice = double.Parse(Console.ReadLine());
            Console.Write("Vegetables kilograms: ");
            zKg = double.Parse(Console.ReadLine());
            Console.Write("Fruits kilograms: ");
            pKg = double.Parse(Console.ReadLine());
        }

        public double CalculateEuro()
        {
            return result / 1.94;
        }
        public void ShowResult()
        {
            double price = CalculateEuro();
            Console.WriteLine($"Total: {price:R2}");
        }
    }
}
