using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String st;

            Console.WriteLine("enter you gender = ");
            st = Console.ReadLine();
            if (st.ToUpper() == "MALE")
                Console.WriteLine("he is male");
            else if (st.ToUpper() == "FEMALE")
                Console.WriteLine("she is female");
            else
                Console.WriteLine("Transgender");

            Console.ReadKey();
        }
    }
}
