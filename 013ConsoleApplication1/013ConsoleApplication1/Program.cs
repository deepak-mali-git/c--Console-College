using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter a first number = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a first number = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
                Console.WriteLine("{0} is divisible by {1}", a, b);
            else
                Console.WriteLine("{0} is not divisible by {1}", a, b);

            Console.ReadKey();
        }
    }
}
