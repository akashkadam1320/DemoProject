using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    
    class Operator
    {
        static void Main()
        {
            // Arithmetric Opertor
            int A = 10;
            int B = 3;

            int sum = A + B;  // Addition
            Console.WriteLine(sum);
            int Differnce = A - B;   // sub
            Console.WriteLine(Differnce);
            int mult = A * B;   // multi
            Console.WriteLine(mult);
            int divide = A / B;    // divide
            Console.WriteLine(divide);
            int reminder = A % B;
            Console.WriteLine(reminder);


            // conditional operators (ternary opertor)

            int C = 5;
            int D = 10;

            string Result = (C > D) ? "C is gerater" : "D is greter";
            Console.WriteLine(Result);

            // comparision Opertor

            int E = 5;
            int F = 10;

            bool isEqual =(E == F);
            Console.WriteLine(isEqual);

            bool isNotEqual = (E != F);
            Console.WriteLine(isEqual);

            bool isGreater = (E > F);
            Console.WriteLine(isGreater);

            bool isLess = (E < F);
            Console.WriteLine(isLess);

            bool isGreaterOrEqual = (E >= F);
            Console.WriteLine(isGreaterOrEqual);

            bool isLessOrEqual = (E <= F);
            Console.WriteLine(isLessOrEqual);


        }
    }
}
