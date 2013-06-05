using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    class GesamtschlaegeBefehl : IBefehl
    {
        public string Kommando
        {
            get { return "Gesamte Schlaege"; }
        }

        public string KurzKommando
        {
            get { return "g"; }
        }

        public Operation Operation
        {
            get
            {
                return new Gesamtschlaege();
            }
        }

        public string Erklaerung
        {
            get { return "zeigt Dir die Gesamtzahl der Schlaege"; }
        }
    }
}
