using System;
using System.IO;

namespace EvenFile24
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\202\101.txt",FileMode.OpenOrCreate,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);


            for (int i = 10; i < 100; i += 2)
                sw.WriteLine(i);

            sw.Close();
            fs.Close();
            Console.WriteLine("FINISHED!!!!!");

            FileStream f1 = new FileStream(@"C:\202\101.txt", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(f1);

            string s = sr.ReadToEnd();

            Console.WriteLine(s);
            f1.Close();

            Console.ReadKey();
        }
    }
}
