using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int part1 = int.Parse(Console.ReadLine());
            int sum1 = 0;
            while (part1 != 0)
            {
                sum1 = sum1 + part1 % 10;
                part1 = part1 / 10;
            }
            int part2 = int.Parse(Console.ReadLine());
            int sum2 = 0;
            while (part2 != 0)
            {
                sum2 = sum2 + part2 % 10;
                part2 = part2 / 10;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Счастливый билетик!");
            }
            else
            {
                Console.WriteLine("Несчастливый :(");
            }
            Console.ReadKey();
        }
    }
}