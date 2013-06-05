using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        private readonly IBefehleListe _befehle;

        public EinfacherInterpreter(IBefehleListe befehle)
        {
            _befehle = befehle;
        }

        public IOperation OperationFuer(string kommando)
        {
            IOperation operationResult = null;

            List<IBefehl> befehle = _befehle.Befehle();
            IBefehl gefundenerBefehl = befehle.Find(befehl => ((kommando == befehl.Kommando) || (kommando == befehl.KurzKommando)));

            if (gefundenerBefehl != null)
            {
                operationResult = gefundenerBefehl.Operation;
            }

            return operationResult;
        }
    }
}
