using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class DierenasielTest
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Dierenasiel dierenasiel = new Dierenasiel("OpvangcentrumKoko", "Zuilichem");
            Assert.AreEqual("OpvangcentrumKoko", dierenasiel.dierenasielNaam, "incorrect Asielnaam");
            Assert.AreEqual("Zuilichem", dierenasiel.dierenasielLocatie, "incorrect Asiellocatie");

            Kat kat = new Kat("kees", "burmees", "zwerfer", "niet voor kinderen");
            Assert.AreEqual("kees", kat.naam, "incorrect Katnaam");
            Assert.AreEqual("burmees", kat.soort, "incorrect Katsoort");
            Assert.AreEqual("zwerfer", kat.status, "incorrect Katstatus");
            Assert.AreEqual("niet voor kinderen", kat.katGewoonte, "incorrect Katgewoonte");

            Hond hond = new Hond("brutus", "goldenRetriever", "gevonden", (new DateTime(2008)));
            Assert.AreEqual("brutus", hond.naam, "incorrect Hondnaam");
            Assert.AreEqual("goldenRetriever", hond.soort, "incorrect Hondsoort");
            Assert.AreEqual("gevonden", hond.status, "incorrect Hondstatus");

            Reservatie reservatie = new Reservatie(801);
            Assert.AreEqual(801, reservatie.reserveringsNummer);

            Klant klant = new Klant("willem", "kaapstraat 27", 0640478279);
            Assert.AreEqual("willem", klant.klantNaam, "incorrect klantNaam");
            Assert.AreEqual("kaapstraat 27", klant.klantAdres, "incorrect klantAdres");
            Assert.AreEqual(0640478279, klant.klantTelefoonnummer, "incorrect klantTelefoon");
        }
    }
}
