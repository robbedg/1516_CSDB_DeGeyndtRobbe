using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class OPO
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int stp { get; set; }
        public Lecturer coordinator { get; set; }
        public Fase fase { get; set; }
        public Semester sem { get; set; }

        //Constructor
        public OPO()
        {
            //Standard constructor
        }

        //Non-standard constructor
        public OPO(int id, string code, string name, int stp, Lecturer coordinator, Fase fase, Semester sem)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.stp = stp;
            this.coordinator = coordinator;
            this.fase = fase;
            this.sem = sem;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
