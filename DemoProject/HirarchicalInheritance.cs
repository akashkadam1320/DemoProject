using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Animal2
    {
        public void Eat2()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog2 : Animal2
    {
        public void Bark2()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    public class Cat2 : Animal2
    {
        public void Meow()
        {
            Console.WriteLine("Cat is Meowing");
        }
    }
    internal class HirarchicalInheritance
    {
        static void Main()
        {
          Dog2 dg = new Dog2();
            dg.Bark2();
            dg.Eat2 ();

            Cat2 ct = new Cat2();
            ct.Meow ();
            ct.Eat2 () ;

        }
    }
}
