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
            : base(
                Commandos.Commando.AktuellesLoch, 
                Commandos.Commando.AktuellesLochKurz, 
                "zeigt Dir das aktuelle Loch", 
                new Lochbegruessung())
        {
        }
    }
}
