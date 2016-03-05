using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicOLA
{
    public interface IOLA
    {
        int CompareTo(Object obj);
        bool Equals(Object obj);
        string ToString();
    }
}
