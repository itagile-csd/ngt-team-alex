using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : IOperation
    {
        private IBefehleListe _befehleListe;
        public Hilfe(IBefehleListe befehleListe)
        {
            _befehleListe = befehleListe;
        }

        public string FuehreAus(IScorecard scorecard)
        {
            var hilfstexte = _befehleListe.Befehle().ConvertAll(HilfstextFuer);
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " 
                + System.Environment.NewLine +
                   string.Join(System.Environment.NewLine, hilfstexte)
                   + ".";
        }

        public string HilfstextFuer(IBefehl befehl)
        {
            return string.Format(" * \"{0}\" [{1}] {2}", befehl.Kommando, befehl.KurzKommando,befehl.Erklaerung);
        }
    }
}