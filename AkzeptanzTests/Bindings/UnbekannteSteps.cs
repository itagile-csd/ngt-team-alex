using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class UnbekannteSteps
    {
        private readonly TrackerDriver _driver;

        public UnbekannteSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich eine dem NerdGolfTracker unbekannte Eingabe mache")]
        public void SendeUnbekannteAnweisung()
        {
            _driver.EmpfangeAnweisung("xxxxxx");
        }

        [Then(@"weist mich der Tracker auf die Hilfe hin")]
        public void PruefeHinweisZurBenutzung()
        {
            _driver.AssertThatAntwortContains("Unbekannter Befehl. \"Hilfe\" zeigt alle bekannten Befehle an.");
        }
    }
}
