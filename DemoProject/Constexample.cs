using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class constex
    {
        public const double P = 2.356;
        public const string AppName = "Myapp";

        public void PrintConstant()
        {
            Console.WriteLine($"The value of P is :{P}");
            Console.WriteLine($"Application Name : {AppName}");
        }
    }
    internal class Constexample
    {
        static void Main()
        {
            constex example = new constex();
            example.PrintConstant();
        }
    }
}
