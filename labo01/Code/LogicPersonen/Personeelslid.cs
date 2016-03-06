using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPersonen
{
    public abstract class Personeelslid : Persoon
    {
        protected string _personeelsnummer;

        //get personeelsnummer
        public string personeelsnummer
        {
            get { return _personeelsnummer; }
        }

        //empty constructor
        public Personeelslid() { }

        //constructor
        public Personeelslid(string naam, string voornaam, string personeelsnummer)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this._personeelsnummer = personeelsnummer;
        }
    }
}
