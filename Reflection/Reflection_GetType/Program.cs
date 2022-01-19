using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_GetType
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Reflection is the process to get data at runtime.

            // GetType() Method is using for gets the current Type.
            int number = 10;

            string name = "nili";

            Type type = number.GetType();

            Type type1 = name.GetType();

            Console.WriteLine(type);

            Console.WriteLine(type1);

            // GetAssembly() example

            Type t = typeof(System.String);
            Console.WriteLine(t.Assembly);

            //Print Type Information

            Type t1 = typeof(System.String);

            Console.WriteLine(t1.FullName);

            Console.WriteLine(t1.BaseType);

            Console.WriteLine(t1.IsInterface);

            Console.WriteLine(t1.IsEnum);

            // Print Constructors

            Type t3 = typeof(System.String);

            Console.WriteLine("Constructor of {0} type....",t3);

            ConstructorInfo[] ci = t3.GetConstructors(System.Reflection.BindingFlags.Public | BindingFlags.Instance);

            foreach (ConstructorInfo c in ci)
            {
               Console.WriteLine(c);
            }


            // PRint Methods

            Type t4 = typeof(System.String);

            Console.WriteLine("Methods of {0} type....", t4);

            MethodInfo[] ci1 = t3.GetMethods(System.Reflection.BindingFlags.Public | BindingFlags.Instance);

            foreach (MethodInfo m in ci1)
            {
                Console.WriteLine(m);
            }


            // Print Fields

            Type t5 = typeof(System.String);

            Console.WriteLine("Fields of {0} type...", t5);
            FieldInfo[] fi = t5.GetFields(System.Reflection.BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);

            foreach (FieldInfo fi1 in fi)
            {
                Console.WriteLine(fi1);
            }


            Console.ReadKey();


        }
    }
}
