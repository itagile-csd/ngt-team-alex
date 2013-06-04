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
    class LochAnzeigenTest
    {
        [Test]
        public void AktuellesLochAnzeigen()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
            Assert.That(new Lochbegruessung().FuehreAus(scorecardStub.Object),
                Contains.Substring("auf dem 2. Loch"));

          
        }
    }
}
