using Backend;
using MongoDB.Driver;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Manipulations
    {
        public Connection MongoDBConnection { get; set; }

        public Manipulations()
        {
            MongoDBConnection = new Connection("mongodb://student:Azerty123@ds011382.mlab.com:11382/csharpdblab04");
        }

        public void AddStudent(Student student)
        {
            MongoDBConnection.Students.InsertOne(student);
        }

        public void AddCourse(Course course)
        {
            MongoDBConnection.Courses.InsertOne(course);
        }

        public Student GetStudentOnName(string name)
        {
            List<Student> studenten = new List<Student>();

            var filteredStudenten = from student in MongoDBConnection.Students.AsQueryable()
                                    where student.Name.ToLower().Contains(name.ToLower())
                                    select student;

            foreach (Student x in filteredStudenten) studenten.Add(x);

            if (studenten.Count != 1) throw new Exception("Error: Incorrect amount of results.");

            return studenten.First();
        }

        public Student GetStudentOnID(int id)
        {
            List<Student> studenten = new List<Student>();

            var filteredStudenten = from student in MongoDBConnection.Students.AsQueryable()
                                    where student.Id.Equals(id)
                                    select student;

            foreach (Student x in filteredStudenten) studenten.Add(x);

            if (studenten.Count != 1) throw new Exception("Error: Incorrect amount of results.");

            return studenten.First();
        }

        public Course GetCourseOnName(string name)
        {
            List<Course> courses = new List<Course>();

            var filteredCourses = from course in MongoDBConnection.Courses.AsQueryable()
                                  where course.Name.ToLower().Contains(name.ToLower())
                                  select course;

            foreach (Course x in filteredCourses) courses.Add(x);

            if (courses.Count != 1) throw new Exception("Error: Incorrect amount of results.");

            return courses.First();
        }

        public Course GetCourseOnID(int id)
        {
            List<Course> courses = new List<Course>();

            var filteredCourses = from course in MongoDBConnection.Courses.AsQueryable()
                                  where course.Id.Equals(id)
                                  select course;

            foreach (Course x in filteredCourses) courses.Add(x);

            if (courses.Count != 1) throw new Exception("Error: Incorrect amount of results.");

            return courses.First();
        }

        public void UpdateStudent(Student student)
        {
            var filter = Builders<Student>.Filter.Eq("Id", student.Id);
            var update = Builders<Student>.Update.Set("Name", student.Name).Set("Year", student.Year);
            MongoDBConnection.Students.UpdateOne(filter, update);
        }

        public void UpdateCourse(Course course)
        {
            var filter = Builders<Course>.Filter.Eq("Id", course.Id);
            var update = Builders<Course>.Update.Set("Name", course.Name).Set("Year", course.Year);
            MongoDBConnection.Courses.UpdateOne(filter, update);
        }
    }
}
