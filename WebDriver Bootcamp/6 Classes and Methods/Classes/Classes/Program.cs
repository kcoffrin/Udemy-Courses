using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "July Quarterly Report";
            string date = "July";
            string type = "Quarterly";

            // Object creation statement
            // From constructor in Report Class
            Report myReport = new Report(name, date, type);

            //Once you have an instance of a object, you can access all methods within as long as they are public
            // Taken quarterly information from Type, passing it to the constructor, placing it into public property and then writing out the statement
            myReport.ReportType();

            Console.WriteLine(myReport.CreateReport());

            //Need to provide the 5 here as this is the integer that we are passing, if not will error. 
            myReport.ReportCount(5);

        }
    }
}
