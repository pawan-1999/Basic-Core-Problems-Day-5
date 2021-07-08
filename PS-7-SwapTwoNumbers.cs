using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_7_SwapTwoNumbers
    {
        public void swap()
        {
            int number1, number2, temp;
            Console.Write("\nEnter the First Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
        }
    }
}

 static void Main(string[] args)
        {
            PS_7_SwapTwoNumbers obj7 = new PS_7_SwapTwoNumbers();
            obj7.swap();
        }
