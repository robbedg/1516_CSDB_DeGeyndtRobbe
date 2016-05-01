using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObjects
{
    public interface IOPO
    {
        int id { get; set; }
        string code { get; set; }
        string name { get; set; }
        int stp { get; set; }
        Fase fase { get; set; }
        Semester sem { get; set; }
    }
}
