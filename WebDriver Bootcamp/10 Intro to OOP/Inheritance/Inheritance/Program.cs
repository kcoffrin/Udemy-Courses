using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables that you wish to pass to your constructors

            //Employee 1
            string firstName = "John";
            string lastName = "Smith";
            string phone = "555-999-5555";
            decimal salary = 50000M;
            int vacationDays = 10;
            //Instance of a derviced class using an object creation statement
            FullTime newEmp = new FullTime(firstName, lastName, phone, salary, vacationDays);

            // Employee 2:
            string firstName2 = "Sara";
            string lastName2 = "Jones";
            string phone2 = "656-999-4444";
            decimal rate = 15.00M;
            //Instance of a derviced class using an object creation statement
            PartTime newPT = new PartTime(firstName2, lastName2, phone2, rate);

            //Polymorphism Example: Write as little code as possible to solve
            // Create loop that looks for base class objects for an employee and return the ToString Objects that are inside
            // List collection

            List<Employee> lists = new List<Employee>();
            lists.Add(newEmp);
            lists.Add(newPT);


            foreach (Employee emp in lists)
            {
                Console.WriteLine(emp.ToString());
                //Call the RUNPAYROLL abstract method polymorphically.
                emp.RunPayroll();

            }

            Console.ReadKey();


        }
    }
}
