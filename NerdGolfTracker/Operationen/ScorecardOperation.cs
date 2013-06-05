using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class ScorecardOperation : Operation
    {
        private readonly string c_Header = " Loch | Schläge" + Environment.NewLine;
        public string FuehreAus(Scorecard scorecard)
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
            return lochNummer + " | " + schlaege + Environment.NewLine;

        }

    }
}
