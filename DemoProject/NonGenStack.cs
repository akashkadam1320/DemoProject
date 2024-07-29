using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class NonGenStack
    {
        static void Main()
        {
            // create a non-genenric stack
            Stack st = new Stack();

            st.Push("Top");
            st.Push(52);
            st.Push(false);

            //Remove (pop) the element from stack
            object Topelement = st.Pop();
            object secondelement = st.Pop();
            object thridelement = st.Pop();

            // Display the poped element
            Console.WriteLine("Poped Element");
            Console.WriteLine(Topelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thridelement);

            // check if the stack is empty or it has a value 
            Console.WriteLine("IS sthe stack empty?"+(st.Count==0));

        }
    }
}
