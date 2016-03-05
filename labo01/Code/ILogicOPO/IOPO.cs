using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicOPO
{
    public interface IOPO
    {
        int CompareTo(Object obj);
        bool Equals(Object obj);
        string ToString();
    }
}
