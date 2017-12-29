using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Helper.Sum(10);
            Console.WriteLine(Helper.number);

            Helper.Sum(10.5);
            Console.WriteLine(Helper.dNumber);
        }
    }
}
