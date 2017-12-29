using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterControlRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 1;
            int value = 0;

            while (counter <= 10)
            {
                Console.WriteLine("Please enter a number: ");
                // Read in the number from the console and convert it to an INT, as the VALUE variable is of type INT. 
                value = Convert.ToInt32(Console.ReadLine());
                total = total + value;
                counter = counter + 1;
            }

            Console.WriteLine(total);
             
        }
    }
}
