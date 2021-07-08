using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_10_LongestAmongThreeNumber
    {
        public void checkLargestNumber()
        {
            Console.WriteLine("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int thirdNum= Convert.ToInt32(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)
            {
                Console.WriteLine(firstNum+ " is the largest among entered three numbers");
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                Console.WriteLine(secondNum+ " is the largest among entered three numbers");
            }
            else if (thirdNum > firstNum && thirdNum > secondNum)
            {
                Console.WriteLine(thirdNum+ " is the largest among entered three numbers");
            }
            else
            {
                Console.WriteLine("All three entered  numbers are equal");
            }
        }
    }
}

static void Main(string[] args)
        {
            PS_10_LongestAmongThreeNumber obj10 = new PS_10_LongestAmongThreeNumber();
            obj10.checkLargestNumber();
        }
