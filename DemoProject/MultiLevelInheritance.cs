using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class A
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class B : A
    {
        public void Drink()
        {
            Console.WriteLine("Drinking");
        }
    }
    public class C : B
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    internal class MultiLevelInheritance
    {
        static void Main()
        {
            C a = new C();
            a.Eat();
            a.Bark();
            a.Drink();
        }
    }
}
