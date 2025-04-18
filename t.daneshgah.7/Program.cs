using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t.daneshgah._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 7, n;

            do
            {
                Console.WriteLine(" n: ");
                n = Int32.Parse(Console.ReadLine());
                p = p * n;

            } while (n != 3);
            Console.WriteLine("p: " + p);
            Console.ReadKey();
        }
    }
}
