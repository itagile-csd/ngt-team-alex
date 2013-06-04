using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        public string Kommando
        {
            get { return "Naechstes Loch"; }
        }

        public string KurzKommando
        {
            get { return "n"; }
        }

        public Operation Operation
        {
            get { return new Lochwechsel(); }
        }

        public string Erklaerung
        {
            get { return "bringt Dich zum naechsten Loch"; }
        }
    }
}