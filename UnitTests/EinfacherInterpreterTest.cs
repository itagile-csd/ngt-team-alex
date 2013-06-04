using System;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests
{
    [TestFixture]
    class EinfacherInterpreterTest
    {

        [TestCase("Naechstes Loch", typeof(Lochwechsel))]
        [TestCase("Schlage Ball", typeof(Schlag))]
        [TestCase("Hilfe", typeof(Hilfe))]
        [TestCase("Aktuelles Loch", typeof(Lochbegruessung))]
        [TestCase("Gesamte Schlaege", typeof(Gesamtschlaege))]
        [TestCase("n", typeof(Lochwechsel))]
        [TestCase("s", typeof(Schlag))]
        [TestCase("h", typeof(Hilfe))]
        [TestCase("a", typeof(Lochbegruessung))]
        [TestCase("g", typeof(Gesamtschlaege))]
        public void FindetOperation(string kommando, Type operationstyp)
        {
            Interpreter interpreter = new EinfacherInterpreter();
            Assert.That(interpreter.OperationFuer(kommando), Is.InstanceOf(operationstyp));
        }

        [TestCase("xyz", Result = null)]
        public object InvalidCommand(string kommando)
        {
            Interpreter interpreter = new EinfacherInterpreter();
            return (interpreter.OperationFuer(kommando));
        }
    }
}
