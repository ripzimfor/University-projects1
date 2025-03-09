using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t.daneshgah._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
        
            Console.WriteLine("Please Enter Shoaa");
            r = Convert.ToDouble(Console.ReadLine());
            double masahat;
            masahat = 3.14 * (r * r);
            Console.WriteLine("masahat daiere shoma {0} ast",masahat);
            double mohit;
            mohit = r * 2 * (3.14);
            Console.WriteLine("mohit daiere shoma {0} ast", mohit);
            Console.ReadKey();

        }
    }
}
