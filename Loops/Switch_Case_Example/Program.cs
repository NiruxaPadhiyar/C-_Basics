using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Department ID");
            int Dept_Id = Convert.ToInt32(Console.ReadLine());

            switch(Dept_Id)
            {
                case 1:

                    Console.WriteLine("Information Technology");
                    break;

                    case 2:
                    Console.WriteLine("Computer Engineer");
                    break ;

                    case 3:
                    Console.WriteLine("Mechanical Engineer");
                    break;

                case 4:
                    Console.WriteLine("Chemical Emgineer");
                    break;;

                    case 5:
                    Console.WriteLine("Electrical Engineer");
                    break;

                    default:
                    Console.WriteLine("You are detain from this college, Thank you !");
                    break;




              
                
            }

            Console.ReadKey();
        }
    }
}
