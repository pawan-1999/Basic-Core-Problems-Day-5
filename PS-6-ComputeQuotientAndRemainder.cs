using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_6_ComputeQuotientAndRemainder
    {
        public void division()
        {
            Console.WriteLine("Enter the Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend: "+dividend+ " Divisor: "+divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}

static void Main(string[] args)
        {
            PS_6_ComputeQuotientAndRemainder obj6 = new PS_6_ComputeQuotientAndRemainder();
            obj6.division();            
        }
