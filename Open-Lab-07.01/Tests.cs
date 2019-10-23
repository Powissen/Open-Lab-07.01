using System;
using NUnit.Framework;

namespace Open_Lab_07._01
{
    [TestFixture]
    public class Tests
    {
        private Person johnyDepp;
        private Person bruceWillis;
        private Person tomHanks;
        private Person kateBeckinsale;
        private Person emmaWatson;
        private Person jessicaBiel;
        private TimeSpan tolerance = TimeSpan.FromSeconds(10);

        [SetUp]
        public void SetUp()
        {
            johnyDepp = new Person("Johny", "Depp", new DateTime(1963, 6, 9));
            bruceWillis = new Person("Bruce", "Willis", new DateTime(1955, 3, 19));
            tomHanks = new Person("Tom", "Hanks", new DateTime(1956, 7, 9));
            kateBeckinsale = new Person("Kate", "Beckinsale", new DateTime(1973, 7, 26));
            emmaWatson = new Person("Emma", "Watson", new DateTime(1990, 4, 15));
            jessicaBiel = new Person("Jessica", "Biel", new DateTime(1982, 3, 3));
        }

        [Test]
        public void JohnyDepp() =>
            Assert.That(johnyDepp.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1963, 6, 9))
                    .Within(tolerance));

        [Test]
        public void BruceWillis() =>
            Assert.That(bruceWillis.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1955, 3, 19))
                    .Within(tolerance));

        [Test]
        public void TomHanks() =>
            Assert.That(tomHanks.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1956, 7, 9))
                    .Within(tolerance));

        [Test]
        public void KateBeckinsale() =>
            Assert.That(kateBeckinsale.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1973, 7, 26))
                    .Within(tolerance));

        [Test]
        public void EmmaWatson() =>
            Assert.That(emmaWatson.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1990, 4, 15))
                    .Within(tolerance));

        [Test]
        public void JessicaBiel() =>
            Assert.That(jessicaBiel.GetAge(),
                Is.EqualTo(DateTime.Now - new DateTime(1982, 3, 3))
                    .Within(tolerance));
    }
}