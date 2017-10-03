using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    
                    sum += 3*(i * j);
                    count ++;

                    if (sum >= max)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                }

               
            }

            Console.WriteLine($"{count} combinations");
            Console.WriteLine($"Sum: {sum}");

            
           
           
        }
    }
}
