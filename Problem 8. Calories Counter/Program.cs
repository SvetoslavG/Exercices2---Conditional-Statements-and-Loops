using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                string ingr = Console.ReadLine().ToLower();
                if (ingr == "cheese")
                {
                    sum = sum + 500;
                }
                else if (ingr == "tomato sauce")
                {
                    sum = sum + 150;
                }
                else if (ingr == "salami")
                {
                    sum = sum + 600;
                }
                else if (ingr == "pepper")
                {
                    sum = sum + 50;
                }
            }
            Console.WriteLine($"Total calories: {sum}");
        }
    }
}
