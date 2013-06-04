using System.Collections.Generic;

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
        public int Lochnummer { get; private set; }
        public Dictionary<int, int> ErgebnisZurueck
        {
            get { return ergebnis; }
        }

        public EinfacheScorecard()
        {
            Lochnummer = 1;
            ergebnis.Add(Lochnummer, 0);
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
            ergebnis.Add(Lochnummer, 0);
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
            ergebnis[Lochnummer] = AnzahlSchlaege;
        }
    }
}