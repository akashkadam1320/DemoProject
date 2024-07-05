using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class copyConstructorexample
    {
        public int value;
        public int value2;

        // parmeterized constructor

        public copyConstructorexample(int value , int value2)
        {
            this.value = value;
            this.value2 = value;
        }

        // copy constructor
        public copyConstructorexample(copyConstructorexample obj)
        {
            value = obj.value;
        }
    }
    internal class CopyConstructor
    {
        static void Main()
        {
            copyConstructorexample obj1 = new copyConstructorexample(10,20);
            Console.WriteLine(obj1.value);
            copyConstructorexample obj2 = new copyConstructorexample(obj1);
            Console.WriteLine(obj2.value);
        }
    }
}
