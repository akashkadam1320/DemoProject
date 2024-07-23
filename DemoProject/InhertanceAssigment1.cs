using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public class Person1
    {
        protected int Age = 21;
        protected string Name = "Ram";
    }

    class Student1 : Person1
    {
        public void data()
        {
            Console.WriteLine("Student age: " + base.Age);
            Console.WriteLine("Student Name: " + base.Name);
        }
    }

    internal class InheritanceAssignment1
    {
        static void Main()
        {
            Student1 s = new Student1();
            s.data();
        }
    }
}

