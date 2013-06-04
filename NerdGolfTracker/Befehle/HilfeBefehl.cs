using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Hilfe"; }
        }

        public string KurzKommando
        {
            get { return "h"; }
        }

        public Operation Operation
        {
            get { return new Hilfe(); }
        }

        public string Erklaerung
        {
            get { return "zeigt Dir diese Erklaerung"; }
        }
    }
}