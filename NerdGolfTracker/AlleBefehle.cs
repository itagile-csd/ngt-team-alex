using System;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    class AlleBefehle : IBefehleListe
    {
        public List<IBefehl> Befehle()
        {
            var befehlstyp = typeof (IBefehl);
            var alleBefehlstypen =
                GetType().Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Where(type => !type.IsAbstract && !type.IsInterface);
            return alleKonkretenBefehlstypen.ToList().ConvertAll(b => Activator.CreateInstance(b) as IBefehl);
        }
    }
}
