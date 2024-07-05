using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class PrivateClass
    {
        private int privateField;
        public void setfield(int value)
        {
            privateField = value;
        }
        public void show()
        {
            Console.WriteLine("private field value"+ privateField);
        }
    }
    class Private
    { 

        static void Main()
        {
            PrivateClass obj = new PrivateClass();
            obj.setfield(10);
            obj.show();
        }
    }
}
