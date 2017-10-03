using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studioprice = 1.00;
            var doubleprice = 1.00;
            var suiteprice = 1.00;
            

            if (month == "May" || month == "October")
            {
                studioprice = 50;
                doubleprice = 65;
                suiteprice = 75;

                if (nights > 7)
                {
                    studioprice = studioprice - 0.05 * studioprice;
                }
            }

            else if (month == "June" || month == "September")
            {
                studioprice = 60;
                doubleprice = 72;
                suiteprice = 82;

                if (nights > 14)
                {
                    doubleprice = doubleprice - 0.10 * doubleprice;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioprice = 68;
                doubleprice = 77;
                suiteprice = 89;

                if (nights > 14)
                {
                   suiteprice = suiteprice - 0.15 *suiteprice;
                }
            }

            var totalstudio = studioprice * nights;
            var totaldouble = doubleprice * nights;
            var totalsuite = suiteprice * nights;

            if (month == "September" || month == "October" & nights > 7)
            {
                totalstudio = totalstudio - totalstudio / nights;
            }

            Console.WriteLine("Studio: {0:f2} lv.", totalstudio);
            Console.WriteLine("Double: {0:f2} lv.", totaldouble);
            Console.WriteLine("Suite: {0:f2} lv.", totalsuite);
        }
    }
}
