using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 3;
            Console.WriteLine("a: {0}", a);
            a = 100; //assigment
            Console.WriteLine("a: {0}", a);
            a += b;
            Console.WriteLine("a: {0}", a);
            a -= b;
            Console.WriteLine("a: {0}", a);
            a *= b;
            Console.WriteLine("a: {0}", a);
            a /= b;
            Console.WriteLine("a: {0}", a);
            a %= b;
            Console.WriteLine("a: {0}", a);
            Console.ReadKey();
        }
    }
}
