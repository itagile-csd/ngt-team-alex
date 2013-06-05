using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        private Dictionary<int, int> ergebnis = new Dictionary<int, int>();
        public int AnzahlSchlaege
        {
            get { return ergebnis[Lochnummer]; }
            private set { ergebnis[Lochnummer] = value; } 
        }

        public int Lochnummer
        {
            get { return ergebnis.Count; }
                     
            private set
            {
                ergebnis.Add(value, 0);
            }
        }
        public int GesamtAnzahlSchlaege { get { return ergebnis.Values.Sum(); } }
        public Dictionary<int, int> ErgebnisZurueck
        {
            get { return ergebnis; }
        }

        public EinfacheScorecard()
        {
            Lochnummer = 1; 
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
            ergebnis[Lochnummer] = AnzahlSchlaege;
        }
    }
}