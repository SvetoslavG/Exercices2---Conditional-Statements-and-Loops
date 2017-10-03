using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondtLetter = char.Parse(Console.ReadLine());
            char thirdtLetter = char.Parse(Console.ReadLine());

            for (char i = firstLetter; i <= secondtLetter ; i++)
            {
                for (char j = firstLetter; j <= secondtLetter ; j++)
                {
                    for (char k = firstLetter; k <= secondtLetter; k++)
                    {
                        if (i != thirdtLetter & j != thirdtLetter & k != thirdtLetter)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }
    }
}
