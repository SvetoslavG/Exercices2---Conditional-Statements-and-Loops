using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            string ing;

            for (int i = 0; i < 21; i++)
            {
                ing = Console.ReadLine();

                if (ing != "Bake!")
                {
                    Console.WriteLine("Adding ingredient {0}.", ing);
                }

                else
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", i);
                    break;
                }
            }

        }
    }
}
