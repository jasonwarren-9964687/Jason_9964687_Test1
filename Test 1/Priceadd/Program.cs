using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priceadd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add price of five items");
            //loop variables
            int count = 1;
            double price = 0;
            //loop
            while (count <= 5)
            {
                Console.Write($"Input price of item {count}: ");
                //price adding to itself
                price = price + double.Parse(Console.ReadLine());
                count++;
            }
            //total
            Console.WriteLine($"Your total is ${price}.");
            Console.ReadLine();
        }
    }
}
