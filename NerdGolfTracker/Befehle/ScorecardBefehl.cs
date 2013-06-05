using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    internal class ScorecardBefehl : BefehlBasis
    {
        public ScorecardBefehl()
            : base("Scorecard", "c", "zeigt Dir die Scorecard", new ScorecardOperation())
        {
        }
    }
}
