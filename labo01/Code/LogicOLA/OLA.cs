using ILogicOLA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOLA
{
    public class OLA : IOLA, IEquatable<OLA>, IComparable
    {
        private string _code;
        private string naam;
        private int stp;

        //get code
        public string code
        {
            get { return _code; }
        }

        //empty constructor
        public OLA() {}

        //constructor
        public OLA(string code, string naam, int stp)
        {
            this._code = code;
            this.naam = naam;
            this.stp = stp;
        }

        //IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            OLA other = obj as OLA;

            if (other != null)
            {
                return string.Compare(this._code, other._code, StringComparison.CurrentCultureIgnoreCase);
            }
            else
            {
                throw new ArgumentException("Object is not OLA.");
            }
        }

        //IEquatable
        public bool Equals(OLA other)
        {
            if (other != null)
            {
                return ((this._code.Equals(other._code)) && (this.naam.Equals(other.naam)) && (this.stp == other.stp));
            }
            else
            {
                throw new ArgumentException("OLA is null");
            }
        }

        //Make hashcode for OLA
        public override int GetHashCode()
        {
            return _code.GetHashCode() ^ naam.GetHashCode() ^ stp.GetHashCode();
        }

        //OLA To string
        public override string ToString()
        {
            return "[" + this._code + "] " + this.naam + " (" + this.stp + "STP)";
        }
    }
}
