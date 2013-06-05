namespace NerdGolfTracker.Operationen
{
    public class Gesamtschlaege : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return string.Format("Gesamtschlaege: {0}", scorecard.GesamtAnzahlSchlaege);
        }
    }
}
