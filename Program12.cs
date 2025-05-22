using System;
using System.IO;

namespace _5NumberFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:/202/121.txt", FileMode.Create, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter Five Number:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a Number:");
                string a = Console.ReadLine();
                sw.WriteLine(a);
            }
            sw.Close();
            fs.Close();
            FileStream f1 = new FileStream(@"C:/202/121.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(f1);
            int sum = 0;

            while (!sr.EndOfStream)
            {
                int a = Int32.Parse(sr.ReadLine());

                sum += a;
            }
            Console.WriteLine("Sum = " + sum);
            f1.Close();
        }
    }
}
