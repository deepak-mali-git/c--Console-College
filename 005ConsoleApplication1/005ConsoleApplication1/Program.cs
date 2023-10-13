using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 0, b = 0;
                Console.WriteLine("enter a first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a second number");
                b = Convert.ToInt32(Console.ReadLine());

                int sum = a + b;
                Console.WriteLine("Addition of " + a + " and " + b + " is = " + sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
delegate