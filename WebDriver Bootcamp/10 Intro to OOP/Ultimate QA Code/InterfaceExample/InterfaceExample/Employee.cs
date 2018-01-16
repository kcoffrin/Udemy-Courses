using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Employee : IPayable
    {
        public Employee(string first, string last, string phone, decimal salary)
        {
            FirstName = first;
            LastName = last;
            PhoneNo = phone;
            Salary = salary;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string PhoneNo
        {
            get;
            set;
        }

        public decimal Salary
        {
            get;
            set;
        }

        public decimal GetPaymentAmount()
        {
            return Salary;
        }

        //public sealed virtual void RunPayroll()
        //{
        //    Console.WriteLine("Base class payroll method");
        //}


    }
}
