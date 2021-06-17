using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakAndContinueToo
{
    class Program
    {
        static void Main(string[] args)
        {
            int now = -1;
            string positiveNumbers = "";
            while (now != 0)
            {
                now = int.Parse(Console.ReadLine());
                if (now <= 0)
                {
                    continue;
                }
                positiveNumbers = positiveNumbers + now + " ";
            }
            Console.Write(positiveNumbers);
            Console.ReadKey();
        }
    }
}