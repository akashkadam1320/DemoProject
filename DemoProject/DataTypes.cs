using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class DataTypes
    {
        public static void Main()
        {
            // int
            int age = 25;

            Console.WriteLine("My Age Is " + age);

            double PI = 2.35;
            Console.WriteLine("MY Mark is " + PI);

            // float
            double p = 78.56;
            Console.WriteLine("MY Mark is " + p);

            //// converting float to int
            int b = (int)p;
            Console.WriteLine(b);

            // char

            char score;
            {
                char Grade;
                score = (char)76;
                if (score >= 98)
                    Grade = 'A';
                else if (score >= 88)
                    Grade = 'B';
                else if (score >= 79)
                    Grade = 'C';
                else if (score >= 68)
                    Grade = 'D';
                else
                    Grade = 'F';
                Console.WriteLine("Grade of student is " + Grade);

            }

            // string 
            string Message = "Hello World..!";
            Console.WriteLine(Message);

            string Name = " ramesh kumar";
            Console.WriteLine(Name);


            // Boolean
            bool IsTure = false;
            Console.WriteLine(IsTure);


        }
    }
}
