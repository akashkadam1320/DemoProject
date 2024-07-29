using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class DictioryAssigment
    {
        static void Main()
        {
            Dictionary<string, int> monthdict = new Dictionary<string, int>();

            monthdict.Add("Ramesh", 1);
            monthdict.Add("suresh", 2);
            monthdict.Add("mahesh", 3);
            monthdict.Add("pratik", 4);
            monthdict.Add("akash", 5);
            monthdict.Add("sayli", 6);
            monthdict.Add("geeta", 7);
            monthdict.Add("sonali", 8);
            monthdict.Add("pooja", 9);
            monthdict.Add("rupesh", 10);

            Console.WriteLine("All element in the Dictionary");
            foreach (KeyValuePair<string, int> KVP in monthdict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }

            Console.WriteLine("");
            monthdict["mahesh"] = 19;
            monthdict["pratik"] = 15;
            Console.WriteLine("element in the Dictionary is modify....!");
            foreach (KeyValuePair<string, int> KVP in monthdict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }

            Console.WriteLine("");
            monthdict.Remove("mahesh");
            monthdict.Remove("Pooja");
            Console.WriteLine("element in the Dictionary is remove....!");
            foreach (KeyValuePair<string, int> KVP in monthdict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");
            }

            Console.WriteLine("");
            monthdict.Clear();
            Console.WriteLine("Dictionary is  empty?" + (monthdict.Count == 0));




        }
    }
}
