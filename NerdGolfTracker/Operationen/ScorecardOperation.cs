using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class ScorecardOperation : Operation
    {
        private string c_Header = " Loch | Schläge" + Environment.NewLine;
        public string FuehreAus(Scorecard scorecard)
        {
            String gesamtAnzeige = c_Header;
            return gesamtAnzeige;
        }

    }
}
