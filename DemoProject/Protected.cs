using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class BassClass
    {
        private int privatefiled;
        protected int protectedfield;

        public void setfield(int value)
        {
            protectedfield = value;
        }
    }
    class DerivedClass : BassClass
    {
        private int privatefiled;
        public void show()
        {
            Console.WriteLine("Protected filed value is " + protectedfield);
            Console.WriteLine("Private field " + privatefiled);
        }



        class Protected
        {
            static void Main()
            {
                DerivedClass obj = new DerivedClass();
                obj.setfield(1);
                obj.show();
            }

        }
    }
}

