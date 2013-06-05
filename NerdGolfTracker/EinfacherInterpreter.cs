using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            Operation operationResult = null;

            List<IBefehl> befehle = new AlleBefehle().Befehle();
            IBefehl gefundenerBefehl =
                befehle.Find(befehl => ((kommando == befehl.Kommando) || (kommando == befehl.KurzKommando)));

            if (gefundenerBefehl != null)
            {
                operationResult = gefundenerBefehl.Operation;
            }

            return operationResult;
        }
    }
}
