using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class ReserveringTest
    {
        private Reservering reservering;

        [TestInitialize]
        public void TestInitialize()
        {
            this.reservering = new Reservering(11, new DateTime(2011, 12, 01));
        }
        [TestMethod]
        public void ConstructorTestNieuweReservering()
        {
            Assert.AreEqual(11, reservering.reserveringsNummer, "incorrect reserveringsNummer");
            Assert.AreEqual(new DateTime(2011, 12, 01), reservering.reserveringsDatum, "incorrect reserveringsDatum");
        }
        [TestMethod]
        public void TestKatToevoegenAanLijst()
        {
            Assert.AreEqual(0, this.reservering.lijstGereserveerdeHuisdieren.Count);
            reservering.KatToevoegen(new Kat("kees", "bermuda", "avontuurlijk"));
            Assert.AreEqual(1, this.reservering.lijstGereserveerdeHuisdieren.Count);
        }
        [TestMethod]
        public void TestHondToevoegenAanLijst()
        {
            Assert.AreEqual(0, this.reservering.lijstGereserveerdeHuisdieren.Count);
            reservering.HondToevoegen(new Hond("kees", "bermuda", new DateTime(2008, 12, 01)));
            Assert.AreEqual(1, this.reservering.lijstGereserveerdeHuisdieren.Count);
        }
        [TestMethod]
        public void HuisdierVerwijderenUitLijst()
        {
            reservering.HondToevoegen(new Hond("kees", "bermuda", new DateTime(2008, 12, 01)));
            reservering.KatToevoegen(new Kat("kees", "bermuda", "avontuurlijk"));
            reservering.HondToevoegen(new Hond("keesje", "bermudatje", new DateTime(2010, 12, 01)));
            Assert.AreEqual(3, this.reservering.lijstGereserveerdeHuisdieren.Count);
            reservering.HuisdierVerwijderen(reservering.lijstGereserveerdeHuisdieren[1]);
            Assert.AreEqual(2, this.reservering.lijstGereserveerdeHuisdieren.Count);
        }
    }
}
