using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class DemoMethods
    {
        public void Greet(string a)
        {
            Console.WriteLine(a);
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int multiply(int a, int b, int c)
        {
            return a * b + c;
        }
        public void printMessage(string message, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
     class MethosAssigment
        {
            static void Main()
            {
            DemoMethods Dm = new DemoMethods();
            Dm.Greet("Hello Team! \n\nGood Morning....!\n ");
            Console.WriteLine("Addition of #2 digits (10 & 10) is: " + Dm.add(10, 10));
            Console.WriteLine();
            Console.WriteLine("multiply of #2 digits (10 & 10) is: " + Dm.multiply(10, 10));
            Console.WriteLine();
            Console.WriteLine("multiply of #3 digits (10, 10 & 10) is: " + Dm.multiply(10,10, 10));
            Console.WriteLine();
            Dm.printMessage("heaven is under our feet as well as over our heand!", 3);


        }
        }
    }
