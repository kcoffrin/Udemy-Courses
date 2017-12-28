using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalMath
{
    class Program
    {
        static void Main(string[] args)
        {
            float aFloatingValue = 0.5F; //USE F to Denote Floating Value
            double aDoubleValue = 0.5;
            decimal aDecimalValue = 0.5M; // Use M for Decimal
            int aIntValue = 5;

            // This is legal: Floating and Double into Double
            double aDoubleSum = aFloatingValue + aDoubleValue;

            // Double and Float into an INT.  No issue 
            double aDoubleSum2 = aDoubleValue + aIntValue;

            double aDoubleSum3 = aFloatingValue + aIntValue;

            float aFloatSum = aFloatingValue + aIntValue;

            // Not Legal
            // Float and a Double and put them into a Float
            // OK if Double, not Float.  
            // Outcome could be larger then the Float can hold. 

            float aFloatSum2 = aFloatingValue + aDoubleValue;

            // Decimal and Int can be put into a Decimal Value. OK

            decimal aDecimalSum = aDecimalValue + aIntValue;

            // Not Legal. Float and Double into Decimal. 
            // Data types do not convert.  Would need to Cast or Convert

            decimal aDecimalSum2 = aFloatingValue + aDoubleValue;

            // Not Legal.  Float to a Decimal.  Different error
            // Doesnt know what to do with this.  Nothing will work.

            decimal aDecimalSum3 = aFloatingValue + aDecimalValue;


        }
    }
}
