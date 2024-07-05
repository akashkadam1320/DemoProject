using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class DefaulConstructorExmple
    {
        public int value;
        // Defaul constructor
        public DefaulConstructorExmple()
        {
            value = 10;
        }

        //// other Method
        //public void Display()
        //{
        //    Console.WriteLine("value");
        //}
    }
     class DefaultConst
    {
        static void Main()
        {
            DefaulConstructorExmple obj = new DefaulConstructorExmple();
            Console.WriteLine(obj.value);  // output

            //obj.Display();
        }
    }
}
