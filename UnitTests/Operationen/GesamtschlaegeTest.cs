using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    /// <summary>
    /// Summary description for GesamtschlaegeTest
    /// </summary>
    [TestFixture]
    public class GesamtschlaegeTest
    {
        [Test]
        public void GesamtschlaegeAnzeigen()
        {
            var scorecardStub = new Mock<Scorecard>();
            scorecardStub.Setup(scorecard => scorecard.GesamtAnzahlSchlaege).Returns(2);
            Assert.That(new Gesamtschlaege().FuehreAus(scorecardStub.Object),
                Contains.Substring("Gesamtschlaege: 2"));
        }
    }
}
