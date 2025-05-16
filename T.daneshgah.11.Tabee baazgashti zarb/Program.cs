using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._11.Tabee_baazgashti_zarb
{
    internal class Program
    {
        static int Multiply(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            if (b > 0)
            {
                return a + Multiply(a, b - 1);
            }else
                return -Multiply(a,-b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mohasebeh haselzarb 2 adad ba tabee bazgashti ");
            Console.WriteLine();
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result= Multiply(num1, num2);
            Console.WriteLine($"Haselzarb {num1} * {num2} = {result}");

            Console.ReadKey();

        }
    }
}
