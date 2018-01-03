using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Employee
    {
        // Constructor:  needs to be public and the same name as the class
        public Employee(string first, string last, string phone)
        {
            FirstName = first;
            LastName = last;
            PhoneNo = phone;
        }
        // Automatically Implmented Properties
        // Make sure they are public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }

        // Adjusted to Virtual by changing Override to Virtual in method instantiation
        // Need to provide basic implementation for our base class
        // Need implementation in base class to be specific, not always possible

        public virtual void RunPayroll()
        {
            Console.WriteLine("Base class payroll method");
        }
    }
}
