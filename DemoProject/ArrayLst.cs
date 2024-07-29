using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ArrayLst
    {
        static void Main()
        {
            // Creating An Array List

            ArrayList lst = new ArrayList();

            // add element into the Arraylist

            lst.Add(1);
            lst.Add("Hello");
            lst.Add(false); 

            // Access the elemnet/iteam
            Console.WriteLine("Arraylist Element:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            //Removing element from arraylist

            lst.Remove(false);

            // Access the elemnet after removl
            Console.WriteLine("Arraylist Element after removal:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }


        }
    }
}
