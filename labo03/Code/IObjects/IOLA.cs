using IObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IObjects
{
    public interface IOLA
    {
        int id { get; set; }
        string code { get; set; }
        string name { get; set; }
        int stp { get; set; }
        OPO opo { get; set; }
    }
}
