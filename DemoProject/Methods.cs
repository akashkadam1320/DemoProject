using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Methods

    {
        static void Display()
        {
            // method body 
            Console.WriteLine("Hello");

        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            // calling method
            Display();

            int Result = Addition(1, 2);
            Console.WriteLine("the addition of two no is "+Result);
        }
    }
}
