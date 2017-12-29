using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Since they use space in memory and they are objects, created with an array creation expresssion:
            // Example: 
            int[] myArray = new int[10];

            // Assigning the value of 10 to array position/index 5 within myArray
            myArray[5] = 10;

            // Can also create an array with a pre-defined list of values within curly braces
            // Creating array of type defining, with name but using {}
            // Create as many positions as needed within the list. 
            // 0 based, so this will have 0, 1, 2, 3 positions. 
            int[] myPreArray = { 5, 6, 9, 10 };

            ModifyArray(myPreArray);

            int total = 0;
            foreach (int number in myArray)
            {
                total += number;
            }

            Console.WriteLine(total);
        }

        public static void ModifyArray(int[] array)
        {
            for (int counter = 1; counter < array.Length; counter++)
            {
                array[counter] *= 2;
            }
        }
    }
}
