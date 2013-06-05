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
                Commandos.Commando.GesamtAnzahlSchlaege,
                Commandos.Commando.GesamtAnzahlSchlaegeKurz,
                "zeigt Dir die Gesamtzahl der Schlaege",
                new Gesamtschlaege())
        {

        }
    }
}
