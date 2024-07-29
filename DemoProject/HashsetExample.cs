using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class HashsetExample
    {
        static void Main()
        {
            //create a hashset
            HashSet<int> Numbers = new HashSet<int>();

            // Add element to the hashset
            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(4);
            Numbers.Add(4);// Duplicate element

            Console.WriteLine("Hashset Element");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            // find purticular element in the hashset
            bool containstwo = Numbers.Contains(2);
            Console.WriteLine("hashset Contains 2:"+ containstwo);

            // Remove element from the hashset
            Numbers.Remove(3);

            Console.WriteLine("after removal");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
            //Create another hashset for set operation

            HashSet<int> numberstest = new HashSet<int> { 1, 2, 3, 4, 5 };

            Numbers.UnionWith(numberstest);
            Console.WriteLine("hashset element after union with{3,4,5}");
            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }

        }
    }
}
