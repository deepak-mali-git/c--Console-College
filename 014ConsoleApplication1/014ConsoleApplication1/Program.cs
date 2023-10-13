using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter an integer number: ");
            number = Convert.ToInt32(Console.ReadLine());
            //checking conditions
            if (number > 0)
                Console.WriteLine("{0} is a positive number", number);
            else if (number < 0)
                Console.WriteLine("{0} is a negative number", number);
            else
                Console.WriteLine("{0} is a Zero", number);
            //hit ENTER to exit the program
            Console.ReadLine();
        }
    }
}
