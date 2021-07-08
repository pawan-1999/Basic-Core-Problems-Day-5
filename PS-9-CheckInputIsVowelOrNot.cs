using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class PS_9_CheckInputIsVowelOrNot
    {
        public void checkVowelOrNot()
        {
            Console.WriteLine(" Enter a character : ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U' || ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch+" is a Vowel ");
            }
            else if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine(ch+ " is a Consonant ");
            }
            else
            {
                Console.WriteLine(ch+ " not an Alphabate");
            }
        }
    }
}

static void Main(string[] args)
        {
            PS_9_CheckInputIsVowelOrNot obj9 = new PS_9_CheckInputIsVowelOrNot();
            obj9.checkVowelOrNot();
        }
