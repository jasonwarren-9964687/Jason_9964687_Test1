using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base times exponent");
            //base input
            Console.Write("Input value of base: ");
            double b = double.Parse(Console.ReadLine());
            //exponent input
            Console.Write("Input value of exponent: ");
            int x = int.Parse(Console.ReadLine());
            //for loop
            double y = 1;
            for (int count = 0; count < x; count++)
            {
                y = y * b;
            }
            //result
            Console.WriteLine($"{b}^{x} is {y}.");
            Console.ReadLine();
        }
    }
}
