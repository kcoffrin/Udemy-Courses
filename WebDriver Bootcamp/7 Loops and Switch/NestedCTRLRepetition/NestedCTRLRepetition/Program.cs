using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedCTRLRepetition
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 0;
            int value = 0;

            Console.WriteLine("Please enter a number or -1 to quit: ");
            value = Convert.ToInt32(Console.ReadLine());

            while (value != -1)
            {
                if (value > 5)
                {
                    // IF this is false, there is NO else to execute
                    // The else below does not belong to this 
                    // CW will exectue if false here.  
                    if (value < 15)
                    {
                        total = total + value;
                    }   
                }
                else
                {
                    total = total + 1;
                }
                Console.WriteLine("Please enter a number or -1 to quit: ");
                value = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(total);
        }
    }
}
