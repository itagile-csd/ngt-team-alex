using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Schlage Ball"; }
        }

        public string KurzKommando
        {
            get { return "S"; }
        }

        public Operation Operation
        {
            get { return new Schlag(); }
        }

        public string Erklaerung
        {
            get { return "zaehlt einen Schlag"; }
        }
    }
}