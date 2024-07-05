using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class publiccless
    {
        public int publicporperty { get; set; }

        public void show()
        {
            Console.WriteLine("public property value:" + publicporperty);

        }
        public class Public
        {
            static void Main()
            {
                publiccless obj = new publiccless();
                obj.publicporperty = 1; 

                obj.show();
            }
        }
    }
} 
