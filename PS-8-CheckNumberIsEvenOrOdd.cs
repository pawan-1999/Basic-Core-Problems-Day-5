using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_8_CheckNumberIsEvenOrOdd
    {
        public void checkEvenOrOdd()
        {
            Console.WriteLine("Enter a Number : "); 
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
                Console.WriteLine(numb+" is Even Number");
            else
                Console.WriteLine(numb+ " is Odd Number");
        }
    }
}

static void Main(string[] args)
        {
            PS_8_CheckNumberIsEvenOrOdd obj8 = new PS_8_CheckNumberIsEvenOrOdd();
            obj8.checkEvenOrOdd();
        }
