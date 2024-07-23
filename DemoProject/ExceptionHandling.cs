using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ExceptionHandling
    {
        static void Main()
        {
            int[] Numbers = { 1, 2, 3 };
            int index = 4;

            try
            {
                // login
                int value = Numbers[index];  // Indexoutofbond
                Console.WriteLine($"value at index {index} is : {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error:{ex.Message}. Index is out of Range");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occoured: {ex.Message}");
            }
            finally //
            {
                Console.WriteLine("This code alwaye execute");
            }

            // Divide by zero

            int num = 10;
            int demo = 0;
            double result = 0;

            try
            {
                result = num / demo;   //attempting to divide by zero
                Console.WriteLine($"Result of Division : {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}.cannot be devied by zero.");
            }
            
            // Custom exception
            try
            {
                Dataprocessing(null);

            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine($"Error: {ex.Message}.argument cannot be null.");
            }
        }
        static void Dataprocessing(string data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data), "data connot be null");
            }
        }
    }
}
