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
        //List of olas
        private List<OLA> _olas = new List<OLA>();

        //get olas
        public List<OLA> olas
        {
            get { return _olas; }
        }

        //Empty constructor
        public Docent() {}

        //Constructor without OLA-list
        public Docent(string naam, string voornaam, string personeelsnummer)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this._personeelsnummer = personeelsnummer;
        }

        //Constructor with OLA-list
        public Docent(string naam, string voornaam, string personeelsnummer, List<OLA> olas)
        {
            this.naam = naam;
            this.voornaam = voornaam;
            this._personeelsnummer = personeelsnummer;
            this._olas = olas;
        }

        //Add OLA-list
        public void VoegOLAsToe(List<OLA> olas)
        {
            //Only copy new items.
            List<OLA> cobined = new List<OLA>(this._olas.Union(olas).ToList());
            this._olas = cobined;
        }
    }
}
