using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (true)
            {
                Console.WriteLine(i);
                i = i + 1;
                if (i > 100)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}