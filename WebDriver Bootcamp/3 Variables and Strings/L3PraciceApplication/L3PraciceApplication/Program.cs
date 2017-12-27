using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3PraciceApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberOne = 1;
            int NumberTwo = 2;
            int NumberThree = 3;
            int NumberFour = 4;

            //Concantination

            Console.WriteLine("The First Number is: " + NumberOne + ". The Second Number is: " + NumberTwo + ". The Third Number is: " + NumberThree + ". And the Fourth is: " + NumberFour);

            //String Replacement

            Console.WriteLine("The first number is: {0}. The Second Number is: {1}. The Third Number is: {2}. The Last Number is: {3}", NumberOne,NumberTwo,NumberThree,NumberFour);

            Console.ReadKey();
        }
    }
}
