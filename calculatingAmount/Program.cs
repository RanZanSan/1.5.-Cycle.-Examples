using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatingAmount
{
    class Program
    {
        static void Main(string[] args)
        {
            int now = int.Parse(Console.ReadLine());
            int sum = 0;
            while (now != 0)
            {
                sum = sum + now;
                now = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}