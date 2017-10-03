using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var job = Console.ReadLine();

            var quantity = int.Parse(Console.ReadLine());

            var price = 1.2;



            if (job == "Athlete")
            {
               price= 0.7;
                
            }

            else if (job == "Businessman" || job == "Businesswoman")
            {
                price = 1;
            }

            else if (job == "SoftUni Student")
            {
                price = 1.7;
            }

             var  totalprice = price * quantity;

            Console.WriteLine("The {0} has to pay {1:f2}.", job, totalprice );
        }
    }
}
