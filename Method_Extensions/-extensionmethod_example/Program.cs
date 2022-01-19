using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _extensionmethod_example
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Enter i");

            i = Convert.ToInt32(Console.ReadLine());

            bool result = i.IsLessThan(5);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}


namespace _extensionmethod_example
{
    public static class IntExtensions
    {
        public static bool IsLessThan(this int i, int value)
        {
            return i < value;
        }
    }
}

