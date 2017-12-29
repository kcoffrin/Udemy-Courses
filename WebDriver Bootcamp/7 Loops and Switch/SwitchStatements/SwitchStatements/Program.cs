using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 85;

            switch (grade / 10)
            {
                case 9: //A //Outcome is the same, so it will drop into case 10.
                case 10: //A
                    Console.WriteLine("You Got An A!");
                    break;
                case 8: //B
                    Console.WriteLine("You Got A B!");
                    break;
                case 7: //C
                    Console.WriteLine("You Got A C!");
                    break;
                case 6: //D
                    Console.WriteLine("You Got A D!");
                    break;
                default: //Grade less than 60
                    Console.WriteLine("Sorry, You Failed!");
                    break;
            }

          
        }
    }
}
