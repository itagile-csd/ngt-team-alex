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
        [TestCase("N", typeof(Lochwechsel))]
        [TestCase("S", typeof(Schlag))]
        [TestCase("H", typeof(Hilfe))]
        [TestCase("A", typeof(Lochbegruessung))]
        public void FindetOperation(string kommando, Type operationstyp)
        {
            Interpreter interpreter = new EinfacherInterpreter();
            Assert.That(interpreter.OperationFuer(kommando), Is.InstanceOf(operationstyp));
        }
    }
}
