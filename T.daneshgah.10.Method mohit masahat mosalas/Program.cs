using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._10.Method_mohit_masahat_mosalas
{
    internal class Program
    {
        static double MohitTriangle(Double a , Double b , Double c)
        {
            return a+b+c;
        }
        static double MasahatTriangle(Double a, Double b, Double c)
        {
            double s = (a + b + c) / 2;
            double Masahat = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            return Masahat;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mohit,masahat Triangle application!!!");

            Console.WriteLine("Please Enter First Side!!");
            double a =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Second Side!!");
            Double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Third Side!!");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && c + b > a)
            {
                double Mohit=MohitTriangle(a, b, c);
                double Masahat = MasahatTriangle(a, b,c);
                Console.WriteLine($"Your triangles mohit is {Mohit}");
                Console.WriteLine($"Your triangles Masahat is {Masahat}");
            }else
            {
                Console.WriteLine("the entered sides isnt create a triangle!!!!!!!!!!!!!!!!!");
            }
            Console.ReadKey();
        }
    }
}
