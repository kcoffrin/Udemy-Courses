using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            // Do While Loop
            int counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10);
           
        }
    }
}
