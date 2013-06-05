using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using NerdGolfTracker.Befehle;

namespace UnitTests.Operationen
{
    [TestFixture]
    class ScorecardTest
    {
        private IScorecard _scorecard;

        [SetUp]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [Test]
        public void ScoreCard_HeaderAnzeigen()
        {
            string resultText = new ScorecardOperation().FuehreAus(null);
            var lines = resultText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var firstLine = lines.First();
            Assert.That(firstLine, Contains.Substring("Loch"));
            Assert.That(firstLine, Contains.Substring("Schläge"));
        }

        [Test]
        public void ScoreCard_ZeilenAusgabe()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();

            string resultText = new ScorecardOperation().FuehreAus(_scorecard);
            var lines = resultText.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var secondLine = lines[1];
            secondLine = secondLine.Replace(" ", string.Empty);

            Assert.That(secondLine.StartsWith("1") && secondLine.EndsWith("1"), "Loch und Anzahl ist wrong");

            var thirdLine = lines[2];
            thirdLine = thirdLine.Replace(" ", string.Empty);
            Assert.That(thirdLine.StartsWith("2") && thirdLine.EndsWith("0"), "Loch und Anzahl ist wrong");
        }
    }
}

