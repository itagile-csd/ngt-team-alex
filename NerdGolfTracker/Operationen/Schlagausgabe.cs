namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            if(scorecard.AnzahlSchlaege == 1)
                return string.Format("{0} Schlag", scorecard.AnzahlSchlaege);
            return string.Format("{0} Schlaege", scorecard.AnzahlSchlaege);        
        }
    }
}