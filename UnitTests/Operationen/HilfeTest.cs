using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
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

            var befehlstyp = typeof(NerdGolfTracker.Befehl);
            var alleBefehlstypen = befehlstyp.Assembly.GetTypes().Where(befehlstyp.IsAssignableFrom);
            var alleKonkretenBefehlstypen = alleBefehlstypen.Except(new[] { befehlstyp }).ToList();

            Assert.That(zeilen.Length, Is.EqualTo(alleKonkretenBefehlstypen.Count() + 1));
        }
    }
}
