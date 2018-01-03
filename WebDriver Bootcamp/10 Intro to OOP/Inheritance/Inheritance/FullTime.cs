using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    


    //As this is a derived class you need to let the C# compiler know about the relationship. specify where this class inherits from
    // Do this by putting a ":" after the class name and giving the class which this inherits from
    class FullTime: Employee
    {
        // Constructor:  Gather all ifnormation for our own and our base class constructor
        // Constructor:  Goes inside of the class
        public FullTime(string first, string last, string phone, decimal salary, int vacation)
        //Calls base classes constructor, allows you to access base class members from a derived class
        // Pass three pieces of information accepting from our constructor here and passed back to the base class
        :base(first, last, phone)
        {
           
            SalaryRate = salary;
            VacationDays = vacation;

        }
        public decimal SalaryRate { get; set; }
        public int VacationDays { get; set; }

        public override string ToString()
        {
            // Print out information to the console, form, information about the object
            // Override allows to specifiy our own

            // Example:  In Full Time Class, have access to base class objects
            return FirstName + " " + LastName + " is full time";
        }

        public override void RunPayroll()
        {
            Console.WriteLine("This employee's salary is {0:C}", SalaryRate);
        }
    }
}
