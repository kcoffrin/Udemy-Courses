using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Report
    {
        // These variables have scope within the entire class
        private string name;
        private string date;

        public Report(string name, string date, string type)
        {
            Name = name;
            Date = date;
            Type = type;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

       }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                // Make sure Incoming value == July, if true then set the value into the DATE variable. 
                // Way to control information and make sure values set in class variables are approprite. 
                if (value == "July")
                {
                    date = value;
                }
            }
        }

        public string Type
        {
            get;
            set;
        }

        //Public:  Accessor
        //Void:  Can modify variables and write to the console, does not return values
        // Name of the method
        //():  Parmeters
        public void ReportType()
        {
            // Does not require information to run, and does not return anything
            Console.WriteLine("This is a {0} report",Type);
        }

        //Two additional examples

        //Returns a string instead of a void.
        // have to use the Return keyword and return the data type or value that we are going to return in the header
        // Be prepared to accept what is being returned
        public string CreateReport()
        {
            return string.Format("I am creating the {0} report", Name);
        }

        // Have to pass an INT when calling the Method in order to run it. 
        
        public void ReportCount(int number)
        {
            // This variable only has scope and can only be seen within this method.
            int anotherNumber;
            Console.WriteLine("There are {0} lines in the report",number);
        }
    }

}
