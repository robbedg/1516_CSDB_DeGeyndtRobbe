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
    public class OPO : IOPO, IEquatable<OPO>, IComparable
    {
        private string _code;
        private string naam;
        private int stp;
        private Docent verantwoordelijke = new Docent();
        private List<OLA> olas = new List<OLA>();
        private Semester sem = new Semester();
        private Fase fase = new Fase();

        //get code
        public string code
        {
            get { return _code; }
        }

        //Empty constructor
        public OPO() {}

        //Constructor
        public OPO(string code, string naam, int stp, Docent verantwoordelijke, List<OLA> olas, Semester sem, Fase fase)
        {
            this._code = code;
            this.naam = naam;
            this.stp = stp;
            this.verantwoordelijke = verantwoordelijke;
            this.olas = olas;
            this.sem = sem;
            this.fase = fase;
        }

        //IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            OPO other = obj as OPO;

            if (other != null)
            {
                return string.Compare(this._code, other._code, StringComparison.CurrentCultureIgnoreCase);
            }
            else
            {
                throw new ArgumentException("OPO is null.");
            }
        }

        //IEquatable
        public bool Equals(OPO other)
        {
            if (other != null)
            {
                return ((this._code.Equals(other._code)) && (this.naam.Equals(other.naam)) && (this.stp == other.stp) && (this.olas.Equals(other.olas)) && (this.sem.Equals(other.sem)) && (this.fase.Equals(other.fase)) && (this.verantwoordelijke.ToString().Equals(other.verantwoordelijke.ToString())));
            }
            else
            {
                throw new ArgumentException("Object is not OPO.");
            }
        }

        //Make hash for OPO
        public override int GetHashCode()
        {
            return this._code.GetHashCode() ^ this.naam.GetHashCode() ^ this.stp.GetHashCode() ^ this.verantwoordelijke.GetHashCode()
                ^ this.olas.GetHashCode() ^ this.sem.GetHashCode() ^ this.fase.GetHashCode();
        }

        //OPO to string
        public override string ToString()
        {
            return "[" + this._code + "] " + this.naam + " (" + this.stp + "STP)";
        }
    }
}
