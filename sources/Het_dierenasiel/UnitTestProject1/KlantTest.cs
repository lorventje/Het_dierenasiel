using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class KlantTest
    {
        private Klant klant;

        [TestInitialize]
        public void TestInitialize()
        {
            this.klant = new Klant("Jantje", "Zuilichem", 0640457569);
        }

        [TestMethod]
        public void ConstructorTestNieuweKlant()
        {
            Assert.AreEqual("Jantje", klant.klantNaam, "incorrect klantNaam");
            Assert.AreEqual("Zuilichem", klant.klantWoonplaats, "incorrect klantAdres");
            Assert.AreEqual(0640457569, klant.klantTelefoonnummer, "incorrect klantTelefoon");
        }
        [TestMethod]
        public void ReserveringToevoegen()
        {
            Assert.AreEqual(0, klant.reserveringsLijst.Count);
            klant.ReserveringToevoegen(new Reservering(112, DateTime.Now));
            Assert.AreEqual(1, klant.reserveringsLijst.Count);
        }
        [TestMethod]
        public void ReserveringVerwijderen()
        {
            klant.ReserveringToevoegen(new Reservering(112, DateTime.Now));
            klant.ReserveringToevoegen(new Reservering(114, DateTime.Now));
            Assert.AreEqual(2, klant.reserveringsLijst.Count);
            klant.ReserveringVerwijderen(klant.reserveringsLijst[1]);
            Assert.AreEqual(1, klant.reserveringsLijst.Count);
        }
    }
}
