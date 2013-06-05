using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : BefehlBasis
    {
        public LochwechselBefehl()
            : base("Naechstes Loch", "n", "bringt Dich zum naechsten Loch", new Lochwechsel())
        {
        }
    }
}