using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //As this is a derived class you need to let the C# compiler know about the relationship. specify where this class inherits from
    // Do this by putting a ":" after the class name and giving the class which this inherits from
    class PartTime : Employee
    {
        public PartTime(string first, string last, string phone, decimal rate)
        :base(first, last, phone)
        {
            HourlyRate = rate;
        }
        public decimal HourlyRate { get; set; }

        public override string ToString()
        {
            // Print out information to the console, form, information about the object
            // Override allows to specifiy our own

            // Example:  In Full Time Class, have access to base class objects
            return FirstName + " " + LastName + " is part time";
        }
    }
}
