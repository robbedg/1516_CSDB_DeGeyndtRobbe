using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPersonen
{
    public abstract class Personeelslid : Persoon
    {
        protected string personeelsnummer;

        public Personeelslid()
        {

        }

        public Personeelslid(string personeelsnummer)
        {
            this.personeelsnummer = personeelsnummer;
        }

        public override string ToString()
        {
            return "[" + this.personeelsnummer + "] " + naam + " " + voornaam;
        }
    }
}
