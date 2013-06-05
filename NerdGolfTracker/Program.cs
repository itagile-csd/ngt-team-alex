using System;
using NerdGolfTracker.Operationen;


namespace NerdGolfTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var tracker = new Tracker(new EinfacherInterpreter(new AlleBefehle()),
                                      new EinfacheScorecard(),
                                      new Lochbegruessung(),
                                      new FallbackOperation());

            Console.WriteLine(tracker.Starte());
            while (true)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));                
            }
        }
    }
}
