namespace NerdGolfTracker.Operationen
{
    public class Gesamtschlaege : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return string.Format("Gesamtzahl deiner Schlaege ist: {0}", scorecard.GesamtAnzahlSchlaege);
        }
    }
}
