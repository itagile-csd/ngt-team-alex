using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    abstract class BefehlBasis : IBefehl
    {
        protected string _Kommando;
        protected string _KurzKommando;
        protected string _Erklaerung;
        protected IOperation _Gesamtschlaege;

        public string Kommando
        {
            get { return _Kommando; }
        }

        public string Erklaerung
        {
            get { return _Erklaerung; }
        }

        public string KurzKommando
        {
            get { return _KurzKommando; }
        }

        public IOperation Operation
        {
            get { return _Gesamtschlaege; }
        }

        protected BefehlBasis(string kommando, string kurzKommando, string erklaerung, IOperation operation)
        {
            _Kommando = kommando;
            _KurzKommando = kurzKommando;
            _Erklaerung = erklaerung;
            _Gesamtschlaege = operation;
        }
    }
}
