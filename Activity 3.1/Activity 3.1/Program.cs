using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Please enter an integer. I will do some math and eventually arrive at 1: ");
            int startinNumber = int.Parse(Console.ReadLine());
            int x = countToOne(startinNumber);
            Console.ReadLine();
        }
        static public int countToOne(int n)
        {
            Console.Out.WriteLine("N is {0}", n);
            if (n == 1)
            {
                return 1;   
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.Out.WriteLine("N is even. Divide by 2");
                    return countToOne(n / 2);
                }
                else
                {
                    Console.Out.WriteLine("N is odd. Add 1");
                    return countToOne(n + 1);
                }
            }
        }
    }
}
