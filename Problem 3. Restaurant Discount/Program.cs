using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var hall = "hall";

            var hallprice = 1.00;
            var discount = 0.1;
            var packagePrice = 1.00;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            else
            {
                if (groupSize <= 50)
                {
                    hall = "Small Hall";
                    hallprice = 2500;
                }
                else if (groupSize <= 100)
                {
                    hall = "Terrace";
                    hallprice = 5000;
                }
                else if (groupSize <= 120)
                {
                    hall = "Great Hall";
                    hallprice = 7500;
                }

                if (package == "Normal")
                {
                    packagePrice = 500;
                    discount = 0.05;
                }

                if (package == "Gold")
                {
                    packagePrice = 750;
                    discount = 0.1;
                }

                if (package == "Platinum")
                {
                    packagePrice = 1000;
                    discount = 0.15;
                }

                var price = ((hallprice + packagePrice) - (hallprice + packagePrice) * discount) / groupSize;

                Console.WriteLine("We can offer you the {0}", hall);
                Console.WriteLine("The price per person is {0:f2}$", price);
            }
        }
    }
}
