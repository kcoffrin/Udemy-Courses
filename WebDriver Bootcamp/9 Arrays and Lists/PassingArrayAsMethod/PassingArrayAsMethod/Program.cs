using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArrayAsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myPreArray = { 5, 6, 9, 10 };

            //ModifyArray(myPreArray);

            // Passing in the first index/location of the myPreArray Array, this case 6
            ModifyElement(myPreArray[1]);

            foreach (int num in myPreArray)
            {
                Console.WriteLine(num);
            }
        }

        //public static void ModifyArray(int[] array)
        //{
        //    for (int counter = 1; counter < array.Length; counter++)
        //    {
        //        array[counter] *= 2;
        //    }
        //}

        // Passing an array element to a method

        public static void ModifyElement(int ArrayItem)
        {
            ArrayItem *= 2;
            Console.WriteLine(ArrayItem);
        }
    }
}
