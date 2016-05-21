using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public List<Course> Courses { get; set; }

        public Student()
        {
            this.Courses = new List<Course>();
        }

        public Student(int id, string name, string year)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Courses = new List<Course>();
        }

        public Student(int id, string name, string year, List<Course> courses)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Courses = courses;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
