using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : BefehlBasis
    {
        public SchlagBefehl()
            : base("Schlage Ball", "s", "zaehlt einen Schlag", new Schlag())
        {
        }
    }
}