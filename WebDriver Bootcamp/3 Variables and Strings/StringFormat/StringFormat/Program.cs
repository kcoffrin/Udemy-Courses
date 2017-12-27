using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 15.30M;

            string output = String.Format("The Current Price is {0:C} per ounce", price);

            Console.WriteLine(output);

            //Escaped String
            string filename = "C:\\MyFolder\\SubFolder\\Myfile.txt";

            //Verbatim String
            string filename2 = @"C:\MyFolder\SubFolder\Myfile.txt";
        }
    }
}
