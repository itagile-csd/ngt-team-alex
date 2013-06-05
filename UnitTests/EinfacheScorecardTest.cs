using NUnit.Framework;
using NerdGolfTracker;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class EinfacheScorecardTest
    {
        private IScorecard _scorecard;

        [SetUp]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [Test]
        public void InkrementiertSchlagzahlEinmal()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(1));
        }
        
        [Test]
        public void InitGesamtschlagzahl()
        {
            Assert.That(_scorecard.GesamtAnzahlSchlaege, Is.EqualTo(0));
        }

        [Test]
        public void GesamtschlagzahlEinLoch()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.GesamtAnzahlSchlaege, Is.EqualTo(1));
        }

        [Test]
        public void GesamtschlagzahlMitLochwechsel()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.GesamtAnzahlSchlaege, Is.EqualTo(2));
        }
        [Test]
        public void InkrementiertSchlagzahlMehrmals()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(2));
        }

        [Test]
        public void ErhoehtLochnummerBeiLochwechselUndSetzeSchlagzehlAunNull()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();
            Assert.That(_scorecard.Lochnummer, Is.EqualTo(2));
            Assert.That(_scorecard.AnzahlSchlaege,Is.EqualTo(0));
            Assert.That(_scorecard.ErgebnisZurueck[1], Is.EqualTo(2));
            Assert.That(_scorecard.ErgebnisZurueck[2], Is.EqualTo(0));
        }

        [Test]
        public void InitialisiereSchlagzahlBeiLochwechsel()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();

            Int32 lochnummer = _scorecard.Lochnummer;

            Assert.That(_scorecard.AnzahlSchlaege, Is.EqualTo(0));
            
            Assert.That(_scorecard.ErgebnisZurueck[lochnummer], Is.EqualTo(0));
        }

        [Test]
        public void UeberprüfeScorecardTabelle()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.SchliesseLochAb();

            Dictionary<int, int> ergebnis = _scorecard.ErgebnisZurueck;
            Assert.That(ergebnis.Count, Is.EqualTo(3));
            Assert.That(ergebnis[1], Is.EqualTo(1));
            Assert.That(ergebnis[2], Is.EqualTo(3));
            Assert.That(ergebnis[3], Is.EqualTo(0));


        }

    }
}