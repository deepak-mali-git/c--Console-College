using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //input a character and check whether it is vowel or consonant 
            //but before it - check input character is an aplhabet or not
            char ch;
            Console.Write("Enter a character: ");
            ch = Console.ReadLine()[0];
            //check ch is an alphabet or not
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                Console.WriteLine("{0} is a valid alphabet", ch);
                //checking for vowel or consonant
                if (ch == 'A' || ch == 'a' || ch == 'E' || ch == 'e' ||
                ch == 'I' || ch == 'i' || ch == 'O' || ch == 'o' ||
                ch == 'U' || ch == 'u')
                {
                    Console.WriteLine("{0} is a vowel", ch);
                }
                else
                {
                    Console.WriteLine("{0} is a consonant", ch);
                }
            }
            else
            {
                Console.WriteLine("{0} is not a valid alphabet", ch);
            }
            //hit ENTER to exit the program
            Console.ReadKey();
        }
    }
}
