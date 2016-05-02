using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Lecturer
    {
        [Key]
        public string number { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }

        //Standard Constructor
        public Lecturer()
        {

        }

        public Lecturer(string number, string firstname, string lastname)
        {
            this.number = number;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public override string ToString()
        {
            return lastname + " " + firstname;
        }
    }
}
