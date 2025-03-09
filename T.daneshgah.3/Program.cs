using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Please Enter a Number... ");
            A = Convert.ToInt32(Console.ReadLine());
            if (A < 10)
                if (A % 2 == 0)
                {
                    Console.WriteLine("Number shoma az 10 koochektar va zooj ast {0}", true);
                }
                else
                    Console.WriteLine("adad shoma zooj nist!...");


            if (A > 10)
            {

                Console.WriteLine("adad shoma az 10 koochektar nist!!!");
            }
            
            Console.ReadKey();


        }
    }
}
