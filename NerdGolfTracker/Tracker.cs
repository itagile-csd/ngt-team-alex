namespace NerdGolfTracker
{
    public class Tracker
    {
        private IOperation _startoperation;
        private IScorecard _scorecard;
        private IInterpreter _interpreter;

        public Tracker(IInterpreter interpreter, IScorecard scorecard, IOperation startoperation)
        {
            _interpreter = interpreter;
            _scorecard = scorecard;
            _startoperation = startoperation;
        }

        public string ReagiereAuf(string kommando)
        {
            IOperation operation = _interpreter.OperationFuer(kommando);
            if (operation != null)
            {
                return operation.FuehreAus(_scorecard);
            }
            else
            {
                return "Unbekannter Befehl. \"Hilfe\" zeigt alle bekannten Befehle an.";
            }
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}