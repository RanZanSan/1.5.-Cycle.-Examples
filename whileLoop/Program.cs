using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.Write(i + " ");
                i = i + 1;
            }
            Console.ReadKey();
        }
    }
}