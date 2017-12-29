using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethods
{
    static class Helper 
    {
        public static int number;

        public static void Sum(int aNumber)
        {
            number += aNumber;
        }
    }
}
