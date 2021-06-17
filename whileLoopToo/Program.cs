using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoopToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int now = int.Parse(Console.ReadLine());
            int min = now;
            while (now != 0)
            {
                if (now < min)
                {
                    min = now;
                }
                now = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}