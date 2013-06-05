using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : BefehlBasis
    {
        public LochwechselBefehl()
            : base(
                Commandos.Commando.NaechstesLoch, 
                Commandos.Commando.NaechstesLochKurz, 
                "bringt Dich zum naechsten Loch", 
                new Lochwechsel())
        {
        }
    }
}