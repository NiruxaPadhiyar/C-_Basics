using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else_Ladder_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check a grade");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num < 0 || num > 100)
            {
                Console.WriteLine("You enter wrong number");
            }
            else if(num >=0 && num < 50)
            {
                Console.WriteLine("You are Fail");
            }

            else if(num >= 50 && num < 60)
            {
                Console.WriteLine("D Grade");
            }

            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("C Grade");
            }

            else if (num >= 70 && num < 80)
            {
                Console.WriteLine("B Grade");
            }

            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("A Grade");
            }

            else if (num >= 90 && num <= 100)
            {
                Console.WriteLine("A+ Grade");
            }

            Console.ReadKey();
        }
    }
}
