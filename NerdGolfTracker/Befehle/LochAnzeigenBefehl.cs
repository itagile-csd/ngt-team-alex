using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    class LochAnzeigenBefehl : BefehlBasis
    {
        public LochAnzeigenBefehl()
            : base("Aktuelles Loch", "a", "zeigt Dir das aktuelle Loch", new Lochbegruessung())
        {
        }
    }
}
