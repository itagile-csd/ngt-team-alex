using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
     [Binding]
    public class LochAnzeigenSteps
    {
        private readonly TrackerDriver _driver;

        public LochAnzeigenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich den Befehl aktuelles Loch anzeigen aufrufe")]
        public void ZeigeAktuellesLoch()
        {
            _driver.EmpfangeAnweisung("Aktuelles Loch");
        }

       [Then(@"schreibt der NerdGolfTracker (.*)\.Loch")]
        public void PruefeLoch(string lochnomen)
        {
            _driver.AssertThatAntwortContains("{0}.", lochnomen);
        }
    }
}
