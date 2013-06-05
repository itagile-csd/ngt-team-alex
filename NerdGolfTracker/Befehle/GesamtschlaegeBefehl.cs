using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    class GesamtschlaegeBefehl : BefehlBasis
    {
        public GesamtschlaegeBefehl()
            : base(
                "Gesamte Schlaege",
                "g",
                "zeigt Dir die Gesamtzahl der Schlaege",
                new Gesamtschlaege())
        {

        }
    }
}
