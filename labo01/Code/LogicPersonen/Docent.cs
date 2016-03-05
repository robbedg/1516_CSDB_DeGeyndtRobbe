using ILogicPersonen;
using LogicOLA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPersonen
{
    public class Docent : Personeelslid, IDocent
    {
        private List<OLA> olas;

        public Docent()
        {

        }

        public Docent(List<OLA> olas)
        {
            this.olas = olas;
        }

        public void VoegOLAsToe(List<OLA> olas)
        {

        }
    }
}
