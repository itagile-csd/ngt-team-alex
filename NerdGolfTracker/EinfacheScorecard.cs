using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        private Dictionary<int, int> ergebnis = new Dictionary<int, int>();
        public int AnzahlSchlaege { get; private set; }
        public int Lochnummer { get; private set; }
        public Dictionary<int, int> ErgebnisZurueck
        {
            get { return ergebnis; }
        }

        public EinfacheScorecard()
        {
            ergebnis.Add(1,4);
            ergebnis.Add(2, 5);
            ergebnis.Add(3, 4);
            Lochnummer = 1;
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
            AnzahlSchlaege = 0;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AnzahlSchlaege++;
        }
    }
}