using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int lastn = 0;
            int lastm = 0; 
            var count = 0;

            bool found = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if (i + j == magic)
                    {
                        lastn = i;
                        lastm = j;
                        found = true;
                    }
                    count++;
                }
            }

            if (found)
            {
                Console.WriteLine($"Number found! {lastn} + {lastm} = {magic}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
                
            }
        }
    }
}
