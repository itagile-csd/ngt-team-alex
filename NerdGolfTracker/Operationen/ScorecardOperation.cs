using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class ScorecardOperation : IOperation
    {
        private  const  string cSchlaege = "Schlaege";
        private  const  string cLoch = "Loch";
        private readonly string c_Header = " " + cLoch + " | " + cSchlaege + Environment.NewLine;

        public string FuehreAus(IScorecard scorecard)
        {
            String gesamtAnzeige = c_Header;
            for (int i = 1; scorecard != null && i <= scorecard.ErgebnisZurueck.Count; i++)
            {
                gesamtAnzeige += GetFormattedStringForLine(i, scorecard.ErgebnisZurueck[i]);
            }

            return gesamtAnzeige;
        }

        private string GetFormattedStringForLine(int lochNummer, int schlaege)
        {
            return String.Format("{0,5} | {1,8}", lochNummer, schlaege) + Environment.NewLine;
        }

    }
}
