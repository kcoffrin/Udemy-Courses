using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreExample
{
    public class Invoice
    {
        //private variables
        private int quantity;
        private decimal price;

        //constructor
        public Invoice(string part, string desc, int qty, decimal price)
        {
            PartNumber = part;
            PartDescription = desc;
            Quantity = qty;
            Price = price;
        }

        //public properties
        // Not uncommon to see inline when using auto implemented properties
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                //Ensure they are entering only positve numbers
                //Set to >=0 to do this
                if (value >= 0)
                {
                    quantity = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                //Ensure they are entering only positve numbers
                //Set to >=0 to do this
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public decimal GetInvoiceAmount()
        {
            return Quantity * Price;
        }
    }
}
