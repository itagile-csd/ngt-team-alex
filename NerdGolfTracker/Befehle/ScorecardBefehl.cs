using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    internal class ScorecardBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Scorecard"; }
        }

        public string KurzKommando
        {
            get { return "c"; }
        }

        public Operation Operation
        {
            get { return new ScorecardOperation(); }
        }

        public string Erklaerung
        {
            get { return "zeigt Dir die Scorecard"; }
        }
    }
}
