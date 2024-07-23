using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class MathOpertion
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
    internal class StaticPolymorphism1
    {
        static void Main()
        {
            MathOpertion math = new MathOpertion();
            // call overloading method

            int sum1 = math.Add(1, 2);
            double sum2 = math.Add(2.5, 3);

            Console.WriteLine("Sum Of Integers:"+sum1);
            Console.WriteLine("sum Of Doubles:"+ sum2);
        }
    }
}
