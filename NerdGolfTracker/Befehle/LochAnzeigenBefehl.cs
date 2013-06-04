using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochAnzeigenBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Aktuelles Loch"; }
        }

        public string KurzKommando
        {
            get { return "a"; }
        }

        public Operation Operation
        {
            get
            {
                return new Lochbegruessung();
            }
        }

        public string Erklaerung 
        {
            get { return "zeigt Dir das aktuelle Loch"; }
        }
    }
}
