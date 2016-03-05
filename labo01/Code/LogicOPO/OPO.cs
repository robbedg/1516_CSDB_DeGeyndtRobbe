using Enums;
using ILogicOPO;
using LogicOLA;
using LogicPersonen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOPO
{
    public class OPO : IOPO, IComparable
    {
        private string code;
        private string naam;
        private int stp;
        private Docent verantwoordelijke;
        private List<OLA> olas;
        private Semester sem;
        private Fase fase;

        public OPO()
        {

        }

        public OPO(string code, string naam, int stp, Docent verantwoordelijke, List<OLA> olas, Semester sem, Fase fase)
        {
            this.code = code;
            this.naam = naam;
            this.stp = stp;
            this.verantwoordelijke = verantwoordelijke;
            this.olas = olas;
            this.sem = sem;
            this.fase = fase;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            OPO other = obj as OPO;

            if (other != null)
            {
                return string.Compare(this.code, other.code, StringComparison.CurrentCultureIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Object is not OPO.");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            OPO other = obj as OPO;

            if (other != null)
            {
                return ((this.code.Equals(other.code)) && (this.naam.Equals(other.naam)) && (this.stp == other.stp) && (this.olas.Equals(other.olas)) && (this.sem.Equals(other.sem)) && (this.fase.Equals(other.fase)) && (this.verantwoordelijke.ToString().Equals(other.verantwoordelijke.ToString())));
            }
            else
            {
                throw new ArgumentException("Object is not OPO.");
            }
        }

        public override string ToString()
        {
            return "[" + this.code + "] " + this.naam + " " + this.stp + "STP";
        }
    }
}
