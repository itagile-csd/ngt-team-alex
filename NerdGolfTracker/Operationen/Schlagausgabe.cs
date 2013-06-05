namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            string schlagWort;
            if (scorecard.AnzahlSchlaege == 1)
            {
                schlagWort = "Schlag";
            }
            else
            {
                schlagWort = "Schlaege";
            }

            return string.Format("{0} {1}", scorecard.AnzahlSchlaege, schlagWort);    
        }
    }
}