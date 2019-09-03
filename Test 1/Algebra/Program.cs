using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the answer to the algebraic formula 2(x-3) + x = 12");
            //guess input
            Console.Write("Input guess: ");
            int guess = int.Parse(Console.ReadLine());
            //2(x-3) + x = 12
            //2x - 6 + x = 12
            //3x - 6 = 12
            //3x = 18
            //x = 6
            int x = 6;
            //decision
            if (guess == x) Console.WriteLine("Correct!");
            else Console.WriteLine("Incorrect");
            Console.ReadLine();
        }
    }
}
