using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : BefehlBasis
    {
        public HilfeBefehl()
            : base(
                Commandos.Commando.Hilfe,
                Commandos.Commando.HilfeKurz,
                "zeigt Dir diese Erklaerung",
                new Hilfe(new AlleBefehle()))
        {
        }
    }
}