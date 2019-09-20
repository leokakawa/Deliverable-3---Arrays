/* 
 * Author:Leonardo Constante
 * Date: 9/19/2019
 * Description: This C# console application code demonstrates the use of an example of array.  
 * 
*/
using System;

namespace Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The code is displaying the array of 25 numbers :" + "\n");
                // Use try 
            try
            {
                // Declare and sort [25] elements in the array
                int[] numbers = { 8, 2, 3, 14, 5, 16, 7, 1, 24, 10, 11, 17, 13, 4, 15, 6, 12, 18, 19, 25, 21, 22, 23, 9, 20 };
                Array.Sort(numbers);
                // Iterate through the array with a foreach loop 
                foreach (int i in numbers)
                {
                    Console.WriteLine("Element value = " + i + " ");
                }
            } // end of try

            // Use catch for code errors
            catch
            {
                Console.WriteLine("Error in the try block...");
                Console.WriteLine("Press any key to exit the program.");
            } // end of catch
        }
    }
}