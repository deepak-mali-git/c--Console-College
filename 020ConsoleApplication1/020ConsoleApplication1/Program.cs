using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
             char ch;
             Console.Write("Enter a character: ");
             ch = Console.ReadLine()[0];
             if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
              {
              switch (ch)
               {
            case 'A':
            case 'a':
            case 'E':
            case 'e':
            case 'I':
            case 'i':
            case 'O':
            case 'o':
            case 'U':
            case 'u':
                Console.WriteLine("Input character {0} is a Vowel", ch);
                break;
            default:
                Console.WriteLine("Input character {0} is a Consonat", ch);
                break;
               }
              }
             else
             {
                 Console.WriteLine("Input character {0} is not a valid alphabet", ch);
             }
             //hit ENTER to exit the program
             Console.ReadLine();

        }
    }
}
