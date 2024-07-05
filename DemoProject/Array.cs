using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Array
    {
        public static void Main()
        {
            // Declar array

            string[] name = new string[4];

            // assign value

            name[0] = "Apply";
            name[1] = "Samsung";
            name[2] = "Nokia";
            name[3] = "Realme";

            // Access
            Console.WriteLine("Name is the array element");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            // Reverse Number 

            int[] Numbers = { 1, 2, 3, 4, 5 };

            // 5,4,3,2,1

            Console.WriteLine("Input Array");

            Print(Numbers);

            // Reverse Array 

            Reverse(Numbers);

            Console.WriteLine("Reverse Array:");

            Print(Numbers);

            // string builder consept not a arry concept

            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(" test");

            Console.WriteLine(sb);

            sb.Replace("Hello", "Test");
            Console.WriteLine(sb);

            // Boxing
            int num = 30;   // value type (INT)
            object obj = num; // Boxing it will convert value to object (refence)

            // UnBoxing 

            object objNew =35;
            int num1 = (int)objNew; // unboxing

            // imlicait and exlicit casting/coverting

            int j = 42;
            object obj2 = j;
            
            int k = (int)obj2;

        }

        // print array

        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {

                Console.WriteLine(num + " ");
            }
            Console.WriteLine();

        }
        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap element

                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }
    }
}