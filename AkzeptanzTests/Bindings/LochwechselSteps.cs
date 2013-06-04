using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class LochwechselSteps
    {
        private readonly TrackerDriver _driver;

        public LochwechselSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(".*zum nächsten Loch.*")]
        public void GeheZumNaechstenLoch()
        {
            _driver.EmpfangeAnweisung("Naechstes Loch");
        }

        [Then(@"zählt.* auf dem (\d+)\. (.*)\.")]
        [Then(@"begrüßt.* auf dem (\d+)\. (.*)\.")]
        public void PruefeLoch(int lochnummer, string lochnomen)
        {
            _driver.AssertThatAntwortContains("{0}.", lochnummer, lochnomen);
        }


        [Then(@"zählt der NGT wieder von 0 an")]
        public void PruefeZaehlenVon0()
        {
            _driver.EmpfangeAnweisung("Schlage Ball");
            _driver.AssertThatAntwortContains("1");
        }

    }
}
