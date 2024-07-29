using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class NongenQueue
    {
        static void Main()
        {
          Queue qu = new Queue();

            // FIFO -first in first out
            // Enque is basically used to add element in to the queue

            qu.Enqueue("Sachin");
            qu.Enqueue(123465);
            qu.Enqueue(true);

            // Dequeue (remove) - to remove the element from the queue 

            object firstelement = qu.Dequeue();
            object secondelement = qu.Dequeue();    
            object thirdelement = qu.Dequeue();

            // Display the items Dequeueed 

            Console.WriteLine("Dequeue Element");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);   
            Console.WriteLine(thirdelement);



        }
    }
}
