using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Animal1
    {
       public void Eat1()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    // sub class / child class / derived class 
    public class Dog1 : Animal1
    {
       public void Test()
        {
            Console.WriteLine("Test succesful");
        }

    }
    internal class SingleInheritance
    {
        static void Main()
        {
             Dog1 Dg = new Dog1();
            Dg.Test();
            Dg.Eat1();
        }
    }
}
 