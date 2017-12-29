using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    class program
    {
        static void Main(string[] args)
        {
            Helper.Sum(10);
            Console.WriteLine(Helper.number);

            Helper.Sum(10);
            Console.WriteLine(Helper.number);
        }
    }
}
