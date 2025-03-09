using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c;
            Console.WriteLine("Please Enter celsius Temprature");
            c = Convert.ToDouble(Console.ReadLine());
            double f;
            f = (c * 9 / 5) + 32;
            Console.WriteLine(" Your farenheit temperature {0} ", f);
            Console.ReadKey();

        }
    }
}
