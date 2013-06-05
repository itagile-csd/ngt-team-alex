using System.Collections.Generic;

namespace NerdGolfTracker
{
    public interface IBefehleListe
    {
        List<IBefehl> Befehle();
    }
}