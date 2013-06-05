using System.Collections.Generic;

namespace NerdGolfTracker
{
    public interface IScorecard
    {
        int AnzahlSchlaege { get; }
        int GesamtAnzahlSchlaege { get; }
        int Lochnummer { get; }
        Dictionary<int, int> ErgebnisZurueck { get; }
        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();

    }
}