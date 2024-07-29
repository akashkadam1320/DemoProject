using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class HashtblAssigment
    {
        static void Main()
        {
            Hashtable hst = new Hashtable();

            hst.Add(1, "January");
            hst.Add(2, "February");
            hst.Add(3, "March");
            hst.Add(4, "April");
            hst.Add(5, "May");
            hst.Add(6, "June");

            string value1 = (string)hst[1];
            string value2 = (string)hst[2];
            string value3 = (string)hst[3];
            string value4 = (string)hst[4];
            string value5 = (string)hst[5];
            string value6 = (string)hst[6];

            Console.WriteLine("Element of Hashtable:");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
            Console.WriteLine(value5);
            Console.WriteLine(value6);

            Console.WriteLine("");

            hst.Remove(1);
            hst.Remove(2);
            Console.WriteLine("Remove element of Hashtable:");

            foreach (var  key in hst)
            {
                Console.WriteLine(key);
            }

            

        }
    }
}
