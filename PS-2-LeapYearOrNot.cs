using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_2_LeapYearOrNot
    {
        public void checkLeapOrNot()
        {
            string a1;
            int year;
            Console.WriteLine("Enter a Year which must be of 4 digits : ");

            a1 = Console.ReadLine();
            year = Convert.ToInt32(a1);

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}

static void Main(string[] args)
        {
            PS_2_LeapYearOrNot obj2 = new PS_2_LeapYearOrNot();
            obj2.checkLeapOrNot();
        }
