using System.Collections.Generic;

namespace NerdGolfTracker
{
    public interface Scorecard
    {
        int AnzahlSchlaege { get; }
        int Lochnummer { get; }
        Dictionary<int, int> ErgebnisZurueck { get; }
        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();

    }
}