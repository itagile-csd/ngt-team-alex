using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class StorycardSteps
    {

        [When(@"ich folgendermassen spiele:")]
        public void WennIchFolgendermassenSpiele(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"erhalte ich diese Scorcard\.")]
        public void DannErhalteIchDieseScorcard_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
