using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntekhabVahed
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public List<string> Courses { get; set; }

        public Student(string id, string name, string family, List<string> courses)
        {
            Id = id;
            Name = name;
            Family = family;
            Courses = courses;
        }

        public override string ToString()
        {
            return $"{Id},{Name},{Family},{string.Join("|", Courses)}";
        }
    }
}
