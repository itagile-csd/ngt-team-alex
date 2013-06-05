namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            if(scorecard.AnzahlSchlaege == 1)
                return string.Format("{0} Schlag", scorecard.AnzahlSchlaege);
            return string.Format("{0} Schlaege", scorecard.AnzahlSchlaege);        
        }
    }
}