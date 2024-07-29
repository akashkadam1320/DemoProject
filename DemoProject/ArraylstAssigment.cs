using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ArraylstAssigment
    {
        static void Main()
        {
            ArrayList lst = new ArrayList();

            lst.Add("Ramesh");
            lst.Add(true);
            lst.Add(100);
            lst.Add(false);
            lst.Add("Tushar");
            lst.Add(0.12);
            lst.Add(4);
            lst.Add(50);
            lst.Add(400);
            lst.Add(0.14);
            //Access the element/ item

            Console.WriteLine("Arraylist Element:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            // remove element
            
            lst.Remove("Ramesh");
            lst.Remove(true);
           
            Console.WriteLine("Arraylist removal two elements:");
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }
}
