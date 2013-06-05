using System;
using Moq;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    class EinfacherInterpreterTest
    {
        [TestCase("Dummy", typeof(DummyOperation))]
        public void FindetOperation(string kommando, Type operationstyp)
        {
            List<IBefehl> alleBefehle = new List<IBefehl>();
            alleBefehle.Add(new DummyBefehl());

            var befehleMock = new Mock<IBefehleListe>();
            befehleMock.Setup(befehl => befehl.Befehle()).Returns(alleBefehle);

            IInterpreter interpreter = new EinfacherInterpreter(befehleMock.Object);
            Assert.That(interpreter.OperationFuer(kommando), Is.InstanceOf(operationstyp));
        }

        [TestCase("xyz", Result = null)]
        public object InvalidCommand(string kommando)
        {
            IInterpreter interpreter = new EinfacherInterpreter(new AlleBefehle());
            return (interpreter.OperationFuer(kommando));
        }

        public class DummyBefehl : IBefehl
        {

            public IOperation Operation
            {
                get { return new DummyOperation();}
            }

            public string Kommando
            {
                get { return "Dummy"; }
            }

            public string KurzKommando
            {
                get { throw new NotImplementedException(); }
            }

            public string Erklaerung
            {
                get { throw new NotImplementedException(); }
            }
        }

        public class DummyOperation : IOperation
        {

            public string FuehreAus(IScorecard scorecard)
            {
                return "DummyOperation";
            }
        }
    }
}
