using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSandwiches = 6;
            int costOfSandwiches = 3;

            //Output statement
            // Placeholders are in numerical order staring at 0
            Console.WriteLine("The {0} sandwiches cost {1:C} dollars", numberOfSandwiches, costOfSandwiches);

        }
    }
}
