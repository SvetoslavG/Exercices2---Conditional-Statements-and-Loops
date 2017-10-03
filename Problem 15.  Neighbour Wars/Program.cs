using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var PeshoDamage = int.Parse(Console.ReadLine());
            var GoshoDamage = int.Parse(Console.ReadLine());

            var PeshoHealth = 100;
            var GoshoHealth = 100;

            var Round = 0;

            while (PeshoHealth > 0 & GoshoHealth > 0)
            {
                Round++;

                if (Round % 2 != 0 )
                {
                    GoshoHealth -= PeshoDamage;
                    if (GoshoHealth < 1)
                    {
                        Console.WriteLine($"Pesho won in {Round}th round.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                    }
                }

                else
                {
                    PeshoHealth -= GoshoDamage;
                    if (PeshoHealth < 1)
                    {
                        Console.WriteLine($"Gosho won in {Round}th round.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                    }
                }

                if (Round % 3 == 0)
                {
                    GoshoHealth += 10;
                    PeshoHealth += 10;
                }
            }


        }
    }
}
