using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 15);
            //wait to hit any key to exit the program
            Console.ReadKey();
        }
    }
}
