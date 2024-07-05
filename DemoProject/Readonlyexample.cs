using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class readonlyex
    {
        // read only fildes

        public readonly int Initialval;
        public static readonly double PI;

        // constructor for initialize the readline fileds

        public readonlyex(int initialvalue)
        {
            Initialval = initialvalue;
            Initialval = 23;
        }

        static readonlyex()
        {
            PI = 2.15;
        }

        public void printconstvalues()
        {
            Console.WriteLine($"Initial value : {Initialval}");
            Console.WriteLine($"Value of PI : {PI}");
        }
    }
    internal class Readonlyexample
    {
        static void Main()
        {
            readonlyex example = new readonlyex(10);
            example.printconstvalues(); 

        }
    }
}
