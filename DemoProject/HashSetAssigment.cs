using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoProject
{
    internal class HashSetAssigment
    {
        static void Main()
        {
            HashSet<string> s = new HashSet<string>();
            s.Add("January");
            s.Add("February");
            s.Add("March");
            s.Add("April");
            s.Add("May");

            Console.WriteLine("Add five elements in hashset...");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            s.Remove("May");
            s.Remove("April");
            Console.WriteLine("Remove elements from hashset...");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            HashSet<string> ST = new HashSet<string>
            {
                "April", "May", "June", "July", "August", "September"
            };

            // Union operation
            s.UnionWith(ST);
            Console.WriteLine("HashSet elements after union with {April, May, June, July, August, September}:");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            // Intersection operation
            HashSet<string> ST2 = new HashSet<string>
            {
                "March", "April", "May", "October"
            };
            s.IntersectWith(ST2);
            Console.WriteLine("HashSet elements after intersection with {March, April, May, October}:");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}
