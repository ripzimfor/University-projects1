using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            Console.WriteLine("Please Enter a Number");
            A = Convert.ToInt32(Console.ReadLine());
            if (A % 7 == 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                int Result = A * 3;
                Console.WriteLine("adad vared shode mazrab 7 nist va dar 3 zarb shod = {0}", Result);
            }

            Console.ReadKey();




        }
    }
}