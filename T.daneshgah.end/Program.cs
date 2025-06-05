using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace T.daneshgah.end
{
    internal class Program
    {
        class Student
        {
            public string StudentId { get; set; }
            public string Name { get; set; }
            public string Major { get; set; }
        }


            static void Main(string[] args)
            {
                // نمایش مسیر ذخیره‌سازی فایل‌ها
                Console.WriteLine($"Masir Zakhireh sazi: {Directory.GetCurrentDirectory()}\n");

                while (true)
                {
                    Console.WriteLine("***Samaneh Modiriat Daneshjoo***");
                    Console.WriteLine("1.Vorod Etelaat Daneshjoo.");
                    Console.WriteLine("2.Namayesh Etelaat Daneshjoo");
                    Console.WriteLine("3.Hazf Daneshjoo");
                    Console.WriteLine("4. Exit");
                    Console.Write("Lotfan yek gozineh entekhab konid: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddStudent();
                            break;
                        case "2":
                            ShowStudent();
                            break;
                        case "3":
                            RemoveStudent();
                            break;
                        case "4":
                            Console.WriteLine("Khorooj az barname..");
                            return;
                        default:
                            Console.WriteLine("Gozineh namotabar!");
                            break;
                    }
                }
            }

            static void AddStudent()
            {
                Console.WriteLine("\n***Vorood Etelaat daneshjoo***");

                Student student = new Student();

                Console.Write("Shomareh daneshjooyi ra vared konid: ");
                student.StudentId = Console.ReadLine().Trim();

                // بررسی شماره دانشجویی
                if (string.IsNullOrEmpty(student.StudentId))
                {
                    Console.WriteLine("Shomareh Daneshjooyi nemitavanad Khali Bemanad!");
                    return;
                }

                string fileName = $"{student.StudentId}.txt";

                if (File.Exists(fileName))
                {
                    Console.WriteLine("Daneshjoo ba in moshakhasat qablan vared shodeh adt!");
                    return;
                }

                Console.Write("Name Daneshjoo ra vared konid: ");
                student.Name = Console.ReadLine().Trim();

                Console.Write("Reshteh tahsili ra vared konid: ");
                student.Major = Console.ReadLine().Trim();

                // ذخیره اطلاعات در فایل
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine($"Shomareh Daneshjoooyi: {student.StudentId}");
                        writer.WriteLine($"FullName: {student.Name}");
                        writer.WriteLine($"Reshteh tahsili: {student.Major}");
                    }
                    Console.WriteLine($"Etelaat Daneshjoo dar File {fileName} ba movafaqiat sabt shod.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Khata dar zakhireh etelaat!: {ex.Message}");
                }
            }

            static void ShowStudent()
            {
                Console.WriteLine("\n***Namayesh Etelaat Daneshjoo***");

                Console.Write("Shomareh Daneshjooyi ra vared konid: ");
                string studentId = Console.ReadLine().Trim();

                string fileName = $"{studentId}.txt";

                try
                {
                    if (File.Exists(fileName))
                    {
                        Console.WriteLine("\nEtelaat Daneshjoo:");
                        using (StreamReader reader = new StreamReader(fileName))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Daneshjoo ba in Etelaat yaft nashod!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Khata dar khandan etelaat : {ex.Message}");
                }
            }

            static void RemoveStudent()
            {
                Console.WriteLine("\n***Hazf Daneshjoo***");

                Console.Write("Shomareh Daneshjooyi ra vared Konid: ");
                string studentId = Console.ReadLine().Trim();

                string fileName = $"{studentId}.txt";

                try
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                        Console.WriteLine("Etelaat Daneshjoo ba movafaqiat hazf shod.");
                    }
                    else
                    {
                        Console.WriteLine("Daneshjoo ba in etelaat yaft nashod!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Khata dar hazf etelaat!: {ex.Message}");
                }
            }
        
    }
}
