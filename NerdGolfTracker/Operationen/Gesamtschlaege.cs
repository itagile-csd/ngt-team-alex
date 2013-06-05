namespace NerdGolfTracker.Operationen
{
    public class Gesamtschlaege : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Gesamtzahl deiner Schlaege ist: {0}", scorecard.GesamtAnzahlSchlaege);
        }
    }
}
