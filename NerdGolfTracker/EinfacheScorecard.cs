namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {

        public int AnzahlSchlaege { get; private set; }
        public int Lochnummer { get; private set; }
        public int GesamtAnzahlSchlaege { get; private set; }

        public EinfacheScorecard()
        {
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
            GesamtAnzahlSchlaege++;
        }
    }
}