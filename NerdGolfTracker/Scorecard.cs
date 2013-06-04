namespace NerdGolfTracker
{
    public interface Scorecard
    {
        int AnzahlSchlaege { get; }
        int GesamtAnzahlSchlaege { get; }
        int Lochnummer { get; }

        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
    }
}