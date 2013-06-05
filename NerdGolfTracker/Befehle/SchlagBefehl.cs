using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : BefehlBasis
    {
        public SchlagBefehl()
            : base(
                Commandos.Commando.SchlageBall, 
                Commandos.Commando.SchlageBallKurz, 
                "zaehlt einen Schlag", 
                new Schlag())
        {
        }
    }
}