using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t.daneshgah_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 7");
            int a = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Emrooz shanbeh ast");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Emrooz yekshanbeh ast");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Emrooz doshanbeh ast");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Emrooz seshanbeh ast");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Emrooz chaharshanbeh ast");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Emrooz panjshanbeh ast");
                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("Emrooz jomeh ast");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("END!");
                    }
                    break;

                
            }
        }
    }
}
