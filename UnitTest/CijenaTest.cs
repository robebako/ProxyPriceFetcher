using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProxyPriceFetcher
{
    [TestClass]
    public class CijenaTest
    {
        [TestMethod]
        public void PrikaziCijenuReturns6point80ForArtiklMlijeko()
        {
            Cijena c = new Cijena();
            Assert.AreEqual(6.80,c.prikaziCijenu("Mlijeko"));
        }
    }
}
