using LogicOLA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILogicPersonen
{
    public interface IDocent
    {
        string personeelsnummer { get; }
        List<OLA>olas { get; }
        void VoegOLAsToe(List<OLA> olas);
        string ToString();
    }
}
