using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestFixture]
    class HilfeTest
    {
        [Test]
        public void GibtBeschreibungUndEineZeileProBefehlAus()
        {
            var ausgabe = new Hilfe().FuehreAus(null);
            var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);

            var befehlstyp = typeof(NerdGolfTracker.IBefehl);
            var alleBefehlstypen = befehlstyp.Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Except(new[] { befehlstyp }).ToList();

            Assert.That(zeilen.Length, Is.EqualTo(alleKonkretenBefehlstypen.Count() + 1));
        }

        [Test]
        public void GibtKommandKurzKomandoUndBeschreibungProBefehlAus()
        {
            var text = new Hilfe().HilfstextFuer(new TestBefehl());
            string expected = string.Format(" * \"{0}\" [{1}] {2}",
                                            TestBefehl._meintestkommando, 
                                            TestBefehl._meintestkurzkommando,
                                            TestBefehl._meintestkommandobeschreibung);
            Assert.That(text, Is.EqualTo(expected));
        }
    }

    internal class TestBefehl : IBefehl
    {
        internal const string _meintestkommando = "MeinTestKommando";
        internal const string _meintestkurzkommando = "MeinTestKurzKommando";
        internal const string _meintestkommandobeschreibung = "MeinTestKommandoBeschreibung";

        public string Kommando { get { return _meintestkommando; } }
        public string KurzKommando { get { return _meintestkurzkommando; } }
        public IOperation Operation { get { return null; } }
        public string Erklaerung { get { return _meintestkommandobeschreibung; } }
    }
}
