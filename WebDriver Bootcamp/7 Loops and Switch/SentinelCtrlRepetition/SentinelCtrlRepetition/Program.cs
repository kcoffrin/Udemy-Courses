﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentinelCtrlRepetition
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
                total = total + value;
                Console.WriteLine("Please enter a number or -1 to quit: ");
                value = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(total);
        }
    }
}
