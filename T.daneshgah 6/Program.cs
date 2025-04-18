using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                // چاپ حرف I
                Console.WriteLine("حرف I:");
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0 || i == 4)
                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("  *  ");
                }

                // چاپ حرف H
                Console.WriteLine("\nحرف H:");
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("*   *");
                }

                // چاپ حرف E
                Console.WriteLine("\nحرف E:");
                for (int i = 0; i < 5; i++)
                {
                    if (i == 0 || i == 2 || i == 4)
                        Console.WriteLine("*****");
                    else
                        Console.WriteLine("*    ");
                }
            Console.ReadKey();
        }
    }
}
