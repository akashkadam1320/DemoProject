using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Dixct
    {
        static void Main()
        {
            // initialize dictionary
            Dictionary<string,int> agedict = new Dictionary<string,int>();

            // add key-value pains to the dictionary

            agedict.Add("Rohit", 25);
            agedict.Add("Sangram", 26);
            agedict.Add("Sachin",28);

            //print all the element  in the dictoinary
            Console.WriteLine("All element in the Dictionary");
            foreach (KeyValuePair<string,int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");

                
            }
            // modifiy the value form dictionary

            agedict["Rohit"] =30;
            agedict["Sachin"] = 32;

            // //print all the modifiy element  in the dictoinary
            Console.WriteLine("All element in the Dictionary");
            foreach (KeyValuePair<string, int> KVP in agedict)
            {
                Console.WriteLine($"{KVP.Key}: {KVP.Value}");


            }
            // remove value
            agedict.Remove("Sachin");

            if (agedict.ContainsKey("Rohit"))
            {
                Console.WriteLine("Exist in the dictionary");
            }
            // to clear the disctionary
            agedict.Clear();
            Console.WriteLine(agedict.Count);
        }
    }
}
