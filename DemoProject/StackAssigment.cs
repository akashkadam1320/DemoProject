using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StackAssigment
    {
        static void Main()
        {
            // create a non-genenric stack

            Stack stk = new Stack();



            stk.Push("Ramesh");
            stk.Push(59);
            stk.Push(false);
            stk.Push(true);
            stk.Push("Suresh");


            // Display the poped element
            Console.WriteLine("Stack element .");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            // remove element 
            object firstelement = stk.Pop();
            object secondelement = stk.Pop();

            Console.WriteLine("Stack element remove .");
            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }

        }

    }
}
