using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            List<Befehl> befehle = new AlleBefehle().Befehle();
            Befehl gefundenerBefehl = befehle.Find(befehl => kommando == befehl.Kommando);
            if (gefundenerBefehl == null)
            {
                gefundenerBefehl = befehle.Find(befehl => kommando == befehl.KurzKommando);
                
            }

            if (gefundenerBefehl == null)
            {
                return null;
            }
            else
            {
                return gefundenerBefehl.Operation;
            }
        }
    }
}
