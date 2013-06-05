using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NerdGolfTracker.Operationen
{
    public class FallbackOperation : IOperation
    {
        public string FuehreAus(IScorecard scorecard)
        {
            return "Unbekannter Befehl. \"Hilfe\" zeigt alle bekannten Befehle an.";
        }
    }
}
