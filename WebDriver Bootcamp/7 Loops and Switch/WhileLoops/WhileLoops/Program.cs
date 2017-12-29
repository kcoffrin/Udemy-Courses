using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int product = 3;
            // While loop will run while the product is <=100
            // When statement becomes false, the while loop will end 
            // Write out the value of the product will happen when the condition is false, as this is the next statement
            // Can add the CW statement inside the loop to see each step in the process. 

            // To Debug a while loop:  
                // You can add a breakpoint inside the while, or mark the WHILE itself and walk through each iteration
                    // Put mouse over variable, locals or watch windows to keep track of the variables
            while (product <= 100)
            {
                product = 3 * product;
            }

            Console.WriteLine(product);
        }
    }
}
