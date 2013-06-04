using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
     [Binding]
    class GesamtschlaegeSteps
    {
         private readonly TrackerDriver _driver;

         public GesamtschlaegeSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@".* insgesamt (.*) Schlaege")]
        public void PruefeGesamtschlaege(string gesamt)
        {
            _driver.EmpfangeAnweisung("g");
            _driver.AssertThatAntwortContains("{0}", gesamt);
        }
    }
}
