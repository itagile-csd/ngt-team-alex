using Moq;
using NerdGolfTracker;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TrackerTest
    {
        [Test]
        public void GibtErgebnisDerAusgeloestenOperationZurueck()
        {
            var interpreterStub = new Mock<IInterpreter>();
            var operationStub = new Mock<IOperation>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Eingabe"))
                .Returns(operationStub.Object);
            operationStub.Setup(operation => operation.FuehreAus(It.IsAny<IScorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(interpreterStub.Object, null, null, null);
            Assert.That(tracker.ReagiereAuf("Eingabe"), Is.EqualTo("Ausgabe"));
        }

        [Test]
        public void GibtErgebnisDerStartoperationZurueck()
        {
            var startoperationStub = new Mock<IOperation>();
            startoperationStub.Setup(operation => operation.FuehreAus(It.IsAny<IScorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(null, null, startoperationStub.Object, null);
            Assert.That(tracker.Starte(), Is.EqualTo("Ausgabe"));
        }

        
        [TestCase()]
        public void InvalidCommand_CheckErrorText()
        {
            var interpreterStub = new Mock<IInterpreter>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("blabla")).Returns((IOperation)null);
       
            var fallbackOperationStub = new Mock<IOperation>();
            fallbackOperationStub.Setup(operation => operation.FuehreAus(It.IsAny<IScorecard>()))
                .Returns("Unbekannter Befehl. \"Hilfe\" zeigt alle bekannten Befehle an.");

            var tracker = new Tracker(interpreterStub.Object, null, null, fallbackOperationStub.Object);
            Assert.That(tracker.ReagiereAuf("blabla"), Is.EqualTo("Unbekannter Befehl. \"Hilfe\" zeigt alle bekannten Befehle an."));
        }
    }
}