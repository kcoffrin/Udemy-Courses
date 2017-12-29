using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            // Provides a way to store different data types
            // Will dynamically change size based on items we are holding

            // Delcaration statement
            // LIST<Data Type to Hold> Name = new List<Data Type again>();
            // No information needed in ();
            List<string> items = new List<string>();

            //Name of item.ADD(items)
            items.Add("Widgets");
            items.Add("Doodles");
            items.Add("Thingys");

            // Data Item, in collection name to print list
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
            // Count always knows how many items are in the list at all times. 
            Console.WriteLine("There are {0} items in the list", items.Count);

            // use this to remove with .Remove
            // followed by the item name to be removed
            items.Remove("Widgets");


            Console.WriteLine("There are {0} items in the list", items.Count);

        }
    }
}
