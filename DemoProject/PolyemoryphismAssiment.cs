using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class math
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public double add(double a, double b)
        {
            return a + b;
        }

    }
        internal class PolyemoryphismAssiment1
    {
      
        
        static void Main()
        {
            math obj = new math();

            int sum1 = obj.add(11, 2);
            double sum2 = obj.add(11, 2.7);

            Console.WriteLine("addition: "+sum1);
            Console.WriteLine("addition: "+ sum2);
        }

    }
}
