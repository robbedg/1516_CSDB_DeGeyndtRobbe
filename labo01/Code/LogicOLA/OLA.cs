using ILogicOLA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOLA
{
    public class OLA : IOLA, IComparable
    {
        private string code;
        private string naam;
        private int stp;

        public OLA()
        {

        }

        public OLA(string code, string naam, int stp)
        {
            this.code = code;
            this.naam = naam;
            this.stp = stp;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            OLA other = obj as OLA;

            if (other != null)
            {
                return string.Compare(this.code, other.code, StringComparison.CurrentCultureIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Object is not OLA.");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            OLA other = obj as OLA;

            if (other != null)
            {
                return ((this.code.Equals(other.code)) && (this.naam.Equals(other.naam)) && (this.stp == other.stp));
            }
            else
            {
                throw new ArgumentException("Object is not OLA.");
            }
        }

        public override string ToString()
        {
            return "[" + this.code + "] " + this.naam + " " + this.stp + "STP";
        }
    }
}
