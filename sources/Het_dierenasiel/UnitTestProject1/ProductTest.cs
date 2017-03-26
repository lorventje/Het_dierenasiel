using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Het_dierenasiel
{
    using Het_dierenasiel;
    [TestClass]
    public class ProductTest
    {
        private Product product;

        [TestInitialize]
        public void TestInitialize()
        {
            this.product = new Product("dierenvoer", 20);
        }

        [TestMethod]
        public void TestNieuwProduct()
        {
            Assert.AreEqual("dierenvoer", product.Naam, "Incorrect productNaam");
            Assert.AreEqual(20, product.Prijs, "incorrect productPrijs");
        }
    }
}
