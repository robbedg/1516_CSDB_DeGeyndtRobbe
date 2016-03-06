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

        public Personeelslid(string naam, string voornaam, string personeelsnummer)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this.personeelsnummer = personeelsnummer;
        }

        public override string ToString()
        {
            return "[" + this.personeelsnummer + "] " + this.naam + " " + this.voornaam;
        }
    }
}
