using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Person

    { 
        //private fiedlds
    
    private string name;
    private int age;

        //private method
        public string GetName()
            {
            return name;  
        }
        public void SetName(string newname)
        { name = newname;
        }

        public int GetAge()
            {
            return age;
         }
        public void SetAge(int newAge)
        { age = newAge;
        }
    }
     class Encapsulation
    {
        static void Main()
        {
            Person person = new Person();
            person.SetName("Akash");
            person.SetAge(19);

            Console.WriteLine("Name"+ person.GetName());
            Console.WriteLine("Age"+ person.GetAge());
        }
    }
}
