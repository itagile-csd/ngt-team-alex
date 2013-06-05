using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : BefehlBasis
    {
        public  HilfeBefehl():base(
            
        "Hilfe","h","zeigt Dir diese Erklaerung",new Hilfe())
        {
        }
    }
}