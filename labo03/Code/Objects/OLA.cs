using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class OLA
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int stp { get; set; }
        public OPO opo { get; set; }
        public List<Lecturer> lecturers { get; set; }

        //Standard Constructor
        public OLA()
        {

        }

        //non-standard Constructor
        public OLA(int id, string code, string name, int stp, OPO opo, List<Lecturer> lecturers)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.stp = stp;
            this.opo = opo;
            this.lecturers = lecturers;
        }
    }
}
