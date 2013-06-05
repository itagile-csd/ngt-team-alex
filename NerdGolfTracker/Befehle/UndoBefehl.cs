using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class UndoBefehl : BefehlBasis
    {
        public UndoBefehl()
            : base(
                Commandos.Commando.Undo, 
                Commandos.Commando.UndoKurz, 
                "macht den letzten Befehl rückgängig", 
                new Undo())
        {
        }
    }
}
