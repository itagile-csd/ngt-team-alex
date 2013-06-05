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
            String gesamtAnzeige = c_Header + "1 | 5" + Environment.NewLine +
                                              "2 | 7" + Environment.NewLine +
                                              "3 | 15" + Environment.NewLine;
            return gesamtAnzeige;
        }

    }
}
