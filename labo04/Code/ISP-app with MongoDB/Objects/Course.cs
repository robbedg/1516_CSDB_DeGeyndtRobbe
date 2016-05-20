using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }


        public Course() { }

        public Course(int id, string name, string year)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
        }
    }
}
