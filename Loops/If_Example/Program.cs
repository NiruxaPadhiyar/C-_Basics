using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0)

            {
                Console.WriteLine("It is even number");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("It is odd number");
                Console.ReadKey();
            }
        }
    }
}
