using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPersonen
{
    public abstract class Persoon
    {
        protected string naam;
        protected string voornaam;

        public Persoon()
        {

        }

        public Persoon(string naam, string voornaam)
        {
            this.naam = naam;
            this.voornaam = voornaam;
        }
        
        public override string ToString()
        {
            return naam + " " + voornaam;
        }
    }
}
