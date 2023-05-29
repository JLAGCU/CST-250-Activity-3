using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 10;
            Console.Out.WriteLine(factorial(startingNumber));
            Console.ReadLine();
        }

        static int factorial(int x)
        {
            Console.Out.WriteLine("x is {0}", x);
            if (x == 1)
            {
                return 1;
            }
            else
            {
                return x * factorial(x - 1);
            }
        }
    }
}
