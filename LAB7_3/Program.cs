using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
    {
        static void Main()
        {
            Func<double, double>[] discounts =
            {
                price => price * 0.95,
                price => price * 0.90,
                price => price - 100
            };

            double priceValue = 1000;

            foreach (var discount in discounts)
            {
                priceValue = discount(priceValue);
            }

            Console.WriteLine(priceValue);
            Console.ReadKey();
        }
    }
