using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declare an integer variable
            int num = 0;
            //prompt message to take input
            Console.Write("Input an integer value: ");
            num = Convert.ToInt32(Console.ReadLine());
            //print the value
            Console.WriteLine("num = " + num);
            Console.ReadKey();
        }
    }
}
