namespace NerdGolfTracker
{
    public class Tracker
    {
        private IOperation _startoperation;
        private IScorecard _scorecard;
        private IInterpreter _interpreter;
        private IOperation _fallbackOperation;

        public Tracker(IInterpreter interpreter, IScorecard scorecard, IOperation startoperation, IOperation fallbackOperation)
        {
            _interpreter = interpreter;
            _scorecard = scorecard;
            _startoperation = startoperation;
            _fallbackOperation = fallbackOperation;
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
                return _fallbackOperation.FuehreAus(_scorecard);
            }
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}