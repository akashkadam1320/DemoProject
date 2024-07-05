using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ControlStatement
    {
        static void Main()
        {
            //if statement 

            //int number = 0;

            //if (number > 0)
            //{
            //    Console.WriteLine("The Numeber is positive");
            //}



            ////if -else statement

            //if (number > 0)

            //{
            //    Console.WriteLine("The Number is Positive");

            //}
            //else
            //{
            //    Console.WriteLine("The Number is not Positive");

            //}


            //// if else if statement
            //int numbernew = 0;

            //if (numbernew > 0)
            //{
            //    Console.WriteLine("The Number is Positive");

            //}
            //else if (numbernew < 0)
            //{
            //    Console.WriteLine("The Number is Negative");

            //}

            //else
            //{
            //    Console.WriteLine("The Number is Zero");
            //}



            ////Switch statement

            //int Day = 3;

            //switch (Day)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wedmesday");
            //        break;
            //    default:
            //        Console.WriteLine("other day");
            //        break;

            //}

            // for loop

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }


            // while loop

            int m = 0; ;

            while (m < 5)
            {
                Console.WriteLine("Iteration while loop: " + m);
                m++;
            }


            // do while loop

            int j = 0; 
            do
            {
                Console.WriteLine("Iteration do while loop:" + j);
                j++;
            }while (j < 5);

            // for each loop

            string[] fruit = { "Apple", "Banana", "Mango" };
            foreach (string fruits in fruit)
            {
                Console.WriteLine("The fruit name is " + fruit);
            }


            // continue 

            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine("Iteration" + i);
            }

            // Go to statment

            int count = 0;
        startloop:

            if (count < 5)
            {
                Console.WriteLine($"Count is {count}");
                count++;
                goto startloop;
            }
        Console.WriteLine("Loop with goto is finished");






        }
    }
}

    

