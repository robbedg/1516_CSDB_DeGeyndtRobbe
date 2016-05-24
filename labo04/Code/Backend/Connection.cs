using MongoDB.Driver;
using Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    //Connection with MongoDB
    public class Connection
    {
        private MongoClient Client { get; set; }
        private IMongoDatabase DB { get; set; }
        public IMongoCollection<Student> Students { get; set; }
        public IMongoCollection<Course> Courses { get; set; }
        public Connection(string connectionstring)
        {
            Client = new MongoClient(connectionstring);
            DB = Client.GetDatabase("csharpdblab04");
            Students = DB.GetCollection<Student>("students");
            Courses = DB.GetCollection<Course>("courses");
        }
    }
}
