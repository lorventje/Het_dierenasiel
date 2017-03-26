using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class KatTest
    {
        private Kat kat;

        [TestInitialize]
        public void TestInitialize()
        {
            this.kat = new Kat("kees", "burmees", "onhandelbaar");
        }

        [TestMethod]
        public void TestNieuweKat()
        {
            Assert.AreEqual("kees", kat.Naam, "incorrect Katnaam");
            Assert.AreEqual("burmees", kat.Soort, "incorrect Katsoort");
            Assert.AreEqual("onhandelbaar", kat.katGewoonte, "incorrect Katgewoonte");
        }
    }
}
