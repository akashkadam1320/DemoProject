using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class HeapStack
    {
        static void Main()
        {
            //value type--- stack
            int value = 20;

            //referance type -- heap
            Persons person = new Persons ("Amar", 25);

            Console.WriteLine($"Value: {value}");
            Console.WriteLine($"Person: {person.Name},Age {person.Age}");

            //  ModifyValue(value);
            Console.WriteLine("value After modification attempt");
        }
    }


    class Persons
    {


        public string Name { get; set; }
        public int Age { get; set; }

        public Persons(string name, int age)
        {
            Name = name;
            Age = Age;
        }
    }


}
