using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class DierenasielTest
    {
        private Dierenasiel dierenasiel;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dierenasiel = new Dierenasiel("opvangertjes", "Haarlem");
        }
        [TestMethod]
        public void ConstructorTestNieuwDierenasiel()
        {
            Assert.AreEqual("opvangertjes", dierenasiel.dierenasielNaam, "incorrect Asielnaam");
            Assert.AreEqual("Haarlem", dierenasiel.dierenasielLocatie, "incorrect Asiellocatie");
        }
        [TestMethod]
        public void TestKatToevoegenAanLijst()
        {
            Assert.AreEqual(0, this.dierenasiel.aanwezigeHuisdieren.Count);
            dierenasiel.KatToevoegen(new Kat("kees", "bermuda", "avontuurlijk"));
            Assert.AreEqual(1, this.dierenasiel.aanwezigeHuisdieren.Count);
        }
        [TestMethod]
        public void TestHondToevoegenAanLijst()
        {
            Assert.AreEqual(0, this.dierenasiel.aanwezigeHuisdieren.Count);
            dierenasiel.HondToevoegen(new Hond("kees", "bermuda", new DateTime(2008, 12, 01)));
            Assert.AreEqual(1, this.dierenasiel.aanwezigeHuisdieren.Count);
        }
        [TestMethod]
        public void TestHuisdierVerwijderenUitLijst()
        {
            dierenasiel.HondToevoegen(new Hond("kees", "bermuda", new DateTime(2008, 12, 01)));
            dierenasiel.KatToevoegen(new Kat("kees", "bermuda", "avontuurlijk"));
            dierenasiel.HondToevoegen(new Hond("keesje", "bermudatje", new DateTime(2010, 12, 01)));
            Assert.AreEqual(3, this.dierenasiel.aanwezigeHuisdieren.Count);
            dierenasiel.HuisdierVerwijderen(dierenasiel.aanwezigeHuisdieren[1]);
            Assert.AreEqual(2, this.dierenasiel.aanwezigeHuisdieren.Count);
        }
    }
}
