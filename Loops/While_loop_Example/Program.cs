using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your number");
            int num = Convert.ToInt32(Console.ReadLine());

            // we need to put increase operator otherwise loop will never end.


           while(num < 5)
            {
                Console.WriteLine(num);
                num++;

                Console.ReadKey();

            }
        }

    }
}
