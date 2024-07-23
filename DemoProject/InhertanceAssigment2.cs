using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    // Base class Person
    public class Person5
    {
        // Fields
        private string name;
        private int age;

        // Constructor
        public Person5(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Methods to access fields (optional)
        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }
    }

    // Derived class Student
    public class Student : Person5
    {
        // Constructor
        public Student(string name, int age) : base(name, age)
        {
            // Additional initialization for Student if needed
        }
    }
    // Teacher class inherits from Person
    public class Teacher : Person5
    {
        // Constructor
        public Teacher(string name, int age) : base(name, age)
        {
            // Additional initialization for Teacher if needed
        }
    }

    // Principal class inherits from Teacher
    public class Principal : Teacher
    {
        // Fields
        private string principalInfo;

        // Constructor
        public Principal(string name, int age, string principalInfo) : base(name, age)
        {
            this.principalInfo = principalInfo;
        }

        // Method to access principal info (optional)
        public string GetPrincipalInfo()
        {
            return principalInfo;
        }
    }
    class InhertanceAssigment2
    {
        static void Main(string[] args)
        {
            // Single inheritance example
            Student student = new Student("Rmesh", 18);
            Console.WriteLine($"Student: Name - {student.GetName()}, Age - {student.GetAge()}");

            // Multilevel inheritance example
            Principal principal = new Principal("Mr. Smith", 45, "PhD in Education");
            Console.WriteLine($"Principal: Name - {principal.GetName()}, Age - {principal.GetAge()}, Info - {principal.GetPrincipalInfo()}");
        }
    }



}