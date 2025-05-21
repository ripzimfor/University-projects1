using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.daneshgah._12
{
    class Student
    {
        public string StudentID;
        public string Name;
        public int Age;
        public string Field;
        public Student(string Studentid, string name, int age, string field)
        {
            StudentID = Studentid;
            Name = name;
            Age = age;
            Field = field;
        }
        public void ShowInfo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($" ID: {StudentID},");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Field: {Field}");
            Console.WriteLine("-----------------------");
        }
    }
    internal class Program
    {
        static Dictionary<string, Student> studentDict = new Dictionary<string, Student>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("----------Student Management-----------");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show all Students");
                Console.WriteLine("3. Remove student");
                Console.WriteLine("4. EXIT");
                Console.WriteLine("Select an option 1-4: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowAllStudents();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }
            }
        }
         static void AddStudent()
    {
        Console.Write("Enter student Id: ");
        string id = Console.ReadLine();
        if (studentDict.ContainsKey(id))
        {
            Console.WriteLine("A student with this ID Already Exists....");
            return;
        }
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Field: ");
        string field = Console.ReadLine();

        Student s = new Student(id, name, age, field);
        studentDict[id] = s;

        Console.WriteLine("Student added successfully.");
    }
    static void ShowAllStudents()
    {
        if (studentDict.Count == 0)
        {
            Console.WriteLine("No students to show.");
            return;
        }

        Console.WriteLine("\n--- Student List ---");
        foreach (var student in studentDict.Values)
        {
            student.ShowInfo();
        }
    }

    static void RemoveStudent()
    {
        Console.Write("Enter Student ID to remove: ");
        string id = Console.ReadLine();

        if (studentDict.Remove(id))
        {
            Console.WriteLine("Student removed successfully.");
        }
        else
        {
            Console.WriteLine("Student ID not found.");
        }
    }
    }
   
}
