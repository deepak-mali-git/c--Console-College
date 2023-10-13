using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.Write("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            int large = (a > b) ? a : b;
            Console.WriteLine("Largest number is {0}", large);
            Console.ReadKey();
        }
    }
}
