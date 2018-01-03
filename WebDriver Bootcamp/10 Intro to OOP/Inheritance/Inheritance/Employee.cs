using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
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
    }
}
