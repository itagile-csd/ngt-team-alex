using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class StorycardSteps
    {
        private readonly TrackerDriver _driver;

        private Dictionary<int, int> _LochUndSchlaege = new Dictionary<int, int>();

        public StorycardSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich folgendermassen spiele.")]
        public void WennIchFolgendermassenSpiele(Table table)
        {
            foreach (var row in table.Rows)
            {
                int lochInRow = int.Parse(row["Loch"]);
                int schlaegeInRow = int.Parse(row["Schlaege"]);

                for (int i = 0; i < schlaegeInRow; ++i)
                {
                    _driver.EmpfangeAnweisung("Schlage Ball");
                }
                _driver.EmpfangeAnweisung("Naechstes Loch");
                _LochUndSchlaege.Add(lochInRow, schlaegeInRow);
            }
        }

        [Then(@"erhalte ich diese Scorecard.*")]
        public void DannErhalteIchDieseScorcard()
        {
            _driver.EmpfangeAnweisung("Scorecard");
            string result = _driver.GetLetzteAntwort();
        
            foreach (var keyValuePair in _LochUndSchlaege)
            {
                Assert.True(Regex.IsMatch(result, String.Format(@"{0}.*{1}", keyValuePair.Key, keyValuePair.Value)), 
                            string.Format("Es gibt Unterschiede in Loch: {0}\n  Erwarteter Wert: {1}", keyValuePair.Key, keyValuePair.Value));

            }            
        }
    }
}
