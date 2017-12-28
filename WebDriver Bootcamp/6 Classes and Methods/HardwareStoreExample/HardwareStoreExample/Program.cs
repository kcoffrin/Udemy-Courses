using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // create instance of object for constructor: Object Creation statement
            // As the values are not provided by the user, going to hard code them for the example
            // Remember, Decimal values need to have the M to identify them as that data type.
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 15.95M);

            // Display Invoice
            Console.WriteLine("Original Invoice Information");
            Console.WriteLine("Part Number: {0}",invoice1.PartNumber);
            Console.WriteLine("Part Description: {0}", invoice1.PartDescription);
            Console.WriteLine("Quantity: {0}",invoice1.Quantity);
            //added :C to put this into a currency format
            Console.WriteLine("Price: {0:C}", invoice1.Price);
            Console.WriteLine("Invoice Total: {0:C}", invoice1.GetInvoiceAmount());

        }
    }
}
