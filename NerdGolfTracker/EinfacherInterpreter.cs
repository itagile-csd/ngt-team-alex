using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        public IOperation OperationFuer(string kommando)
        {
            IOperation operationResult = null;

            List<IBefehl> befehle = new AlleBefehle().Befehle();
            IBefehl gefundenerBefehl = befehle.Find(befehl => ((kommando == befehl.Kommando) || (kommando == befehl.KurzKommando)));

            if (gefundenerBefehl != null)
            {
                operationResult = gefundenerBefehl.Operation;
            }

            return operationResult;
        }
    }
}
