using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPayable[] payableObjects = new IPayable[4];

            payableObjects[0] = new Invoice("2222", "Nails", 10, 9.99M);
            payableObjects[1] = new Invoice("4545", "Ladder", 2, 29.99M);
            payableObjects[2] = new Employee("Sara", "Jones", "555-555-5555", 45000M);
            payableObjects[3] = new Employee("John", "Brown", "545-555-3456", 60000M);

            foreach(var currentPayable in payableObjects)
            {
                Console.WriteLine("Payment due: {0:C}", currentPayable.GetPaymentAmount());
            }


        }
    }
}
